using Cafe_DeskApp.DTO;
using Cafe_DeskApp.ResponseDTO;
using Cafe_DeskApp.Services;
using Cafe_DeskApp.UserControls;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cafe_DeskApp
{
    public partial class CafeWinForm : Form
    {
        public CafeWinForm()
        {
            InitializeComponent();
        }

        public void ucControlList(UserControl controls)
        {
            controls.Dock = DockStyle.Fill;
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(controls);
            controls.BringToFront();
        }

        private void BtnClicks(object sender, EventArgs e)
        {
            foreach (var item in PnlTop.Controls.OfType<Panel>())
            {
                item.BackColor = Color.Silver;
            }
            if (sender is Button button)
            {
                //Button button = (Button)sender;
                switch (button.Name)
                {
                    case "BtnHome":
                        ucControlList(new UCHome());
                        PnlHome.BackColor = Color.MediumSeaGreen; break;
                    case "BtnRegister":
                        ucControlList(new UCRegister());
                        PnlRegister.BackColor = Color.MediumSeaGreen; break;
                    case "BtnUsers":
                        ucControlList(new UCUsers());
                        PnlUsers.BackColor = Color.MediumSeaGreen; break;
                    case "BtnActions":
                        ucControlList(new UCActions());
                        PnlActions.BackColor = Color.MediumSeaGreen; break;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UsernameInput.Text) && !string.IsNullOrEmpty(PasswordInput.Text))
            {
                AuthenticateUser user = new AuthenticateUser();
                user.Email = UsernameInput.Text;
                user.Password = PasswordInput.Text;

                string json = JsonConvert.SerializeObject(user);

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage res = GeneralParams.HttpCall().PostAsync("Login", content).Result;

                var check = res.Content.ReadAsStringAsync();

                var resModel = JsonConvert.DeserializeObject<LoginResponse>(check.Result);

                if (resModel.FlagCode == 1)
                {
                    var currentToken = resModel.Token;
                    var handler = new JwtSecurityTokenHandler();
                    var jwtToken = handler.ReadToken(currentToken) as JwtSecurityToken;

                    if(jwtToken != null)
                    {
                        var expiryDate = jwtToken.ValidTo;

                    }

                    if (resModel.Is2FAEnabled)
                    {
                        string email = UsernameInput.Text.ToString();
                        TFAform form = new TFAform(email, this);
                        form.Show();
                    }
                    else
                    {
                        OpenUCHome();
                    }
                }
                else
                {
                    this.Controls.Clear();
                    this.InitializeComponent();
                    MessageBox.Show("Login Credentials Incorrect!");
                    PnlTop.Visible = false;
                    PnlTop.Dock = DockStyle.None;
                }
            }
            else
            {
                MessageBox.Show("Please fill the form!");
            }
        }

        private void RegistrationLink_click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginRegistrationForm form = new LoginRegistrationForm();
            form.Show();
        }

        public void OpenUCHome()
        {
            ucControlList(new UCHome());
            PnlHome.BackColor = Color.MediumSeaGreen;
            PnlTop.Visible = true;
        }
    }
}

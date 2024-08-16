using Cafe_DeskApp.DTO;
using Cafe_DeskApp.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_DeskApp
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditData_click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.City = CityInput.Text;
            user.Phone = PhoneInput.Text;
            user.Name = NameInput.Text;
            user.Email = EmailInput.Text;
            user.Id = Convert.ToInt32(IdBox.Text);
            string json = JsonConvert.SerializeObject(user);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");


            HttpResponseMessage res = GeneralParams.HttpCall().PostAsync($"UpdateUser", content).Result;

            MessageBox.Show("Updated Successfully!");

            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void FetchData_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PhoneInputBox.Text))
            {
                string phoneNumber = PhoneInputBox.Text;

                HttpResponseMessage res = GeneralParams.HttpCall().GetAsync($"GetUserByPhoneNumber?phoneNumber={phoneNumber}").Result;

                var users = res.Content.ReadAsStringAsync().Result;
                var resutl = JsonConvert.DeserializeObject<Users>(users);
                if (res.StatusCode.ToString() == "OK")
                {
                    NameInput.Visible = true;
                    EmailInput.Visible = true;
                    PhoneInput.Visible = true;
                    CityInput.Visible = true;
                    EditData.Visible = true;

                    NameInput.Text = resutl.Name;
                    EmailInput.Text = resutl.Email;
                    PhoneInput.Text = resutl.Phone;
                    CityInput.Text = resutl.City;
                    IdBox.Text = resutl.Id.ToString();
                }
            }
        }
    }
}

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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_DeskApp
{
    public partial class LoginRegistrationForm : Form
    {
        public LoginRegistrationForm()
        {
            InitializeComponent();
        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UsernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginPasswordRegisterBtn_Click(object sender, EventArgs e)
        {
            AuthenticateUser user = new AuthenticateUser();
            user.Email = UsernameInput.Text;
            user.Password = PasswordInput.Text;
            user.Is2FAEnabled = Enable2FA.Checked;
            string json = JsonConvert.SerializeObject(user);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage res = GeneralParams.HttpCall().PostAsync($"RegisterLoginUser", content).Result;
            if (res.StatusCode.ToString() == "OK")
            {
                this.Controls.Clear();
                this.InitializeComponent();
                var check = res.Content.ReadAsStringAsync();
                MessageBox.Show("Submitted successfully!");
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void CnfPassword_keyup(object sender, KeyEventArgs e)
        {
            PassLabel.Visible = true;
            if (PasswordInput.Text != ConfirmPasswordInput.Text) 
            {
                PassLabel.Text = "Not Matched";
                PassLabel.ForeColor = Color.Red;
                LoginPasswordRegisterBtn.Enabled = false;
            }
            else
            {
                PassLabel.Text = "Password Matched";
                PassLabel.ForeColor = Color.Green;
                LoginPasswordRegisterBtn.Enabled = true;
            }
        }
            
        private void IsShowPassword_checked(object sender, EventArgs e)
        {
            if (IsShowPassword.Checked)
            {
                IsShowPassword.Text = "Hide";
                PasswordInput.PasswordChar = '\0';
            }
            else
            {
                IsShowPassword.Text = "Show";
                PasswordInput.PasswordChar = '*';
            }
        }

        private void IsShowCnfPassword_checked(object sender, EventArgs e)
        {
            if (IsShowCnfPassword.Checked)
            {
                IsShowCnfPassword.Text = "Hide";
                ConfirmPasswordInput.PasswordChar = '\0';
            }
            else
            {
                IsShowCnfPassword.Text = "Show";
                ConfirmPasswordInput.PasswordChar = '*';
            }
        }

        private void EmailFormatCheck_keyup(object sender, KeyEventArgs e)
        {
            string emailPattern = @"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$";
            EmailFormat.Visible = true;

            if(Regex.IsMatch(UsernameInput.Text, emailPattern))
            {
                EmailFormat.Text = "Email Format is Correct!";
                EmailFormat.ForeColor = Color.Green;
            }
            else
            {
                EmailFormat.Text = "Email Format is Incorrect!";
                EmailFormat.ForeColor = Color.Red;
            }

        }
    }
}

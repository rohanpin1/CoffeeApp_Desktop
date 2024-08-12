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

namespace Cafe_DeskApp.UserControls
{
	public partial class UCActions : UserControl
	{
		public UCActions()
		{
			InitializeComponent();
		}
				
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void EditBtn_click(object sender, EventArgs e)
		{
			try
			{
				Users user = new Users();
				user.City = EditCityInput.Text;
				user.Phone = EditPhoneInput.Text;
				user.Name = EditNameInput.Text;
				user.Email = EditEmailInput.Text;
				user.Id =Convert.ToInt32(UserId.Text);
				string json = JsonConvert.SerializeObject(user);
				StringContent content = new StringContent(json, Encoding.UTF8, "application/json");


				HttpClient client = new HttpClient();
				client.BaseAddress = new Uri(GeneralParams.Uri);
				HttpResponseMessage res = client.PostAsync($"UpdateUser", content).Result;

				MessageBox.Show("Updated Successfully!");
				this.Controls.Clear();
				this.InitializeComponent();
				ucControl(new UCHome());
			}
			catch (Exception)
			{

				throw;
			}
		}

		public void SetUserdata(Users user)
		{
			EditNameInput.Text = user.Name;
			EditEmailInput.Text = user.Email;
			EditPhoneInput.Text = user.Phone;
			EditCityInput.Text = user.City;
			UserId.Text = user.Id.ToString();
		}

		private void ucControl(UserControl ucControl)
		{
			ucControl.Dock = DockStyle.Fill;
			PnlUcActions.Controls.Clear();
			PnlUcActions.Controls.Add(ucControl);
			ucControl.BringToFront();
		}
	}
}

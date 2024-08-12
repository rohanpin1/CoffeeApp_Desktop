using Cafe_DeskApp.Services;
using Cafe_DeskApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_DeskApp
{
	public partial class CafeWinForm : Form
	{
		public CafeWinForm()
		{
			InitializeComponent();
		}

		public void ucControlList (UserControl controls)
		{
			controls.Dock = DockStyle.Fill;
			PnlMain.Controls.Clear();
			PnlMain.Controls.Add(controls);
			controls.BringToFront();
		}

		private void BtnClicks(object sender, EventArgs e)
		{
			foreach(var item in PnlTop.Controls.OfType<Panel>())
			{
				item.BackColor = Color.Silver;
			}

			Button button = (Button)sender;
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
				case "BtnInfo":
					ucControlList(new UCInfo());
					PnlInfo.BackColor = Color.MediumSeaGreen; break;
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void LoginSubmit_Click(object sender, EventArgs e)
		{
			using (var conn = DBConnection.ConnectionOpen())
			{
				using (var cmd = new SqlCommand("SELECT COUNT(1) FROM authenticateusers WHERE username = @username AND password = @password", conn))
				{
					cmd.Parameters.AddWithValue("@username", UsernameInput.Text.ToString());
					cmd.Parameters.AddWithValue("@password", PasswordInput.Text.ToString()); 

					int userCount = (int)cmd.ExecuteScalar();

					if (userCount == 1)
					{
						ucControlList(new UCHome());
						PnlHome.BackColor = Color.MediumSeaGreen;
						PnlTop.Visible = true;							
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
			}
		}
	}
}

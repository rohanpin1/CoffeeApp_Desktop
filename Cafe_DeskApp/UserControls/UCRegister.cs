using Cafe_DeskApp.Services;
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

namespace Cafe_DeskApp.UserControls
{
    public partial class UCRegister : UserControl
    {
        public UCRegister()
        {
            InitializeComponent();
        }

        private void saveClickBtn(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(NameInput.Text) && !string.IsNullOrEmpty(PhoneInput.Text) && !string.IsNullOrEmpty(EmailInput.Text) && !string.IsNullOrEmpty(CityInput.Text))
                {
                    using (var conn = DBConnection.ConnectionOpen())
                    {
                        using (var checkAvailablility = DBConnection.Commands("select count(1) from Users where Email = @crossemail or Phone = @crossphone", conn))
                        {
                            checkAvailablility.Parameters.AddWithValue("@crossemail", EmailInput.Text);
                            checkAvailablility.Parameters.AddWithValue("@crossphone", PhoneInput.Text);

                            int dataCount = (int)checkAvailablility.ExecuteScalar();
                            if (dataCount <= 0)
                            {
                                using (var cmd = DBConnection.Commands("insert into Users values(@name,@phone,@email,@city)", conn))
                                {
                                    cmd.Parameters.AddWithValue("@name", NameInput.Text);
                                    cmd.Parameters.AddWithValue("@email", EmailInput.Text);
                                    cmd.Parameters.AddWithValue("@city", CityInput.Text);
                                    cmd.Parameters.AddWithValue("@phone", PhoneInput.Text);
                                    var result = cmd.ExecuteNonQuery();
                                    DBConnection.ConnectionClose();


                                    MessageBox.Show("Successfully Submitted!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Email or Phone already exists!");
                            }
                            this.Controls.Clear();
                            this.InitializeComponent();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the form!");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
                throw;
            }


        }
    }
}

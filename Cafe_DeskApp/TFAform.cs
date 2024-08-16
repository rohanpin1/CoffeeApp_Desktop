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

namespace Cafe_DeskApp
{
    public partial class TFAform : Form
    {
        private readonly string _email;
        private readonly CafeWinForm _cafeForm;
        public TFAform(string email, CafeWinForm cafeWinForm)
        {
            InitializeComponent();
            _email = email;
            _cafeForm = cafeWinForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TFABtn_click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TFACodeInput.Text))
            {
                using (var conn = DBConnection.ConnectionOpen())
                {
                    using (var cmd = new SqlCommand($"select count(1) from AuthenticateUsers where TwoFACode = @code and Username = @email", conn))
                    {
                        cmd.Parameters.AddWithValue("@code", TFACodeInput.Text);
                        cmd.Parameters.AddWithValue("@email", _email);
                        var checkTFA = (int)cmd.ExecuteScalar();

                        if (checkTFA > 0)
                        {
                            Close();
                            _cafeForm.OpenUCHome();
                        }
                        else
                        {
                            MessageBox.Show("Enter correct 2FA Code!");
                        }
                    }
                }
            }
        }
    }
}

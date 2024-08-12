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
	public partial class UCHome : UserControl
	{
		public UCHome()
		{
			InitializeComponent();
		}

		private void HomeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

        private void PnlHome_Load(object sender, PaintEventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", "Data Source=HP\\SQLEXPRESS;Initial Catalog=CoffeeApp;Integrated Security=True");
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");
            HomeDataGridView.DataSource = ds.Tables["Users"].DefaultView;
        }
    }
}

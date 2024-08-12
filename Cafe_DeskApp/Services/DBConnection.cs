using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_DeskApp.Services
{
	public static class DBConnection
	{		
        public static SqlConnection ConnectionOpen()
		{
			SqlConnection conn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=CoffeeApp;Integrated Security=True");
			conn.Open();
			return conn;
		}

		public static void ConnectionClose()
		{
			SqlConnection conn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=CoffeeApp;Integrated Security=True");
			conn.Close();
		}

		public static SqlCommand Commands(string query,SqlConnection conn)
		{
			SqlCommand cmd = new SqlCommand(query, conn);
			return cmd;
		}
	}
}

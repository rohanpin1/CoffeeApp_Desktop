using Cafe_DeskApp.DTO;
using Cafe_DeskApp.Services;
using Newtonsoft.Json;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
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
    public partial class UCUsers : UserControl
    {
        public UCUsers()
        {
            InitializeComponent();
        }

        private void GetUsersBtn_click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                this.Controls.Clear();
                this.InitializeComponent();
                GetUsersEvent();
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
                {
                    Text = "Delete",
                    Name = "DeleteRow",
                    UseColumnTextForButtonValue = true
                };

                UsersDataGrid.Columns.Add(btnDelete);

                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
                {
                    Text = "Edit",
                    Name = "EditRow",
                    UseColumnTextForButtonValue = true
                };

                UsersDataGrid.Columns.Add(btnEdit);
            }

        }

        private void GetUsersEvent()
        {
            HttpResponseMessage res = GeneralParams.HttpCall().GetAsync("GetUsers").Result;

            var users = res.Content.ReadAsStringAsync().Result;
            var resutl = JsonConvert.DeserializeObject<List<Users>>(users);

            UsersDataGrid.DataSource = resutl;

            if (resutl.Any())
            {
                ExportBtn.Visible = true;
            }
        }

        private List<Users> GetUsersList()
        {
            HttpResponseMessage res = GeneralParams.HttpCall().GetAsync("GetUsers").Result;

            var users = res.Content.ReadAsStringAsync().Result;
            var resutl = JsonConvert.DeserializeObject<List<Users>>(users);

            return resutl;
        }


        private void UsersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UsersDataGrid.Columns[e.ColumnIndex].Name == "DeleteRow")
            {
                var id = UsersDataGrid.Rows[e.RowIndex].Cells["Id"].Value;

                if (MessageBox.Show("Are You Sure you want to delete this row?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HttpResponseMessage res = GeneralParams.HttpCall().DeleteAsync($"DeleteUser?id={id}").Result;

                    GetUsersEvent();
                }
            }

            if (UsersDataGrid.Columns[e.ColumnIndex].Name == "EditRow")
            {
                try
                {
                    var id = UsersDataGrid.Rows[e.RowIndex].Cells["Id"].Value;

                    HttpResponseMessage res = GeneralParams.HttpCall().GetAsync($"GetUser?id={id}").Result;

                    var users = res.Content.ReadAsStringAsync().Result;
                    var resutl = JsonConvert.DeserializeObject<Users>(users);

                    ucControlList(new UCActions(), resutl);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void ucControlList(UserControl controls, Users user)
        {
            controls.Dock = DockStyle.Fill;
            PnlUcUser.Controls.Clear();
            PnlUcUser.Controls.Add(controls);
            if (controls is UCActions uc)
            {
                uc.SetUserdata(user);
            }
            controls.BringToFront();
        }

        private void ExportBtn_click(object sender, EventArgs e)
        {
            using (PdfDocument pdf = new PdfDocument())
            {
                PdfPage page = pdf.Pages.Add();
                //Create PDF graphics for a page.
                PdfGrid grid = new PdfGrid();
                DataTable table = new DataTable();
                table.Columns.Add("ID");
                table.Columns.Add("Name");
                table.Columns.Add("Phone");
                table.Columns.Add("Email");
                table.Columns.Add("City");

                var user = GetUsersList();
                var totalrecords = user.Count();

                foreach (var item in user)
                {
                    table.Rows.Add(new object[] { item.Id, item.Name, item.Phone, item.Email, item.City });
                }

                grid.DataSource = table;
                grid.ApplyBuiltinStyle(PdfGridBuiltinStyle.GridTable4Accent1);

                grid.Draw(page, new Point(10, 10));
                //Save the document.
                string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

                pdf.Save(downloadsPath + $"\\UsersRecord.pdf");
                MessageBox.Show("Pdf saved to Downloads!");
            }
        }
    }
}

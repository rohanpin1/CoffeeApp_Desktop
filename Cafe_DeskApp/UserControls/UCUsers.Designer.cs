namespace Cafe_DeskApp.UserControls
{
	partial class UCUsers
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.PnlUcUser = new System.Windows.Forms.Panel();
            this.GetUsersBtn = new System.Windows.Forms.Button();
            this.UsersDataGrid = new System.Windows.Forms.DataGridView();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.PnlUcUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlUcUser
            // 
            this.PnlUcUser.Controls.Add(this.ExportBtn);
            this.PnlUcUser.Controls.Add(this.GetUsersBtn);
            this.PnlUcUser.Controls.Add(this.UsersDataGrid);
            this.PnlUcUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUcUser.Location = new System.Drawing.Point(0, 0);
            this.PnlUcUser.Name = "PnlUcUser";
            this.PnlUcUser.Size = new System.Drawing.Size(1000, 555);
            this.PnlUcUser.TabIndex = 0;
            this.PnlUcUser.Click += new System.EventHandler(this.GetUsersBtn_click);
            // 
            // GetUsersBtn
            // 
            this.GetUsersBtn.BackColor = System.Drawing.Color.Silver;
            this.GetUsersBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.GetUsersBtn.Location = new System.Drawing.Point(19, 21);
            this.GetUsersBtn.Name = "GetUsersBtn";
            this.GetUsersBtn.Size = new System.Drawing.Size(132, 36);
            this.GetUsersBtn.TabIndex = 4;
            this.GetUsersBtn.Text = "Get Users";
            this.GetUsersBtn.UseVisualStyleBackColor = false;
            this.GetUsersBtn.Click += new System.EventHandler(this.GetUsersBtn_click);
            // 
            // UsersDataGrid
            // 
            this.UsersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGrid.Location = new System.Drawing.Point(19, 100);
            this.UsersDataGrid.Name = "UsersDataGrid";
            this.UsersDataGrid.RowHeadersWidth = 60;
            this.UsersDataGrid.Size = new System.Drawing.Size(963, 433);
            this.UsersDataGrid.TabIndex = 3;
            this.UsersDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGrid_CellContentClick);
            // 
            // ExportBtn
            // 
            this.ExportBtn.BackColor = System.Drawing.Color.Silver;
            this.ExportBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.ExportBtn.Location = new System.Drawing.Point(197, 21);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(132, 36);
            this.ExportBtn.TabIndex = 5;
            this.ExportBtn.Text = "Export";
            this.ExportBtn.UseVisualStyleBackColor = false;
            this.ExportBtn.Visible = false;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_click);
            // 
            // UCUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlUcUser);
            this.Name = "UCUsers";
            this.Size = new System.Drawing.Size(1000, 555);
            this.PnlUcUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PnlUcUser;
		private System.Windows.Forms.Button GetUsersBtn;
		private System.Windows.Forms.DataGridView UsersDataGrid;
        private System.Windows.Forms.Button ExportBtn;
    }
}

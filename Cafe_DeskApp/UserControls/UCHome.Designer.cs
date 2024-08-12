namespace Cafe_DeskApp.UserControls
{
	partial class UCHome
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
            this.components = new System.ComponentModel.Container();
            this.PnlUcHome = new System.Windows.Forms.Panel();
            this.HomeDataGridView = new System.Windows.Forms.DataGridView();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.PnlUcHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlUcHome
            // 
            this.PnlUcHome.Controls.Add(this.HomeDataGridView);
            this.PnlUcHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUcHome.Location = new System.Drawing.Point(0, 0);
            this.PnlUcHome.Name = "PnlUcHome";
            this.PnlUcHome.Size = new System.Drawing.Size(1000, 555);
            this.PnlUcHome.TabIndex = 0;
            this.PnlUcHome.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHome_Load);
            // 
            // HomeDataGridView
            // 
            this.HomeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HomeDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.HomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HomeDataGridView.Location = new System.Drawing.Point(68, 41);
            this.HomeDataGridView.Name = "HomeDataGridView";
            this.HomeDataGridView.ReadOnly = true;
            this.HomeDataGridView.Size = new System.Drawing.Size(844, 382);
            this.HomeDataGridView.TabIndex = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // UCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlUcHome);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(1000, 555);
            this.PnlUcHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PnlUcHome;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource usersBindingSource;
		private System.Data.DataSet dataSet1;
		private System.Windows.Forms.DataGridView HomeDataGridView;
	}
}

namespace Cafe_DeskApp
{
	partial class CafeWinForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.PnlControls = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.Logo = new System.Windows.Forms.PictureBox();
			this.BtnExit = new System.Windows.Forms.PictureBox();
			this.PnlTop = new System.Windows.Forms.TableLayoutPanel();
			this.PnlInfo = new System.Windows.Forms.Panel();
			this.BtnInfo = new System.Windows.Forms.Button();
			this.PnlActions = new System.Windows.Forms.Panel();
			this.BtnActions = new System.Windows.Forms.Button();
			this.PnlUsers = new System.Windows.Forms.Panel();
			this.BtnUsers = new System.Windows.Forms.Button();
			this.PnlRegister = new System.Windows.Forms.Panel();
			this.BtnRegister = new System.Windows.Forms.Button();
			this.PnlHome = new System.Windows.Forms.Panel();
			this.BtnHome = new System.Windows.Forms.Button();
			this.PnlMain = new System.Windows.Forms.Panel();
			this.LoginSubmit = new System.Windows.Forms.Button();
			this.PasswordInput = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.UsernameInput = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.PnlControls.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
			this.PnlTop.SuspendLayout();
			this.PnlInfo.SuspendLayout();
			this.PnlActions.SuspendLayout();
			this.PnlUsers.SuspendLayout();
			this.PnlRegister.SuspendLayout();
			this.PnlHome.SuspendLayout();
			this.PnlMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// PnlControls
			// 
			this.PnlControls.BackColor = System.Drawing.Color.Gray;
			this.PnlControls.Controls.Add(this.label1);
			this.PnlControls.Controls.Add(this.Logo);
			this.PnlControls.Controls.Add(this.BtnExit);
			this.PnlControls.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlControls.Location = new System.Drawing.Point(0, 0);
			this.PnlControls.Margin = new System.Windows.Forms.Padding(0);
			this.PnlControls.Name = "PnlControls";
			this.PnlControls.Size = new System.Drawing.Size(1000, 50);
			this.PnlControls.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
			this.label1.Location = new System.Drawing.Point(58, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Barista Beans";
			// 
			// Logo
			// 
			this.Logo.Image = global::Cafe_DeskApp.Properties.Resources.a00432a9d6e19be20e0fa5c7f87a3af5;
			this.Logo.Location = new System.Drawing.Point(3, 3);
			this.Logo.Name = "Logo";
			this.Logo.Size = new System.Drawing.Size(51, 44);
			this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Logo.TabIndex = 1;
			this.Logo.TabStop = false;
			// 
			// BtnExit
			// 
			this.BtnExit.Image = global::Cafe_DeskApp.Properties.Resources.close;
			this.BtnExit.Location = new System.Drawing.Point(951, 3);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(46, 44);
			this.BtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.BtnExit.TabIndex = 0;
			this.BtnExit.TabStop = false;
			this.BtnExit.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// PnlTop
			// 
			this.PnlTop.BackColor = System.Drawing.Color.Silver;
			this.PnlTop.ColumnCount = 5;
			this.PnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.PnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.PnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.PnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.PnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.PnlTop.Controls.Add(this.PnlInfo, 4, 0);
			this.PnlTop.Controls.Add(this.PnlActions, 3, 0);
			this.PnlTop.Controls.Add(this.PnlUsers, 2, 0);
			this.PnlTop.Controls.Add(this.PnlRegister, 1, 0);
			this.PnlTop.Controls.Add(this.PnlHome, 0, 0);
			this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlTop.Location = new System.Drawing.Point(0, 50);
			this.PnlTop.Margin = new System.Windows.Forms.Padding(0);
			this.PnlTop.Name = "PnlTop";
			this.PnlTop.RowCount = 1;
			this.PnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.PnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.PnlTop.Size = new System.Drawing.Size(1000, 100);
			this.PnlTop.TabIndex = 1;
			this.PnlTop.Visible = false;
			// 
			// PnlInfo
			// 
			this.PnlInfo.BackColor = System.Drawing.Color.Silver;
			this.PnlInfo.Controls.Add(this.BtnInfo);
			this.PnlInfo.Location = new System.Drawing.Point(800, 0);
			this.PnlInfo.Margin = new System.Windows.Forms.Padding(0);
			this.PnlInfo.Name = "PnlInfo";
			this.PnlInfo.Size = new System.Drawing.Size(200, 100);
			this.PnlInfo.TabIndex = 4;
			// 
			// BtnInfo
			// 
			this.BtnInfo.BackColor = System.Drawing.Color.Silver;
			this.BtnInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.BtnInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.BtnInfo.FlatAppearance.BorderSize = 0;
			this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnInfo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
			this.BtnInfo.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.BtnInfo.Location = new System.Drawing.Point(0, 0);
			this.BtnInfo.Margin = new System.Windows.Forms.Padding(0);
			this.BtnInfo.Name = "BtnInfo";
			this.BtnInfo.Size = new System.Drawing.Size(200, 95);
			this.BtnInfo.TabIndex = 0;
			this.BtnInfo.Text = "Info";
			this.BtnInfo.UseVisualStyleBackColor = false;
			this.BtnInfo.Click += new System.EventHandler(this.BtnClicks);
			// 
			// PnlActions
			// 
			this.PnlActions.BackColor = System.Drawing.Color.Silver;
			this.PnlActions.Controls.Add(this.BtnActions);
			this.PnlActions.Location = new System.Drawing.Point(600, 0);
			this.PnlActions.Margin = new System.Windows.Forms.Padding(0);
			this.PnlActions.Name = "PnlActions";
			this.PnlActions.Size = new System.Drawing.Size(200, 100);
			this.PnlActions.TabIndex = 3;
			// 
			// BtnActions
			// 
			this.BtnActions.BackColor = System.Drawing.Color.Silver;
			this.BtnActions.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.BtnActions.Dock = System.Windows.Forms.DockStyle.Top;
			this.BtnActions.FlatAppearance.BorderSize = 0;
			this.BtnActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnActions.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
			this.BtnActions.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.BtnActions.Location = new System.Drawing.Point(0, 0);
			this.BtnActions.Margin = new System.Windows.Forms.Padding(0);
			this.BtnActions.Name = "BtnActions";
			this.BtnActions.Size = new System.Drawing.Size(200, 95);
			this.BtnActions.TabIndex = 0;
			this.BtnActions.Text = "Actions";
			this.BtnActions.UseVisualStyleBackColor = false;
			this.BtnActions.Click += new System.EventHandler(this.BtnClicks);
			// 
			// PnlUsers
			// 
			this.PnlUsers.BackColor = System.Drawing.Color.Silver;
			this.PnlUsers.Controls.Add(this.BtnUsers);
			this.PnlUsers.Location = new System.Drawing.Point(400, 0);
			this.PnlUsers.Margin = new System.Windows.Forms.Padding(0);
			this.PnlUsers.Name = "PnlUsers";
			this.PnlUsers.Size = new System.Drawing.Size(200, 100);
			this.PnlUsers.TabIndex = 2;
			// 
			// BtnUsers
			// 
			this.BtnUsers.BackColor = System.Drawing.Color.Silver;
			this.BtnUsers.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.BtnUsers.Dock = System.Windows.Forms.DockStyle.Top;
			this.BtnUsers.FlatAppearance.BorderSize = 0;
			this.BtnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnUsers.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
			this.BtnUsers.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.BtnUsers.Location = new System.Drawing.Point(0, 0);
			this.BtnUsers.Margin = new System.Windows.Forms.Padding(0);
			this.BtnUsers.Name = "BtnUsers";
			this.BtnUsers.Size = new System.Drawing.Size(200, 95);
			this.BtnUsers.TabIndex = 0;
			this.BtnUsers.Text = "Users";
			this.BtnUsers.UseVisualStyleBackColor = false;
			this.BtnUsers.Click += new System.EventHandler(this.BtnClicks);
			// 
			// PnlRegister
			// 
			this.PnlRegister.BackColor = System.Drawing.Color.Silver;
			this.PnlRegister.Controls.Add(this.BtnRegister);
			this.PnlRegister.Location = new System.Drawing.Point(200, 0);
			this.PnlRegister.Margin = new System.Windows.Forms.Padding(0);
			this.PnlRegister.Name = "PnlRegister";
			this.PnlRegister.Size = new System.Drawing.Size(200, 100);
			this.PnlRegister.TabIndex = 1;
			// 
			// BtnRegister
			// 
			this.BtnRegister.BackColor = System.Drawing.Color.Silver;
			this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.BtnRegister.Dock = System.Windows.Forms.DockStyle.Top;
			this.BtnRegister.FlatAppearance.BorderSize = 0;
			this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnRegister.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
			this.BtnRegister.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.BtnRegister.Location = new System.Drawing.Point(0, 0);
			this.BtnRegister.Margin = new System.Windows.Forms.Padding(0);
			this.BtnRegister.Name = "BtnRegister";
			this.BtnRegister.Size = new System.Drawing.Size(200, 95);
			this.BtnRegister.TabIndex = 0;
			this.BtnRegister.Text = "Register";
			this.BtnRegister.UseVisualStyleBackColor = false;
			this.BtnRegister.Click += new System.EventHandler(this.BtnClicks);
			// 
			// PnlHome
			// 
			this.PnlHome.BackColor = System.Drawing.Color.Silver;
			this.PnlHome.Controls.Add(this.BtnHome);
			this.PnlHome.Location = new System.Drawing.Point(0, 0);
			this.PnlHome.Margin = new System.Windows.Forms.Padding(0);
			this.PnlHome.Name = "PnlHome";
			this.PnlHome.Size = new System.Drawing.Size(200, 100);
			this.PnlHome.TabIndex = 0;
			// 
			// BtnHome
			// 
			this.BtnHome.BackColor = System.Drawing.Color.Silver;
			this.BtnHome.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
			this.BtnHome.FlatAppearance.BorderSize = 0;
			this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnHome.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnHome.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.BtnHome.Location = new System.Drawing.Point(0, 0);
			this.BtnHome.Margin = new System.Windows.Forms.Padding(0);
			this.BtnHome.Name = "BtnHome";
			this.BtnHome.Size = new System.Drawing.Size(200, 95);
			this.BtnHome.TabIndex = 0;
			this.BtnHome.Text = "Home";
			this.BtnHome.UseVisualStyleBackColor = false;
			this.BtnHome.Click += new System.EventHandler(this.BtnClicks);
			// 
			// PnlMain
			// 
			this.PnlMain.Controls.Add(this.LoginSubmit);
			this.PnlMain.Controls.Add(this.PasswordInput);
			this.PnlMain.Controls.Add(this.label3);
			this.PnlMain.Controls.Add(this.UsernameInput);
			this.PnlMain.Controls.Add(this.label2);
			this.PnlMain.Controls.Add(this.pictureBox1);
			this.PnlMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlMain.Location = new System.Drawing.Point(0, 150);
			this.PnlMain.Margin = new System.Windows.Forms.Padding(0);
			this.PnlMain.Name = "PnlMain";
			this.PnlMain.Size = new System.Drawing.Size(1000, 555);
			this.PnlMain.TabIndex = 2;
			this.PnlMain.Click += new System.EventHandler(this.BtnClicks);
			// 
			// LoginSubmit
			// 
			this.LoginSubmit.BackColor = System.Drawing.Color.Silver;
			this.LoginSubmit.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F);
			this.LoginSubmit.Location = new System.Drawing.Point(554, 228);
			this.LoginSubmit.Margin = new System.Windows.Forms.Padding(0);
			this.LoginSubmit.Name = "LoginSubmit";
			this.LoginSubmit.Size = new System.Drawing.Size(180, 44);
			this.LoginSubmit.TabIndex = 11;
			this.LoginSubmit.Text = "Login";
			this.LoginSubmit.UseVisualStyleBackColor = false;
			this.LoginSubmit.Click += new System.EventHandler(this.LoginSubmit_Click);
			// 
			// PasswordInput
			// 
			this.PasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PasswordInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PasswordInput.Location = new System.Drawing.Point(674, 162);
			this.PasswordInput.Name = "PasswordInput";
			this.PasswordInput.PasswordChar = '*';
			this.PasswordInput.Size = new System.Drawing.Size(268, 29);
			this.PasswordInput.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
			this.label3.Location = new System.Drawing.Point(551, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 18);
			this.label3.TabIndex = 9;
			this.label3.Text = "Password";
			// 
			// UsernameInput
			// 
			this.UsernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.UsernameInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UsernameInput.Location = new System.Drawing.Point(674, 111);
			this.UsernameInput.Name = "UsernameInput";
			this.UsernameInput.Size = new System.Drawing.Size(268, 29);
			this.UsernameInput.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
			this.label2.Location = new System.Drawing.Point(551, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 18);
			this.label2.TabIndex = 7;
			this.label2.Text = "Username";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Cafe_DeskApp.Properties.Resources.coffeeBanner;
			this.pictureBox1.Location = new System.Drawing.Point(58, 53);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(418, 448);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// CafeWinForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1000, 700);
			this.Controls.Add(this.PnlMain);
			this.Controls.Add(this.PnlTop);
			this.Controls.Add(this.PnlControls);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CafeWinForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.PnlControls.ResumeLayout(false);
			this.PnlControls.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
			this.PnlTop.ResumeLayout(false);
			this.PnlInfo.ResumeLayout(false);
			this.PnlActions.ResumeLayout(false);
			this.PnlUsers.ResumeLayout(false);
			this.PnlRegister.ResumeLayout(false);
			this.PnlHome.ResumeLayout(false);
			this.PnlMain.ResumeLayout(false);
			this.PnlMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PnlControls;
		private System.Windows.Forms.TableLayoutPanel PnlTop;
		private System.Windows.Forms.Panel PnlHome;
		private System.Windows.Forms.Button BtnHome;
		private System.Windows.Forms.Panel PnlInfo;
		private System.Windows.Forms.Button BtnInfo;
		private System.Windows.Forms.Panel PnlActions;
		private System.Windows.Forms.Button BtnActions;
		private System.Windows.Forms.Panel PnlUsers;
		private System.Windows.Forms.Button BtnUsers;
		private System.Windows.Forms.Panel PnlRegister;
		private System.Windows.Forms.Button BtnRegister;
		private System.Windows.Forms.PictureBox BtnExit;
		private System.Windows.Forms.PictureBox Logo;
		private System.Windows.Forms.Panel PnlMain;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button LoginSubmit;
		private System.Windows.Forms.TextBox PasswordInput;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox UsernameInput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}


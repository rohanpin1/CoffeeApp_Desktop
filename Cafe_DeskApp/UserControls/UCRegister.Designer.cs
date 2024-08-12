namespace Cafe_DeskApp.UserControls
{
	partial class UCRegister
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.CityInput = new System.Windows.Forms.TextBox();
			this.PhoneInput = new System.Windows.Forms.TextBox();
			this.EmailInput = new System.Windows.Forms.TextBox();
			this.SaveBtn = new System.Windows.Forms.Button();
			this.NameInput = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
			this.label1.Location = new System.Drawing.Point(80, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
			this.label2.Location = new System.Drawing.Point(80, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Phone";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
			this.label3.Location = new System.Drawing.Point(80, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Email";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
			this.label4.Location = new System.Drawing.Point(80, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "City";
			// 
			// CityInput
			// 
			this.CityInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CityInput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CityInput.ForeColor = System.Drawing.Color.Gray;
			this.CityInput.Location = new System.Drawing.Point(183, 180);
			this.CityInput.Name = "CityInput";
			this.CityInput.Size = new System.Drawing.Size(329, 26);
			this.CityInput.TabIndex = 5;
			// 
			// PhoneInput
			// 
			this.PhoneInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PhoneInput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PhoneInput.ForeColor = System.Drawing.Color.Gray;
			this.PhoneInput.Location = new System.Drawing.Point(183, 140);
			this.PhoneInput.Name = "PhoneInput";
			this.PhoneInput.Size = new System.Drawing.Size(329, 26);
			this.PhoneInput.TabIndex = 6;
			// 
			// EmailInput
			// 
			this.EmailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.EmailInput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EmailInput.ForeColor = System.Drawing.Color.Gray;
			this.EmailInput.Location = new System.Drawing.Point(183, 103);
			this.EmailInput.Name = "EmailInput";
			this.EmailInput.Size = new System.Drawing.Size(329, 26);
			this.EmailInput.TabIndex = 7;
			// 
			// SaveBtn
			// 
			this.SaveBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
			this.SaveBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.SaveBtn.Location = new System.Drawing.Point(83, 233);
			this.SaveBtn.Margin = new System.Windows.Forms.Padding(0);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(429, 32);
			this.SaveBtn.TabIndex = 8;
			this.SaveBtn.Text = "Save";
			this.SaveBtn.UseVisualStyleBackColor = true;
			this.SaveBtn.Click += new System.EventHandler(this.saveClickBtn);
			// 
			// NameInput
			// 
			this.NameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NameInput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameInput.ForeColor = System.Drawing.Color.Gray;
			this.NameInput.Location = new System.Drawing.Point(183, 63);
			this.NameInput.Name = "NameInput";
			this.NameInput.Size = new System.Drawing.Size(329, 26);
			this.NameInput.TabIndex = 9;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Cafe_DeskApp.Properties.Resources.users;
			this.pictureBox1.Location = new System.Drawing.Point(713, 63);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(230, 202);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// UCRegister
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.NameInput);
			this.Controls.Add(this.SaveBtn);
			this.Controls.Add(this.EmailInput);
			this.Controls.Add(this.PhoneInput);
			this.Controls.Add(this.CityInput);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.Desktop;
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "UCRegister";
			this.Size = new System.Drawing.Size(1000, 555);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox CityInput;
		private System.Windows.Forms.TextBox PhoneInput;
		private System.Windows.Forms.TextBox EmailInput;
		private System.Windows.Forms.Button SaveBtn;
		private System.Windows.Forms.TextBox NameInput;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

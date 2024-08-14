namespace Cafe_DeskApp
{
    partial class LoginRegistrationForm
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
            this.LoginPasswordRegisterBtn = new System.Windows.Forms.Button();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmPasswordInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.IsShowPassword = new System.Windows.Forms.CheckBox();
            this.IsShowCnfPassword = new System.Windows.Forms.CheckBox();
            this.EmailFormat = new System.Windows.Forms.Label();
            this.Enable2FA = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LoginPasswordRegisterBtn
            // 
            this.LoginPasswordRegisterBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.LoginPasswordRegisterBtn.Location = new System.Drawing.Point(280, 275);
            this.LoginPasswordRegisterBtn.Name = "LoginPasswordRegisterBtn";
            this.LoginPasswordRegisterBtn.Size = new System.Drawing.Size(268, 34);
            this.LoginPasswordRegisterBtn.TabIndex = 18;
            this.LoginPasswordRegisterBtn.Text = "Register";
            this.LoginPasswordRegisterBtn.UseVisualStyleBackColor = true;
            this.LoginPasswordRegisterBtn.Click += new System.EventHandler(this.LoginPasswordRegisterBtn_Click);
            // 
            // PasswordInput
            // 
            this.PasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInput.Location = new System.Drawing.Point(280, 138);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(268, 29);
            this.PasswordInput.TabIndex = 22;
            this.PasswordInput.TextChanged += new System.EventHandler(this.PasswordInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.label3.Location = new System.Drawing.Point(157, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UsernameInput
            // 
            this.UsernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameInput.Location = new System.Drawing.Point(280, 87);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(268, 29);
            this.UsernameInput.TabIndex = 20;
            this.UsernameInput.TextChanged += new System.EventHandler(this.UsernameInput_TextChanged);
            this.UsernameInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EmailFormatCheck_keyup);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.label2.Location = new System.Drawing.Point(197, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ConfirmPasswordInput
            // 
            this.ConfirmPasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmPasswordInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordInput.Location = new System.Drawing.Point(280, 193);
            this.ConfirmPasswordInput.Name = "ConfirmPasswordInput";
            this.ConfirmPasswordInput.PasswordChar = '*';
            this.ConfirmPasswordInput.Size = new System.Drawing.Size(268, 29);
            this.ConfirmPasswordInput.TabIndex = 24;
            this.ConfirmPasswordInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CnfPassword_keyup);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.label1.Location = new System.Drawing.Point(77, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Confirm Password";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(277, 231);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(58, 13);
            this.PassLabel.TabIndex = 25;
            this.PassLabel.Text = "Mathched!";
            this.PassLabel.Visible = false;
            // 
            // IsShowPassword
            // 
            this.IsShowPassword.AutoSize = true;
            this.IsShowPassword.Location = new System.Drawing.Point(554, 144);
            this.IsShowPassword.Name = "IsShowPassword";
            this.IsShowPassword.Size = new System.Drawing.Size(53, 17);
            this.IsShowPassword.TabIndex = 26;
            this.IsShowPassword.Text = "Show";
            this.IsShowPassword.UseVisualStyleBackColor = true;
            this.IsShowPassword.CheckedChanged += new System.EventHandler(this.IsShowPassword_checked);
            // 
            // IsShowCnfPassword
            // 
            this.IsShowCnfPassword.AutoSize = true;
            this.IsShowCnfPassword.Location = new System.Drawing.Point(554, 199);
            this.IsShowCnfPassword.Name = "IsShowCnfPassword";
            this.IsShowCnfPassword.Size = new System.Drawing.Size(53, 17);
            this.IsShowCnfPassword.TabIndex = 27;
            this.IsShowCnfPassword.Text = "Show";
            this.IsShowCnfPassword.UseVisualStyleBackColor = true;
            this.IsShowCnfPassword.CheckedChanged += new System.EventHandler(this.IsShowCnfPassword_checked);
            this.IsShowCnfPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CnfPassword_keyup);
            // 
            // EmailFormat
            // 
            this.EmailFormat.AutoSize = true;
            this.EmailFormat.Location = new System.Drawing.Point(280, 119);
            this.EmailFormat.Name = "EmailFormat";
            this.EmailFormat.Size = new System.Drawing.Size(107, 13);
            this.EmailFormat.TabIndex = 28;
            this.EmailFormat.Text = "Email Format Correct!";
            this.EmailFormat.Visible = false;
            // 
            // Enable2FA
            // 
            this.Enable2FA.AutoSize = true;
            this.Enable2FA.Location = new System.Drawing.Point(555, 91);
            this.Enable2FA.Name = "Enable2FA";
            this.Enable2FA.Size = new System.Drawing.Size(81, 17);
            this.Enable2FA.TabIndex = 29;
            this.Enable2FA.Text = "Enable 2FA";
            this.Enable2FA.UseVisualStyleBackColor = true;
            // 
            // LoginRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Enable2FA);
            this.Controls.Add(this.EmailFormat);
            this.Controls.Add(this.IsShowCnfPassword);
            this.Controls.Add(this.IsShowPassword);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.ConfirmPasswordInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginPasswordRegisterBtn);
            this.Name = "LoginRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoginPasswordRegisterBtn;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ConfirmPasswordInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.CheckBox IsShowPassword;
        private System.Windows.Forms.CheckBox IsShowCnfPassword;
        private System.Windows.Forms.Label EmailFormat;
        private System.Windows.Forms.CheckBox Enable2FA;
    }
}
namespace Cafe_DeskApp
{
    partial class EditForm
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
            this.PhoneInputBox = new System.Windows.Forms.TextBox();
            this.FetchData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.CityInput = new System.Windows.Forms.TextBox();
            this.EditData = new System.Windows.Forms.Button();
            this.PhoneInput = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PhoneInputBox
            // 
            this.PhoneInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneInputBox.Location = new System.Drawing.Point(38, 37);
            this.PhoneInputBox.Margin = new System.Windows.Forms.Padding(0);
            this.PhoneInputBox.Name = "PhoneInputBox";
            this.PhoneInputBox.Size = new System.Drawing.Size(262, 26);
            this.PhoneInputBox.TabIndex = 0;
            // 
            // FetchData
            // 
            this.FetchData.Location = new System.Drawing.Point(322, 37);
            this.FetchData.Name = "FetchData";
            this.FetchData.Size = new System.Drawing.Size(87, 26);
            this.FetchData.TabIndex = 1;
            this.FetchData.Text = "Fetch";
            this.FetchData.UseVisualStyleBackColor = true;
            this.FetchData.Click += new System.EventHandler(this.FetchData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "City";
            // 
            // NameInput
            // 
            this.NameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameInput.Location = new System.Drawing.Point(118, 112);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(389, 26);
            this.NameInput.TabIndex = 6;
            this.NameInput.Visible = false;
            // 
            // EmailInput
            // 
            this.EmailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailInput.Location = new System.Drawing.Point(118, 157);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(389, 26);
            this.EmailInput.TabIndex = 7;
            this.EmailInput.Visible = false;
            // 
            // CityInput
            // 
            this.CityInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CityInput.Location = new System.Drawing.Point(118, 248);
            this.CityInput.Name = "CityInput";
            this.CityInput.Size = new System.Drawing.Size(389, 26);
            this.CityInput.TabIndex = 9;
            this.CityInput.Visible = false;
            // 
            // EditData
            // 
            this.EditData.Location = new System.Drawing.Point(38, 322);
            this.EditData.Name = "EditData";
            this.EditData.Size = new System.Drawing.Size(87, 26);
            this.EditData.TabIndex = 10;
            this.EditData.Text = "EDIT";
            this.EditData.UseVisualStyleBackColor = true;
            this.EditData.Visible = false;
            this.EditData.Click += new System.EventHandler(this.EditData_click);
            // 
            // PhoneInput
            // 
            this.PhoneInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneInput.Location = new System.Drawing.Point(118, 201);
            this.PhoneInput.Name = "PhoneInput";
            this.PhoneInput.Size = new System.Drawing.Size(389, 26);
            this.PhoneInput.TabIndex = 8;
            this.PhoneInput.Visible = false;
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(118, 79);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(100, 26);
            this.IdBox.TabIndex = 11;
            this.IdBox.Visible = false;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 418);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.EditData);
            this.Controls.Add(this.CityInput);
            this.Controls.Add(this.PhoneInput);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FetchData);
            this.Controls.Add(this.PhoneInputBox);
            this.Font = new System.Drawing.Font("Courier New", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PhoneInputBox;
        private System.Windows.Forms.Button FetchData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.TextBox CityInput;
        private System.Windows.Forms.Button EditData;
        private System.Windows.Forms.TextBox PhoneInput;
        private System.Windows.Forms.TextBox IdBox;
    }
}
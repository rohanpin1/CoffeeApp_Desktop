namespace Cafe_DeskApp
{
    partial class TFAform
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
            this.TFACodeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TFABtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TFACodeInput
            // 
            this.TFACodeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TFACodeInput.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFACodeInput.Location = new System.Drawing.Point(204, 98);
            this.TFACodeInput.Name = "TFACodeInput";
            this.TFACodeInput.Size = new System.Drawing.Size(221, 29);
            this.TFACodeInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label1.Location = new System.Drawing.Point(107, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "2FA Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TFABtn
            // 
            this.TFABtn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.TFABtn.Location = new System.Drawing.Point(470, 94);
            this.TFABtn.Name = "TFABtn";
            this.TFABtn.Size = new System.Drawing.Size(117, 38);
            this.TFABtn.TabIndex = 2;
            this.TFABtn.Text = "Submit";
            this.TFABtn.UseVisualStyleBackColor = true;
            this.TFABtn.Click += new System.EventHandler(this.TFABtn_click);
            // 
            // TFAform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 264);
            this.Controls.Add(this.TFABtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TFACodeInput);
            this.Name = "TFAform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TFAform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TFACodeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TFABtn;
    }
}
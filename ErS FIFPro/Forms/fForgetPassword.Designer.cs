namespace ErS_FIFPro.Forms
{
    partial class fForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fForgetPassword));
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btnForgetPassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.txbEmail.Location = new System.Drawing.Point(90, 53);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(554, 30);
            this.txbEmail.TabIndex = 33;
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbEmail.Location = new System.Drawing.Point(10, 51);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(74, 36);
            this.lbEmail.TabIndex = 32;
            this.lbEmail.Text = "Email:";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnForgetPassword
            // 
            this.btnForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForgetPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPassword.Location = new System.Drawing.Point(254, 97);
            this.btnForgetPassword.Name = "btnForgetPassword";
            this.btnForgetPassword.Size = new System.Drawing.Size(146, 33);
            this.btnForgetPassword.TabIndex = 34;
            this.btnForgetPassword.Text = "Get Password";
            this.btnForgetPassword.UseVisualStyleBackColor = true;
            this.btnForgetPassword.Click += new System.EventHandler(this.btnForgetPassword_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 36);
            this.label1.TabIndex = 35;
            this.label1.Text = "We\'ll send the password to the email you signed up for.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(655, 142);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnForgetPassword);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lbEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forget Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btnForgetPassword;
        private System.Windows.Forms.Label label1;
    }
}
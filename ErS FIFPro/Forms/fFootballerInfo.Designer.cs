namespace ErS_FIFPro.Forms
{
    partial class fFootballerInfo
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
            this.pNav = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.pNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pNav
            // 
            this.pNav.Controls.Add(this.btnExit);
            this.pNav.Controls.Add(this.btnMinimize);
            this.pNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNav.Location = new System.Drawing.Point(0, 0);
            this.pNav.Name = "pNav";
            this.pNav.Size = new System.Drawing.Size(625, 36);
            this.pNav.TabIndex = 0;
            this.pNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pNav_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 40;
            this.btnExit.Location = new System.Drawing.Point(580, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 29);
            this.btnExit.TabIndex = 12;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.Location = new System.Drawing.Point(537, 3);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 27);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // fFootballerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 624);
            this.Controls.Add(this.pNav);
            this.Name = "fFootballerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fFootballerInfo";
            this.TopMost = true;
            this.pNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pNav;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
    }
}
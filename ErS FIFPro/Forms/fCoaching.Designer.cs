namespace ErS_FIFPro.Forms
{
    partial class fCoaching
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
            this.flpCoachingMatch = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // flpCoachingMatch
            // 
            this.flpCoachingMatch.AutoScroll = true;
            this.flpCoachingMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(80)))));
            this.flpCoachingMatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCoachingMatch.Location = new System.Drawing.Point(0, 0);
            this.flpCoachingMatch.Name = "flpCoachingMatch";
            this.flpCoachingMatch.Size = new System.Drawing.Size(1284, 691);
            this.flpCoachingMatch.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 691);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 20);
            this.panel1.TabIndex = 3;
            // 
            // fCoaching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpCoachingMatch);
            this.Name = "fCoaching";
            this.Text = "fCoaching";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCoachingMatch;
        private System.Windows.Forms.Panel panel1;
    }
}
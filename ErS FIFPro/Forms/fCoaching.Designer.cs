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
            this.SuspendLayout();
            // 
            // flpCoachingMatch
            // 
            this.flpCoachingMatch.AutoScroll = true;
            this.flpCoachingMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCoachingMatch.Location = new System.Drawing.Point(0, 0);
            this.flpCoachingMatch.Name = "flpCoachingMatch";
            this.flpCoachingMatch.Size = new System.Drawing.Size(1284, 711);
            this.flpCoachingMatch.TabIndex = 0;
            // 
            // fCoaching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.flpCoachingMatch);
            this.Name = "fCoaching";
            this.Text = "fCoaching";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCoachingMatch;
    }
}
namespace ErS_FIFPro.Forms
{
    partial class fFootballer
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
            this.pSearch = new System.Windows.Forms.Panel();
            this.flpFootballerCards = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pSearch
            // 
            this.pSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSearch.Location = new System.Drawing.Point(0, 0);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(1284, 120);
            this.pSearch.TabIndex = 0;
            // 
            // flpFootballerCards
            // 
            this.flpFootballerCards.AutoScroll = true;
            this.flpFootballerCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFootballerCards.Location = new System.Drawing.Point(0, 120);
            this.flpFootballerCards.Name = "flpFootballerCards";
            this.flpFootballerCards.Size = new System.Drawing.Size(1284, 591);
            this.flpFootballerCards.TabIndex = 1;
            // 
            // fFootballer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.flpFootballerCards);
            this.Controls.Add(this.pSearch);
            this.Name = "fFootballer";
            this.Text = "fFootballer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.FlowLayoutPanel flpFootballerCards;
    }
}
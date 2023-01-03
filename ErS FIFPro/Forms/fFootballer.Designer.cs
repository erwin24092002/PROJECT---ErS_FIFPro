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
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.pSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSearch
            // 
            this.pSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pSearch.Controls.Add(this.txbSearch);
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
            // txbSearch
            // 
            this.txbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbSearch.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.txbSearch.Location = new System.Drawing.Point(360, 12);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(522, 30);
            this.txbSearch.TabIndex = 20;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
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
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.FlowLayoutPanel flpFootballerCards;
        private System.Windows.Forms.TextBox txbSearch;
    }
}
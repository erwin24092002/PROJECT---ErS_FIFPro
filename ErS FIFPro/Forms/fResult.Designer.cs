namespace ErS_FIFPro.Forms
{
    partial class fResult
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
            this.flpResult = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpResult
            // 
            this.flpResult.AutoScroll = true;
            this.flpResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpResult.Location = new System.Drawing.Point(0, 0);
            this.flpResult.Name = "flpResult";
            this.flpResult.Size = new System.Drawing.Size(1284, 711);
            this.flpResult.TabIndex = 0;
            // 
            // fResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.flpResult);
            this.Name = "fResult";
            this.Text = "fResult";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpResult;
    }
}
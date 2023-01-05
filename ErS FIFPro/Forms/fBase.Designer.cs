namespace ErS_FIFPro.Forms
{
    partial class fBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBase));
            this.pFootballer = new System.Windows.Forms.Panel();
            this.gbFootballers = new System.Windows.Forms.GroupBox();
            this.pBase = new System.Windows.Forms.Panel();
            this.flpFootballers = new System.Windows.Forms.FlowLayoutPanel();
            this.pFootballer.SuspendLayout();
            this.gbFootballers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pFootballer
            // 
            this.pFootballer.Controls.Add(this.gbFootballers);
            this.pFootballer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pFootballer.Location = new System.Drawing.Point(0, 0);
            this.pFootballer.Name = "pFootballer";
            this.pFootballer.Size = new System.Drawing.Size(975, 100);
            this.pFootballer.TabIndex = 0;
            // 
            // gbFootballers
            // 
            this.gbFootballers.Controls.Add(this.flpFootballers);
            this.gbFootballers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFootballers.Location = new System.Drawing.Point(12, 3);
            this.gbFootballers.Name = "gbFootballers";
            this.gbFootballers.Size = new System.Drawing.Size(951, 94);
            this.gbFootballers.TabIndex = 0;
            this.gbFootballers.TabStop = false;
            this.gbFootballers.Text = "Footballers";
            // 
            // pBase
            // 
            this.pBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBase.Location = new System.Drawing.Point(0, 100);
            this.pBase.Name = "pBase";
            this.pBase.Size = new System.Drawing.Size(975, 510);
            this.pBase.TabIndex = 1;
            // 
            // flpFootballers
            // 
            this.flpFootballers.AutoScroll = true;
            this.flpFootballers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpFootballers.Location = new System.Drawing.Point(4, 25);
            this.flpFootballers.Name = "flpFootballers";
            this.flpFootballers.Size = new System.Drawing.Size(945, 66);
            this.flpFootballers.TabIndex = 0;
            // 
            // fBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(975, 610);
            this.Controls.Add(this.pBase);
            this.Controls.Add(this.pFootballer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base";
            this.pFootballer.ResumeLayout(false);
            this.gbFootballers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pFootballer;
        private System.Windows.Forms.GroupBox gbFootballers;
        private System.Windows.Forms.Panel pBase;
        private System.Windows.Forms.FlowLayoutPanel flpFootballers;
    }
}
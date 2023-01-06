namespace ErS_FIFPro.User_Controls
{
    partial class FootballerBase
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFootballerName = new System.Windows.Forms.Label();
            this.ptbFootballer = new System.Windows.Forms.PictureBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbIndex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFootballer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFootballerName
            // 
            this.lbFootballerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lbFootballerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFootballerName.Font = new System.Drawing.Font("Century Schoolbook", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFootballerName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbFootballerName.Location = new System.Drawing.Point(0, 68);
            this.lbFootballerName.Name = "lbFootballerName";
            this.lbFootballerName.Size = new System.Drawing.Size(120, 20);
            this.lbFootballerName.TabIndex = 21;
            this.lbFootballerName.Text = "Lionel Messi";
            this.lbFootballerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbFootballer
            // 
            this.ptbFootballer.BackgroundImage = global::ErS_FIFPro.Footballers.Lionel_Messi;
            this.ptbFootballer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbFootballer.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbFootballer.Location = new System.Drawing.Point(0, 0);
            this.ptbFootballer.Name = "ptbFootballer";
            this.ptbFootballer.Size = new System.Drawing.Size(120, 68);
            this.ptbFootballer.TabIndex = 20;
            this.ptbFootballer.TabStop = false;
            // 
            // lbRole
            // 
            this.lbRole.BackColor = System.Drawing.Color.Tomato;
            this.lbRole.Font = new System.Drawing.Font("Century Schoolbook", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.ForeColor = System.Drawing.Color.Black;
            this.lbRole.Location = new System.Drawing.Point(20, 88);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(80, 16);
            this.lbRole.TabIndex = 28;
            this.lbRole.Text = "Forward";
            this.lbRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIndex
            // 
            this.lbIndex.BackColor = System.Drawing.Color.Transparent;
            this.lbIndex.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndex.ForeColor = System.Drawing.Color.Black;
            this.lbIndex.Location = new System.Drawing.Point(44, 104);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(33, 27);
            this.lbIndex.TabIndex = 27;
            this.lbIndex.Text = "10";
            this.lbIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FootballerBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.lbIndex);
            this.Controls.Add(this.lbFootballerName);
            this.Controls.Add(this.ptbFootballer);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FootballerBase";
            this.Size = new System.Drawing.Size(120, 140);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFootballer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbFootballerName;
        private System.Windows.Forms.PictureBox ptbFootballer;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbIndex;
    }
}

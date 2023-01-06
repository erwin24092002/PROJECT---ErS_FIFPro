namespace ErS_FIFPro.User_Controls
{
    partial class TeamMatch
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
            this.btnBase = new System.Windows.Forms.Button();
            this.ptbTeam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBase
            // 
            this.btnBase.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBase.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBase.Location = new System.Drawing.Point(12, 47);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(86, 23);
            this.btnBase.TabIndex = 1;
            this.btnBase.Text = "Base";
            this.btnBase.UseVisualStyleBackColor = false;
            this.btnBase.Click += new System.EventHandler(this.btnBase_Click);
            // 
            // ptbTeam
            // 
            this.ptbTeam.BackgroundImage = global::ErS_FIFPro.Flags.Argentina;
            this.ptbTeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbTeam.Location = new System.Drawing.Point(7, 3);
            this.ptbTeam.Name = "ptbTeam";
            this.ptbTeam.Size = new System.Drawing.Size(96, 44);
            this.ptbTeam.TabIndex = 0;
            this.ptbTeam.TabStop = false;
            // 
            // TeamMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnBase);
            this.Controls.Add(this.ptbTeam);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "TeamMatch";
            this.Size = new System.Drawing.Size(110, 70);
            ((System.ComponentModel.ISupportInitialize)(this.ptbTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox ptbTeam;
        public System.Windows.Forms.Button btnBase;
    }
}

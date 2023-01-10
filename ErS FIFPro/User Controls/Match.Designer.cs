namespace ErS_FIFPro.User_Controls
{
    partial class Match
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
            this.lbDate = new System.Windows.Forms.Label();
            this.lbBet = new FontAwesome.Sharp.IconButton();
            this.lbWatch = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.Orange;
            this.lbDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDate.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Black;
            this.lbDate.Location = new System.Drawing.Point(0, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(120, 34);
            this.lbDate.TabIndex = 22;
            this.lbDate.Text = "2023-1-11\r\n22:00:00";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBet
            // 
            this.lbBet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbBet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBet.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBet.FlatAppearance.BorderSize = 0;
            this.lbBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbBet.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBet.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbBet.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.lbBet.IconColor = System.Drawing.Color.Gold;
            this.lbBet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lbBet.IconSize = 18;
            this.lbBet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbBet.Location = new System.Drawing.Point(0, 57);
            this.lbBet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBet.Name = "lbBet";
            this.lbBet.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.lbBet.Size = new System.Drawing.Size(120, 23);
            this.lbBet.TabIndex = 24;
            this.lbBet.Text = "Bet";
            this.lbBet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbBet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lbBet.UseVisualStyleBackColor = false;
            this.lbBet.Click += new System.EventHandler(this.lbBet_Click);
            // 
            // lbWatch
            // 
            this.lbWatch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbWatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbWatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbWatch.FlatAppearance.BorderSize = 0;
            this.lbWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbWatch.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWatch.ForeColor = System.Drawing.Color.DarkRed;
            this.lbWatch.IconChar = FontAwesome.Sharp.IconChar.Youtube;
            this.lbWatch.IconColor = System.Drawing.Color.Brown;
            this.lbWatch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lbWatch.IconSize = 18;
            this.lbWatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbWatch.Location = new System.Drawing.Point(0, 34);
            this.lbWatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbWatch.Name = "lbWatch";
            this.lbWatch.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.lbWatch.Size = new System.Drawing.Size(120, 23);
            this.lbWatch.TabIndex = 23;
            this.lbWatch.Text = "Watch";
            this.lbWatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbWatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lbWatch.UseVisualStyleBackColor = false;
            this.lbWatch.Click += new System.EventHandler(this.lbWatch_Click);
            // 
            // Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbBet);
            this.Controls.Add(this.lbWatch);
            this.Controls.Add(this.lbDate);
            this.Name = "Match";
            this.Size = new System.Drawing.Size(120, 80);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton lbBet;
        private FontAwesome.Sharp.IconButton lbWatch;
        private System.Windows.Forms.Label lbDate;
    }
}

namespace ErS_FIFPro.User_Controls
{
    partial class Bet
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbAccountCoin = new System.Windows.Forms.PictureBox();
            this.cbbTeam = new System.Windows.Forms.ComboBox();
            this.txbCoin = new System.Windows.Forms.TextBox();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.txbHDP2 = new System.Windows.Forms.TextBox();
            this.txbHDP1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCountry2 = new System.Windows.Forms.Label();
            this.ptbFlag2 = new System.Windows.Forms.PictureBox();
            this.lbCountry1 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.ptbFlag1 = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAccountCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFlag2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFlag1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ErS_FIFPro.Properties.Resources.flag;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(781, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 121;
            this.pictureBox1.TabStop = false;
            // 
            // ptbAccountCoin
            // 
            this.ptbAccountCoin.BackgroundImage = global::ErS_FIFPro.Properties.Resources.coin_removebg_preview;
            this.ptbAccountCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbAccountCoin.Location = new System.Drawing.Point(392, 88);
            this.ptbAccountCoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbAccountCoin.Name = "ptbAccountCoin";
            this.ptbAccountCoin.Size = new System.Drawing.Size(25, 25);
            this.ptbAccountCoin.TabIndex = 120;
            this.ptbAccountCoin.TabStop = false;
            // 
            // cbbTeam
            // 
            this.cbbTeam.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTeam.FormattingEnabled = true;
            this.cbbTeam.Location = new System.Drawing.Point(602, 87);
            this.cbbTeam.Name = "cbbTeam";
            this.cbbTeam.Size = new System.Drawing.Size(172, 28);
            this.cbbTeam.TabIndex = 119;
            // 
            // txbCoin
            // 
            this.txbCoin.BackColor = System.Drawing.Color.White;
            this.txbCoin.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCoin.ForeColor = System.Drawing.Color.Black;
            this.txbCoin.Location = new System.Drawing.Point(423, 87);
            this.txbCoin.Name = "txbCoin";
            this.txbCoin.Size = new System.Drawing.Size(173, 27);
            this.txbCoin.TabIndex = 118;
            this.txbCoin.Text = "0";
            this.txbCoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChange.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChange.Location = new System.Drawing.Point(392, 130);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(204, 33);
            this.btnSaveChange.TabIndex = 117;
            this.btnSaveChange.Text = "Save Changes";
            this.btnSaveChange.UseVisualStyleBackColor = false;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txbHDP2
            // 
            this.txbHDP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbHDP2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHDP2.ForeColor = System.Drawing.Color.Gainsboro;
            this.txbHDP2.Location = new System.Drawing.Point(602, 47);
            this.txbHDP2.Name = "txbHDP2";
            this.txbHDP2.ReadOnly = true;
            this.txbHDP2.Size = new System.Drawing.Size(80, 27);
            this.txbHDP2.TabIndex = 116;
            this.txbHDP2.Text = "0.0";
            this.txbHDP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbHDP1
            // 
            this.txbHDP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbHDP1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHDP1.ForeColor = System.Drawing.Color.Gainsboro;
            this.txbHDP1.Location = new System.Drawing.Point(516, 47);
            this.txbHDP1.Name = "txbHDP1";
            this.txbHDP1.ReadOnly = true;
            this.txbHDP1.Size = new System.Drawing.Size(80, 27);
            this.txbHDP1.TabIndex = 115;
            this.txbHDP1.Text = "0.5";
            this.txbHDP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(699, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 35);
            this.label9.TabIndex = 114;
            this.label9.Text = "HDP";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(419, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 35);
            this.label6.TabIndex = 113;
            this.label6.Text = "HDP";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCountry2
            // 
            this.lbCountry2.BackColor = System.Drawing.Color.Transparent;
            this.lbCountry2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry2.ForeColor = System.Drawing.Color.Black;
            this.lbCountry2.Location = new System.Drawing.Point(906, 33);
            this.lbCountry2.Name = "lbCountry2";
            this.lbCountry2.Size = new System.Drawing.Size(179, 25);
            this.lbCountry2.TabIndex = 112;
            this.lbCountry2.Text = "Argentina";
            this.lbCountry2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbFlag2
            // 
            this.ptbFlag2.BackgroundImage = global::ErS_FIFPro.Flags.Argentina;
            this.ptbFlag2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbFlag2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbFlag2.Location = new System.Drawing.Point(937, 63);
            this.ptbFlag2.Name = "ptbFlag2";
            this.ptbFlag2.Size = new System.Drawing.Size(117, 72);
            this.ptbFlag2.TabIndex = 111;
            this.ptbFlag2.TabStop = false;
            // 
            // lbCountry1
            // 
            this.lbCountry1.BackColor = System.Drawing.Color.Transparent;
            this.lbCountry1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry1.ForeColor = System.Drawing.Color.Black;
            this.lbCountry1.Location = new System.Drawing.Point(113, 33);
            this.lbCountry1.Name = "lbCountry1";
            this.lbCountry1.Size = new System.Drawing.Size(179, 25);
            this.lbCountry1.TabIndex = 110;
            this.lbCountry1.Text = "Argentina";
            this.lbCountry1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.Goldenrod;
            this.lbDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDate.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Black;
            this.lbDate.Location = new System.Drawing.Point(0, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(1196, 30);
            this.lbDate.TabIndex = 109;
            this.lbDate.Text = "2023-1-11 22:00:00";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbFlag1
            // 
            this.ptbFlag1.BackgroundImage = global::ErS_FIFPro.Flags.Argentina;
            this.ptbFlag1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbFlag1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbFlag1.Location = new System.Drawing.Point(147, 63);
            this.ptbFlag1.Name = "ptbFlag1";
            this.ptbFlag1.Size = new System.Drawing.Size(108, 72);
            this.ptbFlag1.TabIndex = 108;
            this.ptbFlag1.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(602, 130);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(204, 33);
            this.btnRemove.TabIndex = 122;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Bet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ptbAccountCoin);
            this.Controls.Add(this.cbbTeam);
            this.Controls.Add(this.txbCoin);
            this.Controls.Add(this.btnSaveChange);
            this.Controls.Add(this.txbHDP2);
            this.Controls.Add(this.txbHDP1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbCountry2);
            this.Controls.Add(this.ptbFlag2);
            this.Controls.Add(this.lbCountry1);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.ptbFlag1);
            this.Margin = new System.Windows.Forms.Padding(40, 20, 3, 10);
            this.Name = "Bet";
            this.Size = new System.Drawing.Size(1196, 173);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAccountCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFlag2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFlag1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptbAccountCoin;
        private System.Windows.Forms.ComboBox cbbTeam;
        private System.Windows.Forms.TextBox txbCoin;
        public System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.TextBox txbHDP2;
        private System.Windows.Forms.TextBox txbHDP1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCountry2;
        private System.Windows.Forms.PictureBox ptbFlag2;
        private System.Windows.Forms.Label lbCountry1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.PictureBox ptbFlag1;
        public System.Windows.Forms.Button btnRemove;
    }
}

namespace ErS_FIFPro.User_Controls
{
    partial class Team
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
            this.lbWin = new System.Windows.Forms.Label();
            this.ptbFlag = new System.Windows.Forms.PictureBox();
            this.lbTeam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLose = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDraw = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWin
            // 
            this.lbWin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbWin.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWin.ForeColor = System.Drawing.Color.Green;
            this.lbWin.Location = new System.Drawing.Point(392, 75);
            this.lbWin.Name = "lbWin";
            this.lbWin.Size = new System.Drawing.Size(140, 35);
            this.lbWin.TabIndex = 86;
            this.lbWin.Text = "0";
            this.lbWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbFlag
            // 
            this.ptbFlag.BackgroundImage = global::ErS_FIFPro.Flags.Argentina;
            this.ptbFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbFlag.Location = new System.Drawing.Point(27, 32);
            this.ptbFlag.Name = "ptbFlag";
            this.ptbFlag.Size = new System.Drawing.Size(177, 100);
            this.ptbFlag.TabIndex = 84;
            this.ptbFlag.TabStop = false;
            // 
            // lbTeam
            // 
            this.lbTeam.BackColor = System.Drawing.Color.DarkCyan;
            this.lbTeam.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTeam.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeam.ForeColor = System.Drawing.Color.Black;
            this.lbTeam.Location = new System.Drawing.Point(0, 0);
            this.lbTeam.Name = "lbTeam";
            this.lbTeam.Size = new System.Drawing.Size(1196, 30);
            this.lbTeam.TabIndex = 110;
            this.lbTeam.Text = "Argentina";
            this.lbTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(392, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 35);
            this.label1.TabIndex = 111;
            this.label1.Text = "Win";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(577, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 35);
            this.label2.TabIndex = 113;
            this.label2.Text = "Lose";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLose
            // 
            this.lbLose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLose.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLose.ForeColor = System.Drawing.Color.DarkRed;
            this.lbLose.Location = new System.Drawing.Point(577, 75);
            this.lbLose.Name = "lbLose";
            this.lbLose.Size = new System.Drawing.Size(140, 35);
            this.lbLose.TabIndex = 112;
            this.lbLose.Text = "0";
            this.lbLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(764, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 35);
            this.label4.TabIndex = 114;
            this.label4.Text = "Draw";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDraw
            // 
            this.lbDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDraw.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDraw.ForeColor = System.Drawing.Color.Black;
            this.lbDraw.Location = new System.Drawing.Point(764, 75);
            this.lbDraw.Name = "lbDraw";
            this.lbDraw.Size = new System.Drawing.Size(140, 35);
            this.lbDraw.TabIndex = 115;
            this.lbDraw.Text = "0";
            this.lbDraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(953, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 35);
            this.label7.TabIndex = 116;
            this.label7.Text = "Score";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbScore
            // 
            this.lbScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbScore.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbScore.Location = new System.Drawing.Point(953, 75);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(140, 35);
            this.lbScore.TabIndex = 117;
            this.lbScore.Text = "0";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbDraw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTeam);
            this.Controls.Add(this.lbWin);
            this.Controls.Add(this.ptbFlag);
            this.Margin = new System.Windows.Forms.Padding(40, 20, 3, 10);
            this.Name = "Team";
            this.Size = new System.Drawing.Size(1196, 135);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbWin;
        private System.Windows.Forms.PictureBox ptbFlag;
        private System.Windows.Forms.Label lbTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDraw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbScore;
    }
}

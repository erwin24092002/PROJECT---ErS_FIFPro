namespace ErS_FIFPro.Forms
{
    partial class fFootballerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFootballerInfo));
            this.pNav = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFootballerDetail = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbFootballerIndex = new System.Windows.Forms.Label();
            this.lbFootballerRole = new System.Windows.Forms.Label();
            this.lbFootballerCountry = new System.Windows.Forms.Label();
            this.lbFootballerBirthday = new System.Windows.Forms.Label();
            this.lbFootballerName = new System.Windows.Forms.Label();
            this.ptbFootballerInfo = new System.Windows.Forms.PictureBox();
            this.pNav.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFootballerInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pNav
            // 
            this.pNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pNav.Controls.Add(this.btnExit);
            this.pNav.Controls.Add(this.btnMinimize);
            this.pNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNav.Location = new System.Drawing.Point(0, 0);
            this.pNav.Name = "pNav";
            this.pNav.Size = new System.Drawing.Size(857, 36);
            this.pNav.TabIndex = 0;
            this.pNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pNav_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 40;
            this.btnExit.Location = new System.Drawing.Point(816, 5);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 29);
            this.btnExit.TabIndex = 12;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.Location = new System.Drawing.Point(776, 4);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 27);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbFootballerDetail);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.lbFootballerIndex);
            this.panel1.Controls.Add(this.lbFootballerRole);
            this.panel1.Controls.Add(this.lbFootballerCountry);
            this.panel1.Controls.Add(this.lbFootballerBirthday);
            this.panel1.Controls.Add(this.lbFootballerName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 588);
            this.panel1.TabIndex = 2;
            // 
            // lbFootballerDetail
            // 
            this.lbFootballerDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFootballerDetail.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFootballerDetail.ForeColor = System.Drawing.Color.Black;
            this.lbFootballerDetail.Location = new System.Drawing.Point(0, 206);
            this.lbFootballerDetail.Name = "lbFootballerDetail";
            this.lbFootballerDetail.Size = new System.Drawing.Size(393, 36);
            this.lbFootballerDetail.TabIndex = 26;
            this.lbFootballerDetail.Text = "Detail:";
            this.lbFootballerDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 247);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(393, 341);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // lbFootballerIndex
            // 
            this.lbFootballerIndex.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFootballerIndex.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFootballerIndex.ForeColor = System.Drawing.Color.Black;
            this.lbFootballerIndex.Location = new System.Drawing.Point(0, 170);
            this.lbFootballerIndex.Name = "lbFootballerIndex";
            this.lbFootballerIndex.Size = new System.Drawing.Size(393, 36);
            this.lbFootballerIndex.TabIndex = 24;
            this.lbFootballerIndex.Text = "Index:";
            this.lbFootballerIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFootballerRole
            // 
            this.lbFootballerRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFootballerRole.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFootballerRole.ForeColor = System.Drawing.Color.Black;
            this.lbFootballerRole.Location = new System.Drawing.Point(0, 134);
            this.lbFootballerRole.Name = "lbFootballerRole";
            this.lbFootballerRole.Size = new System.Drawing.Size(393, 36);
            this.lbFootballerRole.TabIndex = 23;
            this.lbFootballerRole.Text = "Role:";
            this.lbFootballerRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFootballerCountry
            // 
            this.lbFootballerCountry.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFootballerCountry.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFootballerCountry.ForeColor = System.Drawing.Color.Black;
            this.lbFootballerCountry.Location = new System.Drawing.Point(0, 98);
            this.lbFootballerCountry.Name = "lbFootballerCountry";
            this.lbFootballerCountry.Size = new System.Drawing.Size(393, 36);
            this.lbFootballerCountry.TabIndex = 22;
            this.lbFootballerCountry.Text = "Country:";
            this.lbFootballerCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFootballerBirthday
            // 
            this.lbFootballerBirthday.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFootballerBirthday.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFootballerBirthday.ForeColor = System.Drawing.Color.Black;
            this.lbFootballerBirthday.Location = new System.Drawing.Point(0, 62);
            this.lbFootballerBirthday.Name = "lbFootballerBirthday";
            this.lbFootballerBirthday.Size = new System.Drawing.Size(393, 36);
            this.lbFootballerBirthday.TabIndex = 21;
            this.lbFootballerBirthday.Text = "Birthday:";
            this.lbFootballerBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFootballerName
            // 
            this.lbFootballerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lbFootballerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFootballerName.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFootballerName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbFootballerName.Location = new System.Drawing.Point(0, 0);
            this.lbFootballerName.Name = "lbFootballerName";
            this.lbFootballerName.Size = new System.Drawing.Size(393, 62);
            this.lbFootballerName.TabIndex = 20;
            this.lbFootballerName.Text = "Lionel Messi";
            this.lbFootballerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbFootballerInfo
            // 
            this.ptbFootballerInfo.BackgroundImage = global::ErS_FIFPro.FootballerInfos.Lionel_Messi2;
            this.ptbFootballerInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbFootballerInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbFootballerInfo.Location = new System.Drawing.Point(393, 36);
            this.ptbFootballerInfo.Name = "ptbFootballerInfo";
            this.ptbFootballerInfo.Size = new System.Drawing.Size(464, 588);
            this.ptbFootballerInfo.TabIndex = 1;
            this.ptbFootballerInfo.TabStop = false;
            // 
            // fFootballerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptbFootballerInfo);
            this.Controls.Add(this.pNav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fFootballerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Footballer Detail";
            this.TopMost = true;
            this.pNav.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFootballerInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pNav;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.PictureBox ptbFootballerInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbFootballerName;
        private System.Windows.Forms.Label lbFootballerBirthday;
        private System.Windows.Forms.Label lbFootballerRole;
        private System.Windows.Forms.Label lbFootballerCountry;
        private System.Windows.Forms.Label lbFootballerIndex;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbFootballerDetail;
    }
}
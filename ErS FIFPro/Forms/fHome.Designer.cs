namespace ErS_FIFPro.Forms
{
    partial class fHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHome));
            this.pNav = new System.Windows.Forms.Panel();
            this.pHome = new System.Windows.Forms.Panel();
            this.pAccount = new System.Windows.Forms.Panel();
            this.lbAccountCoin = new System.Windows.Forms.Label();
            this.lbAccountRole = new System.Windows.Forms.Label();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.pChildForm = new System.Windows.Forms.Panel();
            this.tSlider = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbSlider = new System.Windows.Forms.PictureBox();
            this.ptbAccountCoin = new System.Windows.Forms.PictureBox();
            this.ptbAccount = new System.Windows.Forms.PictureBox();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnLetter = new FontAwesome.Sharp.IconButton();
            this.btnConfig = new FontAwesome.Sharp.IconButton();
            this.btnCoaching = new FontAwesome.Sharp.IconButton();
            this.btnFootballer = new FontAwesome.Sharp.IconButton();
            this.btnTeam = new FontAwesome.Sharp.IconButton();
            this.btnBetting = new FontAwesome.Sharp.IconButton();
            this.btnResult = new FontAwesome.Sharp.IconButton();
            this.btnMatch = new FontAwesome.Sharp.IconButton();
            this.icptbHome = new FontAwesome.Sharp.IconPictureBox();
            this.pNav.SuspendLayout();
            this.pHome.SuspendLayout();
            this.pAccount.SuspendLayout();
            this.pChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAccountCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icptbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // pNav
            // 
            this.pNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pNav.Controls.Add(this.btnExit);
            this.pNav.Controls.Add(this.btnMinimize);
            this.pNav.Controls.Add(this.btnLetter);
            this.pNav.Controls.Add(this.btnConfig);
            this.pNav.Controls.Add(this.btnCoaching);
            this.pNav.Controls.Add(this.btnFootballer);
            this.pNav.Controls.Add(this.btnTeam);
            this.pNav.Controls.Add(this.btnBetting);
            this.pNav.Controls.Add(this.btnResult);
            this.pNav.Controls.Add(this.btnMatch);
            this.pNav.Controls.Add(this.pHome);
            this.pNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNav.Location = new System.Drawing.Point(0, 0);
            this.pNav.Name = "pNav";
            this.pNav.Size = new System.Drawing.Size(1484, 50);
            this.pNav.TabIndex = 1;
            this.pNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pNav_MouseDown);
            // 
            // pHome
            // 
            this.pHome.Controls.Add(this.icptbHome);
            this.pHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.pHome.Location = new System.Drawing.Point(0, 0);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(200, 50);
            this.pHome.TabIndex = 0;
            // 
            // pAccount
            // 
            this.pAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pAccount.Controls.Add(this.ptbAccountCoin);
            this.pAccount.Controls.Add(this.lbAccountCoin);
            this.pAccount.Controls.Add(this.lbAccountRole);
            this.pAccount.Controls.Add(this.lbAccountName);
            this.pAccount.Controls.Add(this.ptbAccount);
            this.pAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.pAccount.Location = new System.Drawing.Point(0, 50);
            this.pAccount.Name = "pAccount";
            this.pAccount.Size = new System.Drawing.Size(200, 711);
            this.pAccount.TabIndex = 2;
            // 
            // lbAccountCoin
            // 
            this.lbAccountCoin.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountCoin.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbAccountCoin.Location = new System.Drawing.Point(34, 232);
            this.lbAccountCoin.Name = "lbAccountCoin";
            this.lbAccountCoin.Size = new System.Drawing.Size(163, 25);
            this.lbAccountCoin.TabIndex = 8;
            this.lbAccountCoin.Text = "9999$";
            this.lbAccountCoin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAccountRole
            // 
            this.lbAccountRole.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountRole.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbAccountRole.Location = new System.Drawing.Point(3, 202);
            this.lbAccountRole.Name = "lbAccountRole";
            this.lbAccountRole.Size = new System.Drawing.Size(194, 21);
            this.lbAccountRole.TabIndex = 7;
            this.lbAccountRole.Text = "Admin";
            this.lbAccountRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAccountName
            // 
            this.lbAccountName.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbAccountName.Location = new System.Drawing.Point(3, 168);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(194, 34);
            this.lbAccountName.TabIndex = 6;
            this.lbAccountName.Text = "Erwin";
            this.lbAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pChildForm
            // 
            this.pChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pChildForm.Controls.Add(this.pictureBox4);
            this.pChildForm.Controls.Add(this.pictureBox3);
            this.pChildForm.Controls.Add(this.pictureBox2);
            this.pChildForm.Controls.Add(this.pictureBox1);
            this.pChildForm.Controls.Add(this.ptbSlider);
            this.pChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pChildForm.Location = new System.Drawing.Point(200, 50);
            this.pChildForm.Name = "pChildForm";
            this.pChildForm.Size = new System.Drawing.Size(1284, 711);
            this.pChildForm.TabIndex = 3;
            // 
            // tSlider
            // 
            this.tSlider.Enabled = true;
            this.tSlider.Interval = 1200;
            this.tSlider.Tick += new System.EventHandler(this.tSlider_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(954, 527);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(302, 172);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(646, 527);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(302, 172);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(338, 527);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(302, 172);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(23, 527);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 172);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ptbSlider
            // 
            this.ptbSlider.BackgroundImage = global::ErS_FIFPro.Sliders._4;
            this.ptbSlider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbSlider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbSlider.InitialImage = global::ErS_FIFPro.Properties.Resources._1;
            this.ptbSlider.Location = new System.Drawing.Point(23, 17);
            this.ptbSlider.Name = "ptbSlider";
            this.ptbSlider.Size = new System.Drawing.Size(1233, 504);
            this.ptbSlider.TabIndex = 0;
            this.ptbSlider.TabStop = false;
            // 
            // ptbAccountCoin
            // 
            this.ptbAccountCoin.BackgroundImage = global::ErS_FIFPro.Properties.Resources.coin_removebg_preview;
            this.ptbAccountCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbAccountCoin.Location = new System.Drawing.Point(3, 232);
            this.ptbAccountCoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbAccountCoin.Name = "ptbAccountCoin";
            this.ptbAccountCoin.Size = new System.Drawing.Size(25, 25);
            this.ptbAccountCoin.TabIndex = 9;
            this.ptbAccountCoin.TabStop = false;
            // 
            // ptbAccount
            // 
            this.ptbAccount.BackgroundImage = global::ErS_FIFPro.Accounts.Viewer;
            this.ptbAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbAccount.InitialImage = global::ErS_FIFPro.Accounts.Viewer;
            this.ptbAccount.Location = new System.Drawing.Point(6, 20);
            this.ptbAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbAccount.Name = "ptbAccount";
            this.ptbAccount.Size = new System.Drawing.Size(187, 146);
            this.ptbAccount.TabIndex = 5;
            this.ptbAccount.TabStop = false;
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
            this.btnExit.Location = new System.Drawing.Point(1439, 12);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 29);
            this.btnExit.TabIndex = 10;
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
            this.btnMinimize.Location = new System.Drawing.Point(1396, 11);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 27);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnLetter
            // 
            this.btnLetter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLetter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLetter.FlatAppearance.BorderSize = 0;
            this.btnLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLetter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLetter.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLetter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLetter.IconSize = 32;
            this.btnLetter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLetter.Location = new System.Drawing.Point(1180, 0);
            this.btnLetter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLetter.Name = "btnLetter";
            this.btnLetter.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnLetter.Size = new System.Drawing.Size(140, 50);
            this.btnLetter.TabIndex = 9;
            this.btnLetter.Text = "Letter";
            this.btnLetter.UseVisualStyleBackColor = true;
            this.btnLetter.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConfig.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConfig.IconColor = System.Drawing.Color.Gainsboro;
            this.btnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfig.IconSize = 32;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(1040, 0);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnConfig.Size = new System.Drawing.Size(140, 50);
            this.btnConfig.TabIndex = 8;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnCoaching
            // 
            this.btnCoaching.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoaching.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCoaching.FlatAppearance.BorderSize = 0;
            this.btnCoaching.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoaching.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoaching.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCoaching.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCoaching.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCoaching.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCoaching.IconSize = 32;
            this.btnCoaching.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoaching.Location = new System.Drawing.Point(900, 0);
            this.btnCoaching.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCoaching.Name = "btnCoaching";
            this.btnCoaching.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnCoaching.Size = new System.Drawing.Size(140, 50);
            this.btnCoaching.TabIndex = 7;
            this.btnCoaching.Text = "Coaching";
            this.btnCoaching.UseVisualStyleBackColor = true;
            this.btnCoaching.Click += new System.EventHandler(this.btnCoaching_Click);
            // 
            // btnFootballer
            // 
            this.btnFootballer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFootballer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFootballer.FlatAppearance.BorderSize = 0;
            this.btnFootballer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFootballer.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFootballer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFootballer.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFootballer.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFootballer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFootballer.IconSize = 32;
            this.btnFootballer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFootballer.Location = new System.Drawing.Point(760, 0);
            this.btnFootballer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFootballer.Name = "btnFootballer";
            this.btnFootballer.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnFootballer.Size = new System.Drawing.Size(140, 50);
            this.btnFootballer.TabIndex = 6;
            this.btnFootballer.Text = "Footballer";
            this.btnFootballer.UseVisualStyleBackColor = true;
            this.btnFootballer.Click += new System.EventHandler(this.btnFootballer_Click);
            // 
            // btnTeam
            // 
            this.btnTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeam.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTeam.FlatAppearance.BorderSize = 0;
            this.btnTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeam.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeam.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTeam.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTeam.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTeam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTeam.IconSize = 32;
            this.btnTeam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeam.Location = new System.Drawing.Point(620, 0);
            this.btnTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTeam.Name = "btnTeam";
            this.btnTeam.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnTeam.Size = new System.Drawing.Size(140, 50);
            this.btnTeam.TabIndex = 5;
            this.btnTeam.Text = "Teams";
            this.btnTeam.UseVisualStyleBackColor = true;
            this.btnTeam.Click += new System.EventHandler(this.btnTeam_Click);
            // 
            // btnBetting
            // 
            this.btnBetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBetting.FlatAppearance.BorderSize = 0;
            this.btnBetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBetting.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBetting.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBetting.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBetting.IconSize = 32;
            this.btnBetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBetting.Location = new System.Drawing.Point(480, 0);
            this.btnBetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBetting.Name = "btnBetting";
            this.btnBetting.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnBetting.Size = new System.Drawing.Size(140, 50);
            this.btnBetting.TabIndex = 4;
            this.btnBetting.Text = "Betting";
            this.btnBetting.UseVisualStyleBackColor = true;
            this.btnBetting.Click += new System.EventHandler(this.btnBetting_Click);
            // 
            // btnResult
            // 
            this.btnResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnResult.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnResult.IconColor = System.Drawing.Color.Gainsboro;
            this.btnResult.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResult.IconSize = 32;
            this.btnResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResult.Location = new System.Drawing.Point(340, 0);
            this.btnResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResult.Name = "btnResult";
            this.btnResult.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnResult.Size = new System.Drawing.Size(140, 50);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "Results";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnMatch
            // 
            this.btnMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMatch.FlatAppearance.BorderSize = 0;
            this.btnMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatch.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMatch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMatch.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMatch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMatch.IconSize = 32;
            this.btnMatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatch.Location = new System.Drawing.Point(200, 0);
            this.btnMatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnMatch.Size = new System.Drawing.Size(140, 50);
            this.btnMatch.TabIndex = 2;
            this.btnMatch.Text = "Matchs";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // icptbHome
            // 
            this.icptbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.icptbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icptbHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.icptbHome.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icptbHome.IconColor = System.Drawing.SystemColors.ControlText;
            this.icptbHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icptbHome.IconSize = 44;
            this.icptbHome.Location = new System.Drawing.Point(3, 3);
            this.icptbHome.Name = "icptbHome";
            this.icptbHome.Size = new System.Drawing.Size(194, 44);
            this.icptbHome.TabIndex = 0;
            this.icptbHome.TabStop = false;
            this.icptbHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.pChildForm);
            this.Controls.Add(this.pAccount);
            this.Controls.Add(this.pNav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fHome";
            this.pNav.ResumeLayout(false);
            this.pHome.ResumeLayout(false);
            this.pAccount.ResumeLayout(false);
            this.pChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAccountCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icptbHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pNav;
        private System.Windows.Forms.Panel pAccount;
        private System.Windows.Forms.Panel pChildForm;
        private System.Windows.Forms.Panel pHome;
        private FontAwesome.Sharp.IconPictureBox icptbHome;
        private System.Windows.Forms.PictureBox ptbAccount;
        private System.Windows.Forms.Label lbAccountCoin;
        private System.Windows.Forms.Label lbAccountRole;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.PictureBox ptbAccountCoin;
        private FontAwesome.Sharp.IconButton btnMatch;
        private FontAwesome.Sharp.IconButton btnConfig;
        private FontAwesome.Sharp.IconButton btnCoaching;
        private FontAwesome.Sharp.IconButton btnFootballer;
        private FontAwesome.Sharp.IconButton btnTeam;
        private FontAwesome.Sharp.IconButton btnBetting;
        private FontAwesome.Sharp.IconButton btnResult;
        private FontAwesome.Sharp.IconButton btnLetter;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.PictureBox ptbSlider;
        private System.Windows.Forms.Timer tSlider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
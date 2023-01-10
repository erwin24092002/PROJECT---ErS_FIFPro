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
            this.gbRole = new System.Windows.Forms.GroupBox();
            this.cbTrainer = new System.Windows.Forms.CheckBox();
            this.cbGoalkeeper = new System.Windows.Forms.CheckBox();
            this.cbDefender = new System.Windows.Forms.CheckBox();
            this.cbMidfielder = new System.Windows.Forms.CheckBox();
            this.cbForward = new System.Windows.Forms.CheckBox();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.cbbOrder = new System.Windows.Forms.ComboBox();
            this.gbCountry = new System.Windows.Forms.GroupBox();
            this.cbbCountry = new System.Windows.Forms.ComboBox();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.flpFootballerCards = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pSearch.SuspendLayout();
            this.gbRole.SuspendLayout();
            this.gbOrder.SuspendLayout();
            this.gbCountry.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSearch
            // 
            this.pSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pSearch.Controls.Add(this.gbRole);
            this.pSearch.Controls.Add(this.gbOrder);
            this.pSearch.Controls.Add(this.gbCountry);
            this.pSearch.Controls.Add(this.txbSearch);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSearch.Location = new System.Drawing.Point(0, 0);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(1284, 127);
            this.pSearch.TabIndex = 0;
            // 
            // gbRole
            // 
            this.gbRole.Controls.Add(this.cbTrainer);
            this.gbRole.Controls.Add(this.cbGoalkeeper);
            this.gbRole.Controls.Add(this.cbDefender);
            this.gbRole.Controls.Add(this.cbMidfielder);
            this.gbRole.Controls.Add(this.cbForward);
            this.gbRole.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRole.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbRole.Location = new System.Drawing.Point(68, 53);
            this.gbRole.Name = "gbRole";
            this.gbRole.Size = new System.Drawing.Size(638, 62);
            this.gbRole.TabIndex = 24;
            this.gbRole.TabStop = false;
            this.gbRole.Text = "Role";
            // 
            // cbTrainer
            // 
            this.cbTrainer.AutoSize = true;
            this.cbTrainer.Checked = true;
            this.cbTrainer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTrainer.Location = new System.Drawing.Point(543, 31);
            this.cbTrainer.Name = "cbTrainer";
            this.cbTrainer.Size = new System.Drawing.Size(89, 25);
            this.cbTrainer.TabIndex = 4;
            this.cbTrainer.Text = "Trainer";
            this.cbTrainer.UseVisualStyleBackColor = true;
            this.cbTrainer.CheckedChanged += new System.EventHandler(this.cbCheck_Changed);
            // 
            // cbGoalkeeper
            // 
            this.cbGoalkeeper.AutoSize = true;
            this.cbGoalkeeper.Checked = true;
            this.cbGoalkeeper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGoalkeeper.Location = new System.Drawing.Point(401, 31);
            this.cbGoalkeeper.Name = "cbGoalkeeper";
            this.cbGoalkeeper.Size = new System.Drawing.Size(120, 25);
            this.cbGoalkeeper.TabIndex = 3;
            this.cbGoalkeeper.Text = "Goalkeeper";
            this.cbGoalkeeper.UseVisualStyleBackColor = true;
            this.cbGoalkeeper.CheckedChanged += new System.EventHandler(this.cbCheck_Changed);
            // 
            // cbDefender
            // 
            this.cbDefender.AutoSize = true;
            this.cbDefender.Checked = true;
            this.cbDefender.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefender.Location = new System.Drawing.Point(272, 31);
            this.cbDefender.Name = "cbDefender";
            this.cbDefender.Size = new System.Drawing.Size(103, 25);
            this.cbDefender.TabIndex = 2;
            this.cbDefender.Text = "Defender";
            this.cbDefender.UseVisualStyleBackColor = true;
            this.cbDefender.CheckedChanged += new System.EventHandler(this.cbCheck_Changed);
            // 
            // cbMidfielder
            // 
            this.cbMidfielder.AutoSize = true;
            this.cbMidfielder.Checked = true;
            this.cbMidfielder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMidfielder.Location = new System.Drawing.Point(132, 31);
            this.cbMidfielder.Name = "cbMidfielder";
            this.cbMidfielder.Size = new System.Drawing.Size(112, 25);
            this.cbMidfielder.TabIndex = 1;
            this.cbMidfielder.Text = "Midfielder";
            this.cbMidfielder.UseVisualStyleBackColor = true;
            this.cbMidfielder.CheckedChanged += new System.EventHandler(this.cbCheck_Changed);
            // 
            // cbForward
            // 
            this.cbForward.AutoSize = true;
            this.cbForward.Checked = true;
            this.cbForward.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbForward.Location = new System.Drawing.Point(12, 31);
            this.cbForward.Name = "cbForward";
            this.cbForward.Size = new System.Drawing.Size(96, 25);
            this.cbForward.TabIndex = 0;
            this.cbForward.Text = "Forward";
            this.cbForward.UseVisualStyleBackColor = true;
            this.cbForward.CheckedChanged += new System.EventHandler(this.cbCheck_Changed);
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.cbbOrder);
            this.gbOrder.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbOrder.Location = new System.Drawing.Point(988, 53);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(216, 62);
            this.gbOrder.TabIndex = 23;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Order";
            // 
            // cbbOrder
            // 
            this.cbbOrder.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbOrder.FormattingEnabled = true;
            this.cbbOrder.Items.AddRange(new object[] {
            "A-Z",
            "Z-A",
            "Goal Decrease",
            "Goal Increase"});
            this.cbbOrder.Location = new System.Drawing.Point(11, 27);
            this.cbbOrder.Name = "cbbOrder";
            this.cbbOrder.Size = new System.Drawing.Size(195, 29);
            this.cbbOrder.TabIndex = 22;
            this.cbbOrder.Text = "A-Z";
            this.cbbOrder.TextChanged += new System.EventHandler(this.cbbOrder_TextChanged);
            // 
            // gbCountry
            // 
            this.gbCountry.Controls.Add(this.cbbCountry);
            this.gbCountry.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCountry.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbCountry.Location = new System.Drawing.Point(737, 53);
            this.gbCountry.Name = "gbCountry";
            this.gbCountry.Size = new System.Drawing.Size(216, 62);
            this.gbCountry.TabIndex = 22;
            this.gbCountry.TabStop = false;
            this.gbCountry.Text = "Country";
            // 
            // cbbCountry
            // 
            this.cbbCountry.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCountry.FormattingEnabled = true;
            this.cbbCountry.Items.AddRange(new object[] {
            "All",
            "Argentina",
            "France",
            "Brazil",
            "Qatar",
            "Japan",
            "South Korea",
            "Germany",
            "Croatia"});
            this.cbbCountry.Location = new System.Drawing.Point(11, 27);
            this.cbbCountry.Name = "cbbCountry";
            this.cbbCountry.Size = new System.Drawing.Size(195, 29);
            this.cbbCountry.TabIndex = 22;
            this.cbbCountry.Text = "All";
            this.cbbCountry.TextChanged += new System.EventHandler(this.cbCheck_Changed);
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
            // flpFootballerCards
            // 
            this.flpFootballerCards.AutoScroll = true;
            this.flpFootballerCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpFootballerCards.Location = new System.Drawing.Point(0, 127);
            this.flpFootballerCards.Name = "flpFootballerCards";
            this.flpFootballerCards.Size = new System.Drawing.Size(1284, 564);
            this.flpFootballerCards.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 691);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 20);
            this.panel1.TabIndex = 2;
            // 
            // fFootballer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpFootballerCards);
            this.Controls.Add(this.pSearch);
            this.Name = "fFootballer";
            this.Text = "fFootballer";
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.gbRole.ResumeLayout(false);
            this.gbRole.PerformLayout();
            this.gbOrder.ResumeLayout(false);
            this.gbCountry.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.FlowLayoutPanel flpFootballerCards;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.GroupBox gbCountry;
        private System.Windows.Forms.ComboBox cbbCountry;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.ComboBox cbbOrder;
        private System.Windows.Forms.GroupBox gbRole;
        private System.Windows.Forms.CheckBox cbMidfielder;
        private System.Windows.Forms.CheckBox cbForward;
        private System.Windows.Forms.CheckBox cbDefender;
        private System.Windows.Forms.CheckBox cbGoalkeeper;
        private System.Windows.Forms.CheckBox cbTrainer;
        private System.Windows.Forms.Panel panel1;
    }
}
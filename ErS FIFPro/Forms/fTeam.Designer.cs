namespace ErS_FIFPro.Forms
{
    partial class fTeam
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
            this.flpTeam = new System.Windows.Forms.FlowLayoutPanel();
            this.pSearch = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.cbbOrder = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTeam
            // 
            this.flpTeam.AutoScroll = true;
            this.flpTeam.BackColor = System.Drawing.SystemColors.Control;
            this.flpTeam.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpTeam.Location = new System.Drawing.Point(0, 94);
            this.flpTeam.Name = "flpTeam";
            this.flpTeam.Size = new System.Drawing.Size(1284, 597);
            this.flpTeam.TabIndex = 3;
            // 
            // pSearch
            // 
            this.pSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pSearch.Controls.Add(this.groupBox1);
            this.pSearch.Controls.Add(this.gbOrder);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSearch.Location = new System.Drawing.Point(0, 0);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(1284, 94);
            this.pSearch.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbSearch);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.groupBox1.Location = new System.Drawing.Point(221, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 62);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // txbSearch
            // 
            this.txbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbSearch.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.txbSearch.Location = new System.Drawing.Point(15, 26);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(530, 30);
            this.txbSearch.TabIndex = 21;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.cbbOrder);
            this.gbOrder.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrder.ForeColor = System.Drawing.Color.MediumOrchid;
            this.gbOrder.Location = new System.Drawing.Point(812, 17);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(210, 62);
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
            "Decrease Score",
            "Increase Score"});
            this.cbbOrder.Location = new System.Drawing.Point(14, 27);
            this.cbbOrder.Name = "cbbOrder";
            this.cbbOrder.Size = new System.Drawing.Size(180, 29);
            this.cbbOrder.TabIndex = 22;
            this.cbbOrder.Text = "A-Z";
            this.cbbOrder.TextChanged += new System.EventHandler(this.cbbOrder_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 691);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 20);
            this.panel1.TabIndex = 4;
            // 
            // fTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpTeam);
            this.Controls.Add(this.pSearch);
            this.Name = "fTeam";
            this.Text = "fTeam";
            this.pSearch.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTeam;
        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.ComboBox cbbOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Panel panel1;
    }
}
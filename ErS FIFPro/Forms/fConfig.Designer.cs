namespace ErS_FIFPro.Forms
{
    partial class fConfig
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
            this.pControl = new System.Windows.Forms.Panel();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.flpConfig = new System.Windows.Forms.FlowLayoutPanel();
            this.pControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pControl
            // 
            this.pControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pControl.Controls.Add(this.btnReset);
            this.pControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pControl.Location = new System.Drawing.Point(0, 661);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(1284, 50);
            this.pControl.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Firebrick;
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnReset.IconColor = System.Drawing.Color.Firebrick;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.IconSize = 32;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(10, 8);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnReset.Size = new System.Drawing.Size(243, 35);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset Tournament";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // flpConfig
            // 
            this.flpConfig.AutoScroll = true;
            this.flpConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpConfig.Location = new System.Drawing.Point(0, 0);
            this.flpConfig.Name = "flpConfig";
            this.flpConfig.Size = new System.Drawing.Size(1284, 661);
            this.flpConfig.TabIndex = 1;
            // 
            // fConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.flpConfig);
            this.Controls.Add(this.pControl);
            this.Name = "fConfig";
            this.Text = "fConfig";
            this.pControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pControl;
        private System.Windows.Forms.FlowLayoutPanel flpConfig;
        private FontAwesome.Sharp.IconButton btnReset;
    }
}
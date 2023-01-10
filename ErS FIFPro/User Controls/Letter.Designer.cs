namespace ErS_FIFPro.User_Controls
{
    partial class Letter
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
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(7, 32);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(1186, 40);
            this.lbMessage.TabIndex = 5;
            this.lbMessage.Text = "Trận đấu này thật hay";
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(996, 6);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(197, 23);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "2023-1-1";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(3, 6);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(118, 23);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "ErS FiFPro";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Letter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbName);
            this.Name = "Letter";
            this.Size = new System.Drawing.Size(1200, 80);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbName;
    }
}

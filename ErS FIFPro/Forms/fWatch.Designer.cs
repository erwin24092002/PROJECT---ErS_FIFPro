namespace ErS_FIFPro.Forms
{
    partial class fWatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fWatch));
            this.wbMatch = new System.Windows.Forms.WebBrowser();
            this.pTool = new System.Windows.Forms.Panel();
            this.btnComment = new FontAwesome.Sharp.IconButton();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.flpComment = new System.Windows.Forms.FlowLayoutPanel();
            this.pTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbMatch
            // 
            this.wbMatch.Dock = System.Windows.Forms.DockStyle.Left;
            this.wbMatch.Location = new System.Drawing.Point(0, 0);
            this.wbMatch.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMatch.Name = "wbMatch";
            this.wbMatch.Size = new System.Drawing.Size(1200, 661);
            this.wbMatch.TabIndex = 0;
            // 
            // pTool
            // 
            this.pTool.Controls.Add(this.btnComment);
            this.pTool.Controls.Add(this.rtbMessage);
            this.pTool.Controls.Add(this.flpComment);
            this.pTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTool.Location = new System.Drawing.Point(1200, 0);
            this.pTool.Name = "pTool";
            this.pTool.Size = new System.Drawing.Size(384, 661);
            this.pTool.TabIndex = 1;
            // 
            // btnComment
            // 
            this.btnComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComment.FlatAppearance.BorderSize = 0;
            this.btnComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComment.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComment.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnComment.IconChar = FontAwesome.Sharp.IconChar.Comment;
            this.btnComment.IconColor = System.Drawing.Color.Gainsboro;
            this.btnComment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComment.IconSize = 32;
            this.btnComment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComment.Location = new System.Drawing.Point(217, 621);
            this.btnComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComment.Name = "btnComment";
            this.btnComment.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnComment.Size = new System.Drawing.Size(156, 34);
            this.btnComment.TabIndex = 3;
            this.btnComment.Text = "Comment";
            this.btnComment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // rtbMessage
            // 
            this.rtbMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbMessage.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessage.Location = new System.Drawing.Point(0, 480);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(384, 137);
            this.rtbMessage.TabIndex = 1;
            this.rtbMessage.Text = "";
            // 
            // flpComment
            // 
            this.flpComment.AutoScroll = true;
            this.flpComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpComment.Location = new System.Drawing.Point(0, 0);
            this.flpComment.Name = "flpComment";
            this.flpComment.Size = new System.Drawing.Size(384, 480);
            this.flpComment.TabIndex = 0;
            // 
            // fWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 661);
            this.Controls.Add(this.pTool);
            this.Controls.Add(this.wbMatch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fWatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watch";
            this.pTool.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbMatch;
        private System.Windows.Forms.Panel pTool;
        private System.Windows.Forms.FlowLayoutPanel flpComment;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private FontAwesome.Sharp.IconButton btnComment;
    }
}
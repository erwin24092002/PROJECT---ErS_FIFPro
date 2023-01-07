using ErS_FIFPro.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace ErS_FIFPro.Forms
{
    public partial class fWatch : Form
    {
        private DataRow match;
        private DataRow account;
        public fWatch(DataRow match, DataRow account)
        {
            InitializeComponent();
            this.match = match;
            this.account = account;
            playVideo();
            renderComment();
        }

        private void playVideo()
        {
            string html = "<html> <head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='1192' height='640' frameborder='0' allowfullscreen></iframe>";
            html += "</head></html>";
            this.wbMatch.DocumentText = string.Format(html, match["M_LINK"].ToString().Split('=')[1]);
        }

        private void renderComment()
        {
            string filePath = "Comments/" + match["M_ID"] + ".txt";
            if (File.Exists(filePath))
            {
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();
                foreach (string line in lines)
                {
                    string[] infos = line.Split(',');
                    Comment tmp = new Comment(infos[0], infos[1], infos[2]);
                    flpComment.Controls.Add(tmp);
                    if (account["AC_NAME"].ToString() == infos[0])
                        tmp.Margin = new Padding(35, 10, 0, 0);
                    else
                        tmp.Margin = new Padding(5, 10, 0, 0);
                }
            }
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            if (rtbMessage.Text == "")
                MessageBox.Show("Empty comments!");
            else
            {
                string filePath = "Comments/" + match["M_ID"] + ".txt";
                List<string> lines = new List<string>();
                if (File.Exists(filePath))
                {
                    lines = File.ReadAllLines(filePath).ToList();
                    Comment tmp = new Comment(account["AC_NAME"].ToString(), DateTime.Now.ToString(), rtbMessage.Text);
                    flpComment.Controls.Add(tmp);
                    tmp.Margin = new Padding(35, 10, 0, 0);
                }
                lines.Add(account["AC_NAME"].ToString() + "," + DateTime.Now.ToString() + "," + rtbMessage.Text);
                File.WriteAllLines(filePath, lines);
                rtbMessage.Text = "";
            }
        }
    }
}

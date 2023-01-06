using ErS_FIFPro.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace ErS_FIFPro.Forms
{
    public partial class fWatch : Form
    {
        public fWatch()
        {
            InitializeComponent();
            playVideo();
            renderComment();
        }

        private void playVideo()
        {
            string html = "<html> <head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='1192' height='640' frameborder='0' allowfullscreen></iframe>";
            html += "</head></html>";
            this.wbMatch.DocumentText = string.Format(html, "https://www.youtube.com/watch?v=TElOdnfP1SE".Split('=')[1]);
        }

        private void renderComment()
        {
            Comment tmp = new Comment("Erwin", "2023-1-1 10:00:00", "Trận đấu này thật hay");
            tmp.Margin = new Padding(5, 10, 0, 0);
            flpComment.Controls.Add(tmp);

            Comment tmp2 = new Comment("Erwin", "2023-1-1 10:00:00", "Trận đấu này thật hay");
            tmp2.Margin = new Padding(35, 10, 0, 0);
            flpComment.Controls.Add(tmp2);
        }

        private void btnComment_Click(object sender, EventArgs e)
        {

        }
    }
}

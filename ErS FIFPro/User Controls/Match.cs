using ErS_FIFPro.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErS_FIFPro.User_Controls
{
    public partial class Match : UserControl
    {
        private DataRow account;
        private DataRow match;
        public Match(DataRow match, DataRow account)
        {
            InitializeComponent();
            this.Tag = match;

            string[] strings = match["M_DATE"].ToString().Split(' ');
            lbDate.Text = strings[0] + "\n" + strings[1] + " " + strings[2];
            this.account = account;
            this.match = match;
        }

        private void lbWatch_Click(object sender, EventArgs e)
        {
            if (match["M_LINK"].ToString() == "")
                MessageBox.Show("The match has not yet started!");
            else
            {
                fWatch f = new fWatch(match, account);
                f.ShowDialog();
            }
        }
    }
}

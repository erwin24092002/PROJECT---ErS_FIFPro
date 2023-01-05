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
        public Match(DataRow match, DataRow account)
        {
            InitializeComponent();
            this.Tag = match;

            string[] strings = match["M_DATE"].ToString().Split(' ');
            lbDate.Text = strings[0] + "\n" + strings[1] + " " + strings[2];
            this.account = account;
        }
    }
}

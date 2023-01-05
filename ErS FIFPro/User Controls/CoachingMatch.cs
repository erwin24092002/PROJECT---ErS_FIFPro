using ErS_FIFPro.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErS_FIFPro.User_Controls
{
    public partial class CoachingMatch : UserControl
    {
        private DataRow match;
        private DataRow account;
        public CoachingMatch(DataRow mat, DataRow acc)
        {
            InitializeComponent();
            match = mat;
            account = acc;

            lbDate.Text = mat["M_DATE"].ToString();
            string[] flags = { "Not Know", "Argentina", "France", "Brazil", "Qatar", "Japan", "South Korea", "Germany", "Croatia" };
            ResourceManager FlagImageManager = new ResourceManager("ErS_FIFPro.Flags", Assembly.GetExecutingAssembly());
            ptbFlag1.BackgroundImage = (Image)FlagImageManager.GetObject(String.Join("_", flags[Int32.Parse(match["M_IDTEAM1"].ToString())].Split(' ')));
            ptbFlag2.BackgroundImage = (Image)FlagImageManager.GetObject(String.Join("_", flags[Int32.Parse(match["M_IDTEAM2"].ToString())].Split(' ')));
            txbHDP1.Text = match["M_HDP1"].ToString();
            txbHDP2.Text = match["M_HDP2"].ToString();
            txbGoal1.Text = match["M_SCORE1"].ToString();
            txbGoal2.Text = match["M_SCORE2"].ToString();
            lbCountry1.Text = flags[Int32.Parse(match["M_IDTEAM1"].ToString())];
            lbCountry2.Text = flags[Int32.Parse(match["M_IDTEAM2"].ToString())];

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int match_idx = Int32.Parse(match["M_ID"].ToString());
            int base_idx = 0;
            if (Int32.Parse(match["M_IDTEAM1"].ToString()) == Int32.Parse(account["AC_IDTEAM"].ToString()))
                base_idx = match_idx * 2 - 1;
            else
                base_idx = match_idx * 2;
            fBase f = new fBase(base_idx, Int32.Parse(account["AC_IDTEAM"].ToString()));
            f.ShowDialog();
        }
    }
}

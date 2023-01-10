using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErS_FIFPro.User_Controls
{
    public partial class Team : UserControl
    {
        private DataRow team;

        public Team(DataRow team)
        {
            InitializeComponent();
            this.team = team;

            string[] flags = { "Not_Know", "Argentina", "France", "Brazil", "Qatar", "Japan", "South_Korea", "Germany", "Croatia" };
            ResourceManager FlagImageManager = new ResourceManager("ErS_FIFPro.Flags", Assembly.GetExecutingAssembly());
            ptbFlag.BackgroundImage = (Image)FlagImageManager.GetObject(flags[Int32.Parse(team["T_ID"].ToString())]);

            int win = Int32.Parse(team["T_WIN"].ToString());
            int lose = Int32.Parse(team["T_LOSE"].ToString());
            int draw = Int32.Parse(team["T_DRAW"].ToString());
            int score = win * 3 + draw;
            lbWin.Text = win.ToString();
            lbLose.Text = lose.ToString();
            lbDraw.Text = draw.ToString();
            lbScore.Text = score.ToString();
            lbTeam.Text = team["T_NAME"].ToString();

            this.Tag = team;
        }

    }
}

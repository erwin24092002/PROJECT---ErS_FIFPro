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

namespace ErS_FIFPro.Forms
{
    public partial class fCoaching : Form
    {
        public fCoaching()
        {
            InitializeComponent();
            renderCoachingMatch();
        }

        private void renderCoachingMatch()
        {
            flpCoachingMatch.Controls.Clear();
            for (int i =0; i<5; i++)
            {
                CoachingMatch tmpCoachingMatch = new CoachingMatch();
                tmpCoachingMatch.BringToFront();
                flpCoachingMatch.Controls.Add(tmpCoachingMatch);
            }
        }
    }
}

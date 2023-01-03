using ErS_FIFPro.Forms;
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
    public partial class FootballerCard : UserControl
    {
        public FootballerCard(DataRow Footballer)
        {
            InitializeComponent();

            this.Tag = Footballer;

            ResourceManager FootballerImageManager = new ResourceManager("ErS_FIFPro.Footballers", Assembly.GetExecutingAssembly());
            ptbFootballer.BackgroundImage = (Image)FootballerImageManager.GetObject(string.Join("_", Footballer["FB_NAME"].ToString().Split(' ')));
            ptbFootballer.Click += FootballerCard_Click;
            lbFootballerName.Text = Footballer["FB_NAME"].ToString();
            lbRole.Text = Footballer["FB_ROLE"].ToString();
            lbIndex.Text = Footballer["FB_INDEX"].ToString();
            lbGoal.Text = Footballer["FB_SCORE"].ToString();

            string[] flags = { "Argentina", "France", "Brazil", "Qatar", "Japan", "South_Korea", "Germany", "Croatia" };
            ResourceManager FlagImageManager = new ResourceManager("ErS_FIFPro.Flags", Assembly.GetExecutingAssembly());
            ptbFlag.BackgroundImage = (Image)FlagImageManager.GetObject(flags[Int32.Parse(Footballer["FB_IDTEAM"].ToString()) - 1]);

            this.Click += FootballerCard_Click;
        }

        private void FootballerCard_Click(object sender, EventArgs e)
        {
            fFootballerInfo f = new fFootballerInfo((DataRow)this.Tag);
            f.ShowDialog();
        }
    }
}

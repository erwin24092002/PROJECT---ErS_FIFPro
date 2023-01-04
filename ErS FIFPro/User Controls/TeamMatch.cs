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
    public partial class TeamMatch : UserControl
    {
        public TeamMatch(IContainer container, int id)
        {
            InitializeComponent();
            container.Add(this);

            string[] flags = { "Not_Know", "Argentina", "France", "Brazil", "Qatar", "Japan", "South_Korea", "Germany", "Croatia" };
            ResourceManager FlagImageManager = new ResourceManager("ErS_FIFPro.Flags", Assembly.GetExecutingAssembly());
            ptbTeam.BackgroundImage = (Image)FlagImageManager.GetObject(flags[id]);
        }

        Point point;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            point = e.Location;
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
            base.OnMouseMove(e);
        }
    }
}

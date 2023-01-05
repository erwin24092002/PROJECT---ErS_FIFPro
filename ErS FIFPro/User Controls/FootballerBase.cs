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
    public partial class FootballerBase : UserControl
    {
        private DataRow Footballer;
        public FootballerBase(IContainer container, DataRow footballer)
        {
            InitializeComponent();
            container.Add(this);

            Footballer = footballer;
            this.Tag = Footballer;

            ResourceManager FootballerImageManager = new ResourceManager("ErS_FIFPro.Footballers", Assembly.GetExecutingAssembly());
            ptbFootballer.BackgroundImage = (Image)FootballerImageManager.GetObject(string.Join("_", Footballer["FB_NAME"].ToString().Split(' ')));
            lbFootballerName.Text = Footballer["FB_NAME"].ToString();
            lbRole.Text = Footballer["FB_ROLE"].ToString();
            lbIndex.Text = Footballer["FB_INDEX"].ToString();

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

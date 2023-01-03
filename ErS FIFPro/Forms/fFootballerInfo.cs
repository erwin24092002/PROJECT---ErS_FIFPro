using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErS_FIFPro.Forms
{
    public partial class fFootballerInfo : Form
    {
        public fFootballerInfo(DataRow Footballer)
        {
            InitializeComponent();

            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            ResourceManager FootballerImageManager = new ResourceManager("ErS_FIFPro.FootballerInfos", Assembly.GetExecutingAssembly());
            ptbFootballerInfo.BackgroundImage = (Image)FootballerImageManager.GetObject(string.Join("_", Footballer["FB_NAME"].ToString().Split(' ')) + "2");
            lbFootballerName.Text = Footballer["FB_NAME"].ToString();
            lbFootballerRole.Text = "Role: " + Footballer["FB_ROLE"].ToString();
            lbFootballerIndex.Text = "Index: " + Footballer["FB_INDEX"].ToString();
            string[] flags = { "Argentina", "France", "Brazil", "Qatar", "Japan", "South_Korea", "Germany", "Croatia" };
            lbFootballerCountry.Text = "Country: " + flags[Int32.Parse(Footballer["FB_IDTEAM"].ToString()) - 1];
            lbFootballerBirthday.Text = "Birthday: " + Footballer["FB_BIRTHDAY"].ToString().Split(' ')[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pNav_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            ((IconButton)sender).IconColor = Color.Gainsboro;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            ((IconButton)sender).IconColor = Color.Red;
        }
    }
}

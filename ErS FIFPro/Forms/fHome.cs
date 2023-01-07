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
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErS_FIFPro.Forms
{
    public partial class fHome : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private MyColor myColors = new MyColor();
        private Form currentChildForm;
        private DataRow account;

        public fHome(DataRow acc)
        {
            InitializeComponent();
            account = acc;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 55);
            pNav.Controls.Add(leftBorderBtn);

            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            ResourceManager AccountImageManager = new ResourceManager("ErS_FIFPro.Accounts", Assembly.GetExecutingAssembly());
            ptbAccount.BackgroundImage = (Image)AccountImageManager.GetObject("Acc" + string.Join("_", account["AC_NAME"].ToString().Split(' ')));
            lbAccountName.Text = account["AC_NAME"].ToString();
            lbAccountCoin.Text = account["AC_COIN"].ToString() + "$";
            int role = Int32.Parse(account["AC_ROLE"].ToString());
            if (role == 0)
            {
                lbAccountRole.Text = "Viewer";
                this.btnConfig.Enabled = false;
                this.btnCoaching.Enabled = false;
            }
            if (role == 1)
            {
                lbAccountRole.Text = "Team Manager";
                this.btnConfig.Enabled = false;
            }
            if (role == 2)
            {
                lbAccountRole.Text = "Admin";
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Size = new Size(currentBtn.Width, 7);
                leftBorderBtn.Location = new Point(currentBtn.Location.X, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(26, 25, 62);
                currentBtn.ForeColor = Color.Gainsboro;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pChildForm.Controls.Add(childForm);
            pChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
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

        private void btnMatch_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, myColors.ActiveButtonColor);
            OpenChildForm(new fMatch(account));
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, myColors.ActiveButtonColor);
            OpenChildForm(new fResult(account));
        }

        private void btnBetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, myColors.ActiveButtonColor);
            OpenChildForm(new fBetting());
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, myColors.ActiveButtonColor);
            OpenChildForm(new fTeam());
        }

        private void btnFootballer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, myColors.ActiveButtonColor);
            OpenChildForm(new fFootballer());
        }

        private void btnCoaching_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, myColors.ActiveButtonColor);
            OpenChildForm(new fCoaching(account));
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, myColors.ActiveButtonColor);
            OpenChildForm(new fConfig());
        }

        private void btnLetter_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, myColors.ActiveButtonColor);
            OpenChildForm(new fLetter());
        }
    }
}

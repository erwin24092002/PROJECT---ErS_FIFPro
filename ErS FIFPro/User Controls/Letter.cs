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
    public partial class Letter : UserControl
    {
        private DataRow letter;
        public Letter(DataRow letter)
        {
            InitializeComponent();
            this.letter = letter;

            lbDate.Text = letter["L_DATE"].ToString();
            lbMessage.Text = letter["L_MESSAGE"].ToString();
        }

    }
}

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
        public Match(DataRow match)
        {
            InitializeComponent();
            this.Tag = match;
        }
    }
}

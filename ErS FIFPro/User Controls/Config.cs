using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErS_FIFPro.User_Controls
{
    public partial class Config : UserControl
    {
        private DataRow match;
        private DataRow account;
        public Config(DataRow match, DataRow account)
        {
            InitializeComponent();

            this.match = match;
            this.account = account;

            lbDate.Text = match["M_DATE"].ToString();
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
            txbLink.Text = match["M_LINK"].ToString();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                string SCORE1 = "M_SCORE1=" + txbGoal1.Text;
                string SCORE2 = "M_SCORE2=" + txbGoal2.Text;
                string HDP1 = "M_HDP1=" + txbHDP1.Text;
                string HDP2 = "M_HDP2=" + txbHDP2.Text;
                string LINK = "M_LINK='" + txbLink.Text + "'";

                string query = "UPDATE FMATCH SET " + SCORE1 + ", " + SCORE2 + ", " + HDP1 + ", " + HDP2 + ", " + LINK + " WHERE M_ID=" + match["M_ID"].ToString();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                if (Int32.Parse(txbGoal1.Text) != Int32.Parse(txbGoal2.Text))
                {
                    query = "UPDATE FMATCH SET M_STATUS=1 WHERE M_ID=" + match["M_ID"].ToString();
                }
                SqlCommand command2 = new SqlCommand(query, connection);
                command2.ExecuteNonQuery();

                connection.Close();
            }
            MessageBox.Show("Successful change!");
        }
    }
}

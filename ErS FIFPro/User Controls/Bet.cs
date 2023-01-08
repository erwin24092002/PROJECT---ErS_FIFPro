using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErS_FIFPro.User_Controls
{
    public partial class Bet : UserControl
    {
        private DataRow bet;
        private DataRow match;
        private DataRow account;
        public Bet(DataRow bet)
        {
            InitializeComponent();

            this.bet = bet;
            this.match = getMatch();
            this.account = getAccount();
            this.Tag = bet;

            lbDate.Text = match["M_DATE"].ToString();
            string[] flags = { "Not Know", "Argentina", "France", "Brazil", "Qatar", "Japan", "South Korea", "Germany", "Croatia" };
            ResourceManager FlagImageManager = new ResourceManager("ErS_FIFPro.Flags", Assembly.GetExecutingAssembly());
            ptbFlag1.BackgroundImage = (Image)FlagImageManager.GetObject(String.Join("_", flags[Int32.Parse(match["M_IDTEAM1"].ToString())].Split(' ')));
            ptbFlag2.BackgroundImage = (Image)FlagImageManager.GetObject(String.Join("_", flags[Int32.Parse(match["M_IDTEAM2"].ToString())].Split(' ')));
            txbHDP1.Text = match["M_HDP1"].ToString();
            txbHDP2.Text = match["M_HDP2"].ToString();
            lbCountry1.Text = flags[Int32.Parse(match["M_IDTEAM1"].ToString())];
            lbCountry2.Text = flags[Int32.Parse(match["M_IDTEAM2"].ToString())];
            cbbTeam.Items.Add(flags[Int32.Parse(match["M_IDTEAM1"].ToString())]);
            cbbTeam.Items.Add(flags[Int32.Parse(match["M_IDTEAM2"].ToString())]);
            cbbTeam.Text = flags[Int32.Parse(bet["B_IDTEAM"].ToString())];
            txbCoin.Text = bet["B_COIN"].ToString();
            btnSaveChange.Tag = bet;
            btnRemove.Tag = bet;
            if (Int32.Parse(bet["B_STATUS"].ToString()) == 1)
            {
                btnSaveChange.Enabled = false;
                btnRemove.Enabled = false;
            }    
        }
        private DataRow getMatch()
        {
            string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                string query = "SELECT * FROM FMATCH WHERE M_ID=" + bet["B_IDMATCH"].ToString();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data.Rows[0];
        }
        private DataRow getAccount()
        {
            string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                string query = "SELECT * FROM ACCOUNT WHERE AC_ID=" + bet["B_IDACCOUNT"].ToString();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data.Rows[0];
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            int user_coin = Int32.Parse(account["AC_COIN"].ToString());
            int old_coin = Int32.Parse(bet["B_COIN"].ToString());
            int new_coin = Int32.Parse(txbCoin.Text);
            if (user_coin + old_coin < new_coin)
                MessageBox.Show("The amount of money in your account is insufficient!");
            else
            {
                string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    string[] flags = { "Not Know", "Argentina", "France", "Brazil", "Qatar", "Japan", "South Korea", "Germany", "Croatia" };
                    int id_team = 1;
                    if (flags[Int32.Parse(match["M_IDTEAM1"].ToString())] == cbbTeam.Text)
                        id_team = Int32.Parse(match["M_IDTEAM1"].ToString());
                    else
                        id_team = Int32.Parse(match["M_IDTEAM2"].ToString());
                    string query = "UPDATE BET  SET B_IDTEAM="+ id_team.ToString() + ", B_COIN=" + txbCoin.Text + ", B_DATE='" + DateTime.Now.ToString() + "' WHERE B_ID=" + bet["B_ID"].ToString();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    int new_coinn = user_coin + old_coin - new_coin;
                    string query = "UPDATE ACCOUNT SET AC_COIN=" + new_coinn.ToString() + " WHERE AC_ID=" + account["AC_ID"].ToString();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                MessageBox.Show("Successful change!");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int user_coin = Int32.Parse(account["AC_COIN"].ToString());
            int old_coin = Int32.Parse(bet["B_COIN"].ToString());
            string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                int new_coinn = user_coin + old_coin;
                string query = "UPDATE ACCOUNT SET AC_COIN=" + new_coinn.ToString() + " WHERE AC_ID=" + account["AC_ID"].ToString();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                string query = "DELETE FROM BET WHERE B_ID=" + bet["B_ID"].ToString();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
            MessageBox.Show("Successful Remove!");
            this.Visible = false;
        }
    }
}

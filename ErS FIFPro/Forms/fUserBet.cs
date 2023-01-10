using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections;

namespace ErS_FIFPro.Forms
{
    public partial class fUserBet : Form
    {
        private DataRow match;
        private DataRow account;
        public fUserBet(DataRow match, DataRow account)
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
            lbCountry1.Text = flags[Int32.Parse(match["M_IDTEAM1"].ToString())];
            lbCountry2.Text = flags[Int32.Parse(match["M_IDTEAM2"].ToString())];
            cbbTeam.Items.Add(flags[Int32.Parse(match["M_IDTEAM1"].ToString())]);
            cbbTeam.Items.Add(flags[Int32.Parse(match["M_IDTEAM2"].ToString())]);
            cbbTeam.Text = flags[Int32.Parse(match["M_IDTEAM1"].ToString())];
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(account["AC_COIN"].ToString()) < Int32.Parse(txbCoin.Text))
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
                    string query = "INSERT INTO BET (B_IDACCOUNT, B_IDMATCH, B_IDTEAM, B_COIN, B_DATE, B_STATUS) VALUES ('" + account["AC_ID"].ToString() + "', '" + match["M_ID"].ToString() + "', '" + id_team.ToString() + "', '" + txbCoin.Text + "', '" + DateTime.Now.ToString() + "', '" + "0" + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    int new_coin = Int32.Parse(account["AC_COIN"].ToString()) - Int32.Parse(txbCoin.Text);
                    string query = "UPDATE ACCOUNT SET AC_COIN=" + new_coin.ToString() + " WHERE AC_ID=" + account["AC_ID"].ToString();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    string[] flags = { "Not Know", "Argentina", "France", "Brazil", "Qatar", "Japan", "South Korea", "Germany", "Croatia" };
                    string message = $"You just placed {txbCoin.Text} coins bet {cbbTeam.Text} won {flags[Int32.Parse(match["M_IDTEAM1"].ToString())]} vs {flags[Int32.Parse(match["M_IDTEAM2"].ToString())]}";
                    query = $"INSERT INTO LETTER (L_IDACCOUNT, L_DATE, L_MESSAGE) VALUES ({account["AC_ID"]}, '{DateTime.Now.ToString()}', '{message}')";
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress("20521907@gm.uit.edu.vn");
                        mail.To.Add("truongthang2409@gmail.com");
                        mail.Subject = "[Announcement] ErS FIFPro";

                        string htmlString = $"<html> <body> <p> {message} </p> </body> </html>";
                        mail.Body = htmlString;
                        mail.IsBodyHtml = true;

                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.Credentials = new NetworkCredential("20521907@gm.uit.edu.vn", "TruongThang0979297634");
                            smtp.EnableSsl = true;
                            smtp.Send(mail);
                        }
                    }

                    connection.Close();
                }
                MessageBox.Show("Successful bet!");
                this.Close();
            }
        }
    }
}

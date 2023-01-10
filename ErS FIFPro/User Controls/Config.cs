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
                    SqlCommand command2 = new SqlCommand(query, connection);
                    command2.ExecuteNonQuery();

                    query = "UPDATE BET SET B_STATUS=1 WHERE B_IDMATCH=" + match["M_ID"].ToString();
                    SqlCommand command3 = new SqlCommand(query, connection);
                    command3.ExecuteNonQuery();

                    int id_match = Int32.Parse(match["M_ID"].ToString());
                    int id_teamwin = 0;
                    int id_teamlose = 0;
                    if (float.Parse(txbGoal1.Text) - float.Parse(txbHDP1.Text) < float.Parse(txbGoal2.Text) - float.Parse(txbHDP2.Text))
                    {
                        id_teamwin = Int32.Parse(match["M_IDTEAM2"].ToString());
                        id_teamlose = Int32.Parse(match["M_IDTEAM1"].ToString());
                    }
                    else
                    {
                        id_teamwin = Int32.Parse(match["M_IDTEAM1"].ToString());
                        id_teamlose = Int32.Parse(match["M_IDTEAM2"].ToString());
                    }

                    query = "UPDATE TEAM SET T_WIN+=1 WHERE T_ID=" + id_teamwin.ToString();
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    query = "UPDATE TEAM SET T_LOSE+=1 WHERE T_ID=" + id_teamlose.ToString();
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    switch (id_match)
                    {
                        case 1:
                            query = "UPDATE TMATCH SET M_IDTEAM=" + id_teamwin.ToString() + " WHERE M_ID=9";
                            command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            query = "UPDATE FMATCH SET M_IDTEAM1=" + id_teamwin.ToString() + " WHERE M_ID=5";
                            command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            break;
                        case 2:
                            query = "UPDATE TMATCH SET M_IDTEAM=" + id_teamwin.ToString() + " WHERE M_ID=10";
                            command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            query = "UPDATE FMATCH SET M_IDTEAM2=" + id_teamwin.ToString() + " WHERE M_ID=5";
                            command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            break;
                        case 3:
                            query = "UPDATE TMATCH SET M_IDTEAM=" + id_teamwin.ToString() + " WHERE M_ID=11";
                            command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            query = "UPDATE FMATCH SET M_IDTEAM1=" + id_teamwin.ToString() + " WHERE M_ID=6";
                            command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            break;
                        case 4:
                            query = "UPDATE TMATCH SET M_IDTEAM=" + id_teamwin.ToString() + " WHERE M_ID=12";
                            command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            query = "UPDATE FMATCH SET M_IDTEAM2=" + id_teamwin.ToString() + " WHERE M_ID=6";
                            command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            break;
                        case 5:
                            query = "UPDATE TMATCH SET M_IDTEAM=" + id_teamwin.ToString() + " WHERE M_ID=13";
                            command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            query = "UPDATE FMATCH SET M_IDTEAM1=" + id_teamwin.ToString() + " WHERE M_ID=7";
                            command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            break;
                        case 6:
                            query = "UPDATE TMATCH SET M_IDTEAM=" + id_teamwin.ToString() + " WHERE M_ID=14";
                            command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            query = "UPDATE FMATCH SET M_IDTEAM2=" + id_teamwin.ToString() + " WHERE M_ID=7";
                            command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            break;
                        case 7:
                            query = "UPDATE TMATCH SET M_IDTEAM=" + id_teamwin.ToString() + " WHERE M_ID=15";
                            command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            break;
                    }

                    DataTable bet = new DataTable();
                    query = "SELECT * FROM BET WHERE B_STATUS!=0 AND B_IDMATCH=" + match["M_ID"].ToString() + " AND B_IDTEAM=" + id_teamwin.ToString();
                    command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(bet);

                    foreach (DataRow row in bet.Rows)
                    {
                        int add_coin = 2 * Int32.Parse(row["B_COIN"].ToString());
                        query = "UPDATE ACCOUNT SET AC_COIN+=" + add_coin.ToString() + " WHERE AC_ID=" + row["B_IDACCOUNT"].ToString();
                        command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();

                        string[] flags = { "Not Know", "Argentina", "France", "Brazil", "Qatar", "Japan", "South Korea", "Germany", "Croatia" };
                        string message = "You just got " + add_coin.ToString() + " coins from the match between " + flags[Int32.Parse(match["M_IDTEAM1"].ToString())] + " and " + flags[Int32.Parse(match["M_IDTEAM2"].ToString())];
                        query = "INSERT INTO LETTER (L_IDACCOUNT, L_DATE, L_MESSAGE) VALUES (" + row["B_IDACCOUNT"].ToString() + ", '" + DateTime.Now.ToString() + "', '" + message + "')";
                        command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();

                        using (MailMessage mail = new MailMessage())
                        {

                            mail.From = new MailAddress("20521907@gm.uit.edu.vn");
                            mail.To.Add("truongthang2409@gmail.com");
                            mail.Subject = "ErS FIFPro Betting";
                            string htmlString = $@"<html> <body> <p> {message} </p> </body> </html>";
                            mail.Body = htmlString;
                            mail.IsBodyHtml = true;

                            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                            {
                                smtp.Credentials = new NetworkCredential("20521907@gm.uit.edu.vn", "TruongThang0979297634");
                                smtp.EnableSsl = true;
                                smtp.Send(mail);
                            }
                        }
                    }
                }
                connection.Close();
            }
            MessageBox.Show("Successful change!");
        }
    }
}

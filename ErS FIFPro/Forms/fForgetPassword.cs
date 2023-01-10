using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ErS_FIFPro.Forms
{
    public partial class fForgetPassword : Form
    {
        public fForgetPassword()
        {
            InitializeComponent();
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            using (MailMessage mail = new MailMessage())
            {
                string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
                DataTable data = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    string email = txbEmail.Text;
                    string query = $"SELECT * FROM ACCOUNT WHERE AC_EMAIL='{email}'";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    connection.Close();
                }
                if (data.Rows.Count == 0)
                {
                    MessageBox.Show("Wrong Email!");
                }
                else
                {
                    DataRow account = data.Rows[0];

                    mail.From = new MailAddress("20521907@gm.uit.edu.vn");
                    mail.To.Add("truongthang2409@gmail.com");
                    mail.Subject = "[Announcement] ErS FIFPro";

                    string message = $"Account: {account["AC_NAME"]}, Password: {account["AC_PASSWORD"]}";
                    string htmlString = $"<html> <body> <p> {message} </p> </body> </html>";
                    mail.Body = htmlString;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("20521907@gm.uit.edu.vn", "TruongThang0979297634");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                    MessageBox.Show("The account has been sent to your email!");
                    this.Close();
                }
            }
        }
    }
}

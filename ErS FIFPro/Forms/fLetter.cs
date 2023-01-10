using ErS_FIFPro.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErS_FIFPro.Forms
{
    public partial class fLetter : Form
    {
        private DataRow account;
        private DataTable Letters;
        public fLetter(DataRow account)
        {
            InitializeComponent();
            this.account = account;
            Letters = getLetters();
            renderLetter();
        }
        private DataTable getLetters()
        {
            string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                string query = "SELECT * FROM LETTER WHERE L_IDACCOUNT=" + account["AC_ID"].ToString();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        private void renderLetter()
        {
            foreach(DataRow letter in Letters.Rows)
            {
                Letter tmp = new Letter(letter);
                flpLetter.Controls.Add(tmp);
            }
        }

    }
}

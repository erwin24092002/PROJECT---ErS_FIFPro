using ErS_FIFPro.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErS_FIFPro
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable accountList = getAccount(txbUserName.Text, txbPassword.Text);
            if (accountList.Rows.Count > 0)
            {
                fHome f = new fHome(accountList.Rows[0]);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Incorrect account or password!");
            }
        }

        private DataTable getAccount(string name, string password)
        {
            string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                string query = "SELECT * FROM ACCOUNT WHERE AC_NAME='" + name + "' AND AC_PASSWORD='" + password + "'";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txbUserName2.Text == "")
                MessageBox.Show("You haven't entered your user name!");
            else if (txbPassword2.Text == "")
                MessageBox.Show("You haven't entered your password!");
            else if (txbConfPassword.Text == "")
                MessageBox.Show("You haven't confirmed your password!");
            else if (txbConfPassword.Text != txbPassword2.Text)
                MessageBox.Show("Password and confirm password are not the same!");
            else if (getAccountByName(txbUserName2.Text).Rows.Count > 1)
                MessageBox.Show("Username already exists!");
            else
            {
                createAccount(txbUserName2.Text, txbPassword2.Text);
                MessageBox.Show("Successful registration!");
                txbUserName2.Text = "";
                txbPassword2.Text = "";
                txbConfPassword.Text = "";
            }
        }

        private DataTable getAccountByName(string name)
        {
            string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                string query = "SELECT * FROM ACCOUNT WHERE AC_NAME='" + name + "'";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        private void createAccount(string name, string password)
        {
            string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                string email = txbEmail.Text;
                string query = $"INSERT INTO ACCOUNT (AC_NAME, AC_PASSWORD, AC_EMAIL) VALUES ('{name}', '{password}', '{email}')";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            fForgetPassword f = new fForgetPassword();
            f.ShowDialog();
        }
    }
}

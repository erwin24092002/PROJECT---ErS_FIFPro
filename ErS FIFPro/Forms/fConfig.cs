using ErS_FIFPro.User_Controls;
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

namespace ErS_FIFPro.Forms
{
    public partial class fConfig : Form
    {
        private DataTable Matchs;
        private List<Config> MatchConfigList;
        private DataRow account;
        public fConfig(DataRow account)
        {
            InitializeComponent();

            this.account = account;

            Matchs = getMatchs();
            MatchConfigList = genConfigList(Matchs);
            renderConfigList();
        }

        private DataTable getMatchs()
        {
            string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                string query = "SELECT * FROM FMATCH WHERE M_IDTEAM1!=0 AND M_IDTEAM2!=0";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        private List<Config> genConfigList(DataTable Matchs)
        {
            List<Config> configList = new List<Config>();
            foreach (DataRow row in Matchs.Rows)
            {
                Config tmp = new Config(row, account);
                configList.Add(tmp);
            }
            return configList;
        }

        private void renderConfigList()
        {
            foreach (Config result in MatchConfigList)
                flpConfig.Controls.Add(result);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
            
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                string query = "EXEC RESET_ALL";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
            MessageBox.Show("Successful reset!");
        }
    }
}

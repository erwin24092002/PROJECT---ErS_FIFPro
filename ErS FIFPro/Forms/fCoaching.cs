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
    public partial class fCoaching : Form
    {
        private DataRow account;
        private DataTable Coachings;
        public fCoaching(DataRow acc)
        {
            InitializeComponent();
            account = acc;
            Coachings = getCoachings();
            renderCoachings();
        }

        private DataTable getCoachings()
        {
            string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                string query = "SELECT * FROM FMATCH WHERE M_IDTEAM1='" + account["AC_IDTEAM"] + "' OR M_IDTEAM2='" + account["AC_IDTEAM"] + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        private void renderCoachings()
        {
            flpCoachingMatch.Controls.Clear();
            foreach (DataRow row in Coachings.Rows)
            {
                CoachingMatch match = new CoachingMatch(row, account);
                flpCoachingMatch.Controls.Add(match);
            }
        }
    }
}

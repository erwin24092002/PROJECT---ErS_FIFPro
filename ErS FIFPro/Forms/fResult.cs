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
    
    public partial class fResult : Form
    {
        private DataTable Matchs;
        private List<Result> MatchResultList;
        private DataRow account;
        public fResult(DataRow account)
        {
            InitializeComponent();
            this.account = account;
            Matchs = getMatchs();
            MatchResultList = genResultList(Matchs);
            renderResultList();
        }
        private DataTable getMatchs()
        {
            string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                string query = "SELECT * FROM FMATCH WHERE M_STATUS=1";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        private List<Result> genResultList(DataTable Matchs)
        {
            List<Result> resultList = new List<Result>();
            foreach (DataRow row in Matchs.Rows)
            {
                Result tmp = new Result(row, account);
                resultList.Add(tmp);
            }
            return resultList;
        }

        private void renderResultList()
        {
            foreach (Result result in MatchResultList)
                flpResult.Controls.Add(result);
        }
    }
}

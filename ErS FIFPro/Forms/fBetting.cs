using ErS_FIFPro.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErS_FIFPro.Forms
{
    public partial class fBetting : Form
    {
        private DataRow account;
        private DataTable Bets;
        private List<Bet> BetList;

        public fBetting(DataRow account)
        {
            InitializeComponent();

            this.account = account;

            Bets = getBets();
            BetList = genBetList(Bets);
            renderBetList();
        }
        private DataTable getBets()
        {
            string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                string query = "SELECT * FROM BET WHERE B_IDACCOUNT=" + account["AC_ID"].ToString();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        private List<Bet> genBetList(DataTable Bets)
        {
            List<Bet> list = new List<Bet>();
            foreach (DataRow row in Bets.Rows)
            {
                Bet tmp = new Bet(row);
                list.Add(tmp);
            }
            return list;
        }
        private void renderBetList()
        {
            foreach (Bet tmp in BetList)
            {
                flpBet.Controls.Add(tmp);
            }
        }
        
    }
}

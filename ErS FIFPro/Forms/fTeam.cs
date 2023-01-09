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
    public partial class fTeam : Form
    {
        private DataTable Teams;
        private List<Team> TeamList;

        public fTeam()
        {
            InitializeComponent();
            Teams = getTeams();
            TeamList = genTeamList();
            reOrder();
            renderTeams();
        }
        private DataTable getTeams()
        {
            string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                string query = "SELECT * FROM TEAM";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        private List<Team> genTeamList()
        {
            List<Team> TeamList = new List<Team>();
            foreach (DataRow row in Teams.Rows)
            {
                Team tmpCard = new Team(row);
                TeamList.Add(tmpCard);
            }
            return TeamList;
        }
        private void renderTeams()
        {
            flpTeam.Controls.Clear();
            foreach(Team item in TeamList)
            {
                DataRow team = (DataRow)item.Tag;
                if (!team["T_NAME"].ToString().ToLower().Contains(txbSearch.Text.ToLower()))
                    continue;
                flpTeam.Controls.Add(item);
            }
        }
        private void reOrder()
        {
            if (cbbOrder.Text == "A-Z")
            {
                for (int i=0; i<TeamList.Count; i++)
                {
                    for (int j=i+1; j<TeamList.Count; j++)
                    {
                        DataRow teami = (DataRow)TeamList[i].Tag;
                        DataRow teamj = (DataRow)TeamList[j].Tag;
                        if (String.Compare(teami["T_NAME"].ToString(), teamj["T_NAME"].ToString()) > 0)
                        {
                            Team tmp = TeamList[i];
                            TeamList[i] = TeamList[j];
                            TeamList[j] = tmp;
                        }
                    }
                }
            }
            else if (cbbOrder.Text == "Z-A")
            {
                for (int i = 0; i < TeamList.Count; i++)
                {
                    for (int j = i + 1; j < TeamList.Count; j++)
                    {
                        DataRow teami = (DataRow)TeamList[i].Tag;
                        DataRow teamj = (DataRow)TeamList[j].Tag;
                        if (String.Compare(teami["T_NAME"].ToString(), teamj["T_NAME"].ToString()) < 0)
                        {
                            Team tmp = TeamList[i];
                            TeamList[i] = TeamList[j];
                            TeamList[j] = tmp;
                        }
                    }
                }
            }
            else if (cbbOrder.Text == "Increase Score")
            {
                for (int i = 0; i < TeamList.Count; i++)
                {
                    for (int j = i + 1; j < TeamList.Count; j++)
                    {
                        DataRow teami = (DataRow)TeamList[i].Tag;
                        int wini = Int32.Parse(teami["T_WIN"].ToString());
                        int drawi = Int32.Parse(teami["T_DRAW"].ToString());
                        int scorei = wini * 3 + drawi;
                        DataRow teamj = (DataRow)TeamList[j].Tag;
                        int winj = Int32.Parse(teamj["T_WIN"].ToString());
                        int drawj = Int32.Parse(teamj["T_DRAW"].ToString());
                        int scorej = winj * 3 + drawj;
                        if (scorei>scorej)
                        {
                            Team tmp = TeamList[i];
                            TeamList[i] = TeamList[j];
                            TeamList[j] = tmp;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < TeamList.Count; i++)
                {
                    for (int j = i + 1; j < TeamList.Count; j++)
                    {
                        DataRow teami = (DataRow)TeamList[i].Tag;
                        int wini = Int32.Parse(teami["T_WIN"].ToString());
                        int drawi = Int32.Parse(teami["T_DRAW"].ToString());
                        int scorei = wini * 3 + drawi;
                        DataRow teamj = (DataRow)TeamList[j].Tag;
                        int winj = Int32.Parse(teamj["T_WIN"].ToString());
                        int drawj = Int32.Parse(teamj["T_DRAW"].ToString());
                        int scorej = winj * 3 + drawj;
                        if (scorei < scorej)
                        {
                            Team tmp = TeamList[i];
                            TeamList[i] = TeamList[j];
                            TeamList[j] = tmp;
                        }
                    }
                }
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            renderTeams();
        }

        private void cbbOrder_TextChanged(object sender, EventArgs e)
        {
            reOrder();
            renderTeams();
        }
    }
}

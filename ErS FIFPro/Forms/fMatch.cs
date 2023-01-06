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
using System.Windows.Media;

namespace ErS_FIFPro.Forms
{
    public partial class fMatch : Form
    {
        private DataTable Teams;
        private DataTable Matchs;
        private List<TeamMatch> TeamMatchList;
        private List<Match> MatchList;
        private DataRow account;

        public fMatch(DataRow account)
        {
            InitializeComponent();
            this.account = account;

            Teams = getTeams();
            TeamMatchList = genTeamMatchList(Teams);
            renderTeamMatchList();
            Matchs = getMatchs();
            MatchList = genMatchList(Matchs);
            renderMatchList();
        }
        private DataTable getMatchs()
        {
            string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                string query = "SELECT * FROM FMATCH ";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        private List<Match> genMatchList(DataTable Matchs)
        {
            List<Match> MatchList = new List<Match>();
            Match tmpCard = new Match(Matchs.Rows[0], account);
            MatchList.Add(tmpCard);

            foreach (DataRow row in Matchs.Rows)
            {
                Match tmpCard1 = new Match(row, account);
                MatchList.Add(tmpCard1);
            }

            return MatchList;
        }

        private void renderMatchList()
        {
            for (int i = 1; i <= 7; i++)
            {
                this.Controls.Add(MatchList[i]);
                MatchList[i].BringToFront();
            }

            MatchList[1].Location = new Point(256, 12);
            MatchList[2].Location = new Point(256, 619);
            MatchList[3].Location = new Point(909, 12);
            MatchList[4].Location = new Point(909, 619);
            MatchList[5].Location = new Point(256, 315);
            MatchList[6].Location = new Point(909, 315);
            MatchList[7].Location = new Point(584, 315);
        }

        private DataTable getTeams()
        {
            string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                string query = "SELECT * FROM TMATCH ";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        private List<TeamMatch> genTeamMatchList(DataTable Teams)
        {
            List<TeamMatch> TeamMatchList = new List<TeamMatch>();
            IContainer container = new Container();
            TeamMatch tmpCard = new TeamMatch(container, 0, account, 0);
            TeamMatchList.Add(tmpCard);

            int id = 1;
            foreach (DataRow row in Teams.Rows)
            {
                IContainer container1 = new Container();
                TeamMatch tmpCard1 = new TeamMatch(container1, Int32.Parse(row["M_IDTEAM"].ToString()), account, id);
                TeamMatchList.Add(tmpCard1);
                id++;
            }

            return TeamMatchList;
        }
        private void renderTeamMatchList()
        {
            for (int i = 1; i <= 15; i++)
            {
                this.Controls.Add(TeamMatchList[i]);
                TeamMatchList[i].BringToFront();
            }

            TeamMatchList[1].Location = new Point(pTeam1.Location.X + 5, pTeam1.Location.Y + 5);
            TeamMatchList[2].Location = new Point(pTeam2.Location.X + 5, pTeam2.Location.Y + 5);
            TeamMatchList[3].Location = new Point(pTeam3.Location.X + 5, pTeam3.Location.Y + 5);
            TeamMatchList[4].Location = new Point(pTeam4.Location.X + 5, pTeam4.Location.Y + 5);
            TeamMatchList[5].Location = new Point(pTeam5.Location.X + 5, pTeam5.Location.Y + 5);
            TeamMatchList[6].Location = new Point(pTeam6.Location.X + 5, pTeam6.Location.Y + 5);
            TeamMatchList[7].Location = new Point(pTeam7.Location.X + 5, pTeam7.Location.Y + 5);
            TeamMatchList[8].Location = new Point(pTeam8.Location.X + 5, pTeam8.Location.Y + 5);
            TeamMatchList[9].Location = new Point(pTeam9.Location.X + 5, pTeam9.Location.Y + 5);
            TeamMatchList[10].Location = new Point(pTeam10.Location.X + 5, pTeam10.Location.Y + 5);
            TeamMatchList[11].Location = new Point(pTeam11.Location.X + 5, pTeam11.Location.Y + 5);
            TeamMatchList[12].Location = new Point(pTeam12.Location.X + 5, pTeam12.Location.Y + 5);
            TeamMatchList[13].Location = new Point(pTeam13.Location.X + 5, pTeam13.Location.Y + 5);
            TeamMatchList[14].Location = new Point(pTeam14.Location.X + 5, pTeam14.Location.Y + 5);
            TeamMatchList[15].Location = new Point(pTeam15.Location.X + 5, pTeam15.Location.Y + 5);
        }

        private void btnLetter_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Panel)sender).Location.ToString());
        }
    }
}

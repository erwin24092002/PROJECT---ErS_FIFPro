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
using System.Xml.Linq;

namespace ErS_FIFPro.Forms
{
    public partial class fFootballer : Form
    {
        private DataTable Footballers;
        private List<FootballerCard> FootballerCardList;
        public fFootballer()
        {
            InitializeComponent();
            Footballers = getFootballers();
            FootballerCardList = genFootballerCards(Footballers);
            reOrder();
            renderFootballerCardList(FootballerCardList);
        }

        private DataTable getFootballers()
        {
            string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                string query = "SELECT * FROM FOOTBALLER ";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        private List<FootballerCard> genFootballerCards(DataTable Footballers)
        {
            List<FootballerCard> FootballerCardList = new List<FootballerCard>();
            foreach (DataRow row in Footballers.Rows)
            {
                FootballerCard tmpCard = new FootballerCard(row);
                FootballerCardList.Add(tmpCard);
            }
            return FootballerCardList;
        }

        private void renderFootballerCardList(List<FootballerCard> FootballerCardList)
        {
            flpFootballerCards.Controls.Clear();
            foreach (FootballerCard footballerCard in FootballerCardList)
            {
                DataRow tmpFootballer = (DataRow)footballerCard.Tag;
                if (!tmpFootballer["FB_NAME"].ToString().ToLower().Contains(txbSearch.Text.ToLower()))
                    continue;
                if (!cbForward.Checked && tmpFootballer["FB_ROLE"].ToString() == "Forward")
                    continue;
                if (!cbMidfielder.Checked && tmpFootballer["FB_ROLE"].ToString() == "Midfielder")
                    continue;
                if (!cbDefender.Checked && tmpFootballer["FB_ROLE"].ToString() == "Defender")
                    continue;
                if (!cbGoalkeeper.Checked && tmpFootballer["FB_ROLE"].ToString() == "Goalkeeper")
                    continue;
                if (!cbTrainer.Checked && tmpFootballer["FB_ROLE"].ToString() == "Trainer")
                    continue;
                string[] countrys = { "Argentina", "France", "Brazil", "Qatar", "Japan", "South Korea", "Germany", "Croatia" };
                if (cbbCountry.Text == countrys[Int32.Parse(tmpFootballer["FB_IDTEAM"].ToString()) - 1] || cbbCountry.Text == "All")
                    flpFootballerCards.Controls.Add(footballerCard);
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            renderFootballerCardList(FootballerCardList);
        }

        private void cbCheck_Changed(object sender, EventArgs e)
        {
            renderFootballerCardList(FootballerCardList);
        }

        private void cbbOrder_TextChanged(object sender, EventArgs e)
        {
            reOrder();
            renderFootballerCardList(FootballerCardList);
        }

        private void reOrder()
        {
            if (cbbOrder.Text == "A-Z")
            {
                for (int i = 0; i < FootballerCardList.Count; i++)
                {
                    for (int j = i + 1; j < FootballerCardList.Count; j++)
                    {
                        DataRow tmp1 = (DataRow)FootballerCardList[i].Tag;
                        DataRow tmp2 = (DataRow)FootballerCardList[j].Tag;
                        if (String.Compare(tmp1["FB_NAME"].ToString(), tmp2["FB_NAME"].ToString()) > 0)
                        {
                            FootballerCard tmp = FootballerCardList[i];
                            FootballerCardList[i] = FootballerCardList[j];
                            FootballerCardList[j] = tmp;
                        }
                    }
                }
            }
            else if (cbbOrder.Text == "Z-A")
            {
                for (int i = 0; i < FootballerCardList.Count; i++)
                {
                    for (int j = i + 1; j < FootballerCardList.Count; j++)
                    {
                        DataRow tmp1 = (DataRow)FootballerCardList[i].Tag;
                        DataRow tmp2 = (DataRow)FootballerCardList[j].Tag;
                        if (String.Compare(tmp1["FB_NAME"].ToString(), tmp2["FB_NAME"].ToString()) <= 0)
                        {
                            FootballerCard tmp = FootballerCardList[i];
                            FootballerCardList[i] = FootballerCardList[j];
                            FootballerCardList[j] = tmp;
                        }
                    }
                }
            }
            else if (cbbOrder.Text == "Goal Increase")
            {
                for (int i = 0; i < FootballerCardList.Count; i++)
                {
                    for (int j = i + 1; j < FootballerCardList.Count; j++)
                    {
                        DataRow tmp1 = (DataRow)FootballerCardList[i].Tag;
                        DataRow tmp2 = (DataRow)FootballerCardList[j].Tag;
                        if (Int32.Parse(tmp1["FB_SCORE"].ToString()) > Int32.Parse(tmp2["FB_SCORE"].ToString()))
                        {
                            FootballerCard tmp = FootballerCardList[i];
                            FootballerCardList[i] = FootballerCardList[j];
                            FootballerCardList[j] = tmp;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < FootballerCardList.Count; i++)
                {
                    for (int j = i + 1; j < FootballerCardList.Count; j++)
                    {
                        DataRow tmp1 = (DataRow)FootballerCardList[i].Tag;
                        DataRow tmp2 = (DataRow)FootballerCardList[j].Tag;
                        if (Int32.Parse(tmp1["FB_SCORE"].ToString()) < Int32.Parse(tmp2["FB_SCORE"].ToString()))
                        {
                            FootballerCard tmp = FootballerCardList[i];
                            FootballerCardList[i] = FootballerCardList[j];
                            FootballerCardList[j] = tmp;
                        }
                    }
                }
            }
        }
    }
}

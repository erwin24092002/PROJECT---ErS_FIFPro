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
                flpFootballerCards.Controls.Add(footballerCard);
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            renderFootballerCardList(FootballerCardList);
        }
    }
}

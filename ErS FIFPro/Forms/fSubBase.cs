using ErS_FIFPro.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErS_FIFPro.Forms
{
    public partial class fSubBase : Form
    {
        private int base_idx;
        private int idteam;
        private DataTable Footballers;
        private List<FootballerBase> FootballerBases;

        public fSubBase(int match_idx, int idteam)
        {
            InitializeComponent();

            this.base_idx = match_idx;
            this.idteam = idteam;

            Footballers = getFootballers();
            FootballerBases = genFootballerBases(Footballers);
            renderFootballerBases();
            check_Base();
        }

        private DataTable getFootballers()
        {
            string connectionSTR = @"Data Source=DESKTOP-8QQ3O75\ERWIN;Initial Catalog=FIFPro;Integrated Security=True";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                string query = "SELECT * FROM FOOTBALLER WHERE FB_IDTEAM='" + idteam + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        private List<FootballerBase> genFootballerBases(DataTable Footballers)
        {
            List<FootballerBase> list = new List<FootballerBase>();
            int id = 0;
            foreach (DataRow row in Footballers.Rows)
            {
                IContainer container = new Container();
                list.Add(new FootballerBase(container, row));
                id++;
            }
            return list;
        }
        private void renderFootballerBases()
        {
            foreach (FootballerBase item in FootballerBases)
            {
                item.BringToFront();
                item.Location = new Point(100, 100);
                item.Visible = false;
                this.Controls.Add(item);
            }
        }
        private void check_Base()
        {
            string filePath = "Bases/" + base_idx.ToString() + "_" + idteam.ToString() + ".txt";
            if (File.Exists(filePath))
            {
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();
                foreach (string line in lines)
                {
                    string[] infos = line.Split(' ');
                    int id = Int32.Parse(infos[0]);
                    int X = Int32.Parse(infos[1]);
                    int Y = Int32.Parse(infos[2]);
                    FootballerBases[id - 1].Location = new Point(X, Y);
                    FootballerBases[id - 1].Visible = true;
                }
            }

        }
    }
}

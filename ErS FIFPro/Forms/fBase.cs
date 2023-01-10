using ErS_FIFPro.User_Controls;
using FontAwesome.Sharp;
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
    public partial class fBase : Form
    {
        private int base_idx;
        private int idteam;
        private DataTable Footballers;
        private List<CheckBox> FootballerCheckboxs;
        private List<FootballerBase> FootballerBases;
        public fBase(int base_idx, int idteam)
        {
            InitializeComponent();

            this.base_idx = base_idx;
            this.idteam = idteam;
            Footballers = getFootballers();
            FootballerCheckboxs = genFootballerCheckboxs(Footballers);
            FootballerBases = genFootballerBases(Footballers);
            renderFootballerCheckboxs();
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

        private List<CheckBox> genFootballerCheckboxs(DataTable Footballers)
        {
            List<CheckBox> list = new List<CheckBox>();
            int id = 0;
            foreach (DataRow row in Footballers.Rows)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = row["FB_INDEX"].ToString() + " " + row["FB_NAME"].ToString();
                checkBox.Tag = id;
                checkBox.Size = new Size(290, 25);
                checkBox.Margin = new Padding(10, 2, 2, 2);
                checkBox.CheckedChanged += cbCheck_Changed;
                list.Add(checkBox);
                id++;
            }
            return list;
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
        private void renderFootballerCheckboxs()
        {
            foreach (CheckBox checkBox in FootballerCheckboxs)
            {
                flpFootballers.Controls.Add(checkBox);
            }
        }
        private void renderFootballerBases()
        {
            foreach (FootballerBase item in FootballerBases)
            {
                item.BringToFront();
                item.Location = new Point(100, 100);
                item.Visible = false;
                pBase.Controls.Add(item);
                item.BringToFront();
            }
        }
        private void cbCheck_Changed(object sender, EventArgs e)
        {
            int id = Int32.Parse(((CheckBox)sender).Tag.ToString());
            if (((CheckBox)sender).Checked)
                FootballerBases[id].Visible = true;
            else
                FootballerBases[id].Visible = false;
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
                    FootballerCheckboxs[id - 1].Checked = true;
                    FootballerBases[id-1].Location = new Point(X, Y);
                }
            }
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string filePath = "Bases/" + base_idx.ToString() + "_" + idteam.ToString() + ".txt";
            List<string> lines = new List<string>();
            for (int i = 0; i < 27; i ++)
            {
                if (FootballerCheckboxs[i].Checked)
                {
                    string tmp = Footballers.Rows[i]["FB_ID"].ToString() + " " + FootballerBases[i].Location.X + " " + FootballerBases[i].Location.Y;
                    lines.Add(tmp);
                }
            }
            File.WriteAllLines(filePath, lines);
            MessageBox.Show("Save this base successfully!");
            this.Close();
        }
    }
}

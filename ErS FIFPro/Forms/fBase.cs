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
    }
}

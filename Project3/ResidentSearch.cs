using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project3
{
    public partial class ResidentSearch : Form
    {

        SqlConnection db = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_Residents;Integrated Security=True");

        public ResidentSearch()
        {
            InitializeComponent();
        }

        private void dataShow_Resident_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int myIndex = e.RowIndex;
            DataGridViewRow row = dataShow_Resident.Rows[myIndex];
        }

        private void ResidentSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_ResidentsDataSet1.Resident' table. You can move, or remove it, as needed.
            this.residentTableAdapter1.Fill(this.db_ResidentsDataSet1.Resident);
            // TODO: This line of code loads data into the 'db_ResidentsDataSet.Resident' table. You can move, or remove it, as needed.
            //this.residentTableAdapter.Fill(this.db_ResidentsDataSet.Resident);

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Project3Gui login = new Project3Gui();
            this.Hide();
            login.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            SelectionTab select = new SelectionTab();
            this.Hide();
            select.Show();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            db.Open();
            string search = txt_Search.Text;
            SqlCommand sqcmd = new SqlCommand("Select * from [Resident] where FirstName Like '%" + search + "%' OR LastName Like '%" + search + "%' OR ResID Like '%" + search + "%'", db);
            SqlDataAdapter da = new SqlDataAdapter(sqcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            db.Close();
        }
    }
}

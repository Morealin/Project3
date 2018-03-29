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
        public ResidentSearch()
        {
            InitializeComponent();
        }

        SqlConnection db = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_Residents;Integrated Security=True");

        private void btn_Logout5_Click(object sender, EventArgs e)
        {
            Project3Gui login = new Project3Gui();
            this.Hide();
            login.Show();
        }

        private void btn_Back5_Click(object sender, EventArgs e)
        {
            SelectionTab select = new SelectionTab();
            this.Hide();
            select.Show();
        }

        private void dataShow_Resident_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int myIndex = e.RowIndex;
            DataGridViewRow row = dataShow_Residents.Rows[myIndex];
            string reg = row.Cells[0].Value.ToString();
            string value1 = row.Cells[1].Value.ToString();
            string value2 = row.Cells[2].Value.ToString();
            string value3 = row.Cells[3].Value.ToString();
        }
    }
}

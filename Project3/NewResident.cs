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
    public partial class NewResident : Form
    {

        SqlConnection db = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_Residents;Integrated Security=True");

        public NewResident()
        {
            InitializeComponent();
        }

        private void btn_Logout2_Click(object sender, EventArgs e)
        {
            Project3Gui login = new Project3Gui();
            this.Close();
            login.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            SelectionTab select = new SelectionTab();
            this.Close();
            select.Show();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SqlCommand sqcmd = new SqlCommand();

        }
    }
}

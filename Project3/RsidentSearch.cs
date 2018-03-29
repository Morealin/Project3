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
    public partial class RsidentSearch : Form
    {

        SqlConnection db = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_Residents;Integrated Security=True");

        public RsidentSearch()
        {
            InitializeComponent();
        }

        private void btn_Logout4_Click(object sender, EventArgs e)
        {
            Project3Gui login = new Project3Gui();
            this.Hide();
            login.Show();
        }

        private void btn_Back4_Click(object sender, EventArgs e)
        {
            SelectionTab select = new SelectionTab();
            this.Hide();
            select.Show();
        }
    }
}

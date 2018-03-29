using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class SelectionTab : Form
    {
        public SelectionTab()
        {
            InitializeComponent();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Project3Gui login = new Project3Gui();
            this.Hide();
            login.Show();
        }

        private void btn_NewRes_Click(object sender, EventArgs e)
        {
            NewResident newRes = new NewResident();
            this.Hide();
            newRes.Show();
        }

        private void btn_ShowRes_Click(object sender, EventArgs e)
        {
            ResidentSearch res = new ResidentSearch();
            this.Hide();
            res.Show();
        }
    }
}

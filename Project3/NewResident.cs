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
            this.Hide();
            login.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            SelectionTab select = new SelectionTab();
            this.Hide();
            select.Show();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SqlCommand sqcmd = new SqlCommand("Select * from [Resident] where ResID='" + txt_ResID+"'", db);
            SqlDataAdapter da = new SqlDataAdapter(sqcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                db.Close();
                MessageBox.Show("Resident ID already exists");
            }
            else
            {
                SqlCommand cmd = db.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Resident] (ResID, FirstName,LastName,ResType) values('" + txt_ResID.Text + "','" + txt_FName.Text + "','" + txt_LName.Text + "','" + drop_ResType.Text + "')";
                cmd.ExecuteNonQuery();
                db.Close();
                txt_ResID.Text = "";
                txt_FName.Text = "";
                txt_LName.Text = "";
                MessageBox.Show("Data Inserted");
            }
        }
    }
}

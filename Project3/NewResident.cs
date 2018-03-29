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
            db.Open();
            string fee;
            string room = drop_Floor.SelectedItem.ToString() + comboBox1.SelectedItem.ToString();
            if (drop_ResType.SelectedItem.ToString() == "Student Worker")
            {
                fee = "1245";
            }
            else if (drop_ResType.SelectedItem.ToString() == "Student Athlete")
            {
                fee = "1200";
            }
            else
            {
                fee = "100";
            }
            SqlCommand sqcmd = new SqlCommand("Select * from [Resident] where ResID='" + txt_ResID.Text +"'", db);
            SqlCommand cmd = db.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Resident] (ResID, FirstName,LastName,ResType,FloorNum,RoomNum,Rent) values('" + txt_ResID.Text + "','" + txt_FName.Text + "','" + txt_LName.Text + "','" + drop_ResType.Text + "','" + drop_Floor + "','" + room + "','" + fee + "')";
            cmd.ExecuteNonQuery();
            db.Close();
            txt_ResID.Text = "";
            txt_FName.Text = "";
            txt_LName.Text = "";
            MessageBox.Show("Data Inserted");
            
        }

        private void drop_ResType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string resType= "";
            if (resType != drop_ResType.SelectedItem.ToString())
            {
                resType = drop_ResType.SelectedItem.ToString();
            }
        }

        private void drop_Floor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FloorNum = "";
            if (FloorNum != drop_Floor.SelectedItem.ToString())
            {
                FloorNum = drop_Floor.SelectedItem.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string RoomNum = "";
            if (RoomNum != comboBox1.SelectedItem.ToString())
            {
                RoomNum = comboBox1.SelectedItem.ToString();
            }
        }
    }
}

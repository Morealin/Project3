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
    public partial class Project3Gui : Form
    {
        
        public Project3Gui()
        {
            InitializeComponent();
        }

        private void Project3Gui_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string pass, user;
            user = UsernameBox.Text;
            pass = PassBox.Text;
            if (user.ToLower() == "username" && pass.ToLower() == "password")
            {
                ErrorLabel.Text = "Correct";
                ErrorLabel.Visible = true;
            }
            else
            {
                ErrorLabel.Text = "Username or Password is Incorrect.";
                ErrorLabel.Visible = true;
            }
        }
    }
}

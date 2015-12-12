using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airline_Registration.Business;
using Airline_Registration.Casses;

namespace Airline_Registration
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BA_Login LoginBA = new BA_Login();
            User user = new User();

            user=LoginBA.GetUser(txtUsername.Text,txtPassword.Text);

            if (user == null)
            {
                statusStrip1.Text = "The username or password is not correct.please try again.";
            }
            else
            {
                frmMainWindow frmMainwindow = new frmMainWindow(user.AccessPoint);
                this.Hide();
                frmMainwindow.Show();
            }
        }
    }
}

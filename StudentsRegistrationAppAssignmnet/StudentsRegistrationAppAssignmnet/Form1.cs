using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsRegistrationAppAssignmnet
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        internal List<Person> persons = new List<Person>();
        public int count = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

            Addministrator admin =new Addministrator();
            admin.AddAdmin("Samira", "Mansouri", "s", "1");
            persons.Add(admin);
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
           
            string pass = txtPassword.Text;
            string username = txtUsername.Text;
            bool flag = false;

                foreach (Person person in persons)
                {
               
                    if (person is Addministrator)
                    {
                        Addministrator admin = (Addministrator)person;
                        if (admin.Username == username && admin.Password == pass)
                        {
                            frmStudentInfo frmstInf = new frmStudentInfo(persons);
                            this.Hide();
                            frmstInf.Show();
                        flag = true;
                            break;
                        }
                    }
            }
            if (flag!=true)
            {
                count++;
            }
            if (count == 3)
            {

                MessageBox.Show("You have done your three attemos");
                this.Close();
            }

        }
    }
}

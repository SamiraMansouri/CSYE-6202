using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfStudentsRegistrationApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        internal List<Person> persons = new List<Person>();
        public int count = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

            Addministrator admin = new Addministrator();
            admin.AddAdmin("Samira", "Mansouri", "s", "1");
            persons.Add(admin);

        }
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

            string pass = txtPassword.Password;
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
            if (flag != true)
            {
                count++;  
            }
            if (count == 3)
            {

                MessageBox.Show("You have done your three attemos");
                this.Close();
            }

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Addministrator admin = new Addministrator();
            admin.AddAdmin("Samira", "Mansouri", "s", "1");
            persons.Add(admin);
        }


    }
}

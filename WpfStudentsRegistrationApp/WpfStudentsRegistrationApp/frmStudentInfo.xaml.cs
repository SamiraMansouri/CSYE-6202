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
using System.Windows.Shapes;

namespace WpfStudentsRegistrationApp
{
    /// <summary>
    /// Interaction logic for frmStudentInfo.xaml
    /// </summary>
     partial class frmStudentInfo : Window
    {
        internal frmStudentInfo(List<Person> persons)
        {
            InitializeComponent();
            this.persons = persons;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        internal List<Person> persons;
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            cmbDepartment.Items.Add("");
            cmbDepartment.Items.Add("Information Systems");
            cmbDepartment.Items.Add("International Affairs");
            cmbDepartment.Items.Add("Nursing");
            cmbDepartment.Items.Add("Pharmacy");
            cmbDepartment.Items.Add("Professional Studies");
            cmbDepartment.Items.Add("Psychology");
            cmbDepartment.Items.Add("Public Aministration");
            for (int i = 0; i < 10; i++)
            {
                ADDTEMOPORRAYSTUDENT(i);
            }
            initializeGreedView();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            {
                try
                {
                    if (dataGrid.SelectedItem != null)
                    {
                        if (dataGrid.SelectedItem is Student)
                        {
                            var row = (Student)dataGrid.SelectedItem;

                            if (row != null)
                            {

                                txtStudentID.Text = row.StudentID;
                                txtFirstName.Text = row.FirstName;
                                txtLastName.Text = row.LastName;
                                cmbDepartment.Text = row.Department;
                                string enrollmentType = row.EnrollmentPay;
                                if (enrollmentType == "Part Time")
                                {
                                    rbPartTime.IsChecked = true;
                                }
                                else
                                {
                                    rbFullTime.IsChecked = true;


                                }

                            }
                        }
                    }
                }
                catch (Exception)
                {
                }

            }
        }

        public void initializeGreedView()
        {

            List<Student> temp = new List<Student>();
            foreach (Person person in persons)
            {
                if (person is Student)
                {
                    temp.Add((Student)person);
                }
            }
            dataGrid.ItemsSource = temp;
        }

        public void ADDTEMOPORRAYSTUDENT(int i)
        {
            Student st = new Student();
            bool flag = true;
            while (flag)
            {
                System.Threading.Thread.Sleep(50);
                try
                {
                    st = NewStudent.GenerateStudentRandomly(i);
                    flag = false;
                }
                catch (Exception e)
                {
                    flag = true;
                }
            }

            persons.Add(st);

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            frmAddStudent frmAddst = new frmAddStudent();
            frmAddst.frmstudentinfo = this;
            this.Hide();
            frmAddst.Show();


        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (dataGrid.SelectedItem != null)
                {
                    if (dataGrid.SelectedItem is Student)
                    {
                        var row = (Student)dataGrid.SelectedItem;

                        if (row != null)
                        {

                            int index = 0;
                            Student st = null;

                            foreach (Person person in persons)
                            {

                                if (person is Student)
                                {
                                    st = (Student)person;
                                    if (st.StudentID == row.StudentID)
                                    {
                                        index = persons.IndexOf(person);
                                        break;
                                    }
                                }
                            }
                        

                        frmEditStudent frmAddst = new frmEditStudent(st, index);
                        frmAddst.frmstudentinfo = this;
                        this.Hide();
                        frmAddst.Show();
                    }
                    }
                }
            }
            catch (Exception)
            {
            }
            
        }
        
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            
                try
                {
                    if (dataGrid.SelectedItem != null)
                    {
                        if (dataGrid.SelectedItem is Student)
                        {
                            var row = (Student)dataGrid.SelectedItem;

                            if (row != null)
                            {

                                int index = 0;
                                Student st = null;

                                foreach (Person person in persons)
                                {

                                    if (person is Student)
                                    {
                                        st = (Student)person;
                                        if (st.StudentID == row.StudentID)
                                        {
                                            index = persons.IndexOf(person);
                                            break;
                                        }
                                    }
                                }


                                frmRemoveStudent frmAddst = new frmRemoveStudent(st, index);
                                frmAddst.frmstudentinfo = this;
                                this.Hide();
                                frmAddst.Show();

                            }
                        }
                    }
                }
                catch (Exception)
                {
                }

            
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
        }
    }
}

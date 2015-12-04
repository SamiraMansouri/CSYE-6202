using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for frmAddStudent.xaml
    /// </summary>
    public partial class frmAddStudent : Window
    {
        internal frmStudentInfo frmstudentinfo;


        public frmAddStudent()
        {

            InitializeComponent();
        }
        
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
            btnAdd.IsEnabled = false;
            btnReset.IsEnabled = false;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            if (IsStudentIDOk(txtStudentID.Text))
            {
                if (txtFirstName.Text.Trim() != "" && txtLastName.Text.Trim() != "" &&
                     txtStudentID.Text.Trim() != "" && cmbDepartment.SelectedIndex > 0)
                {
                    string enrollmentType;
                    if (rbFullTime.IsChecked == true)
                    {
                        enrollmentType = "Full Time";
                    }
                    else
                    {
                        enrollmentType = "Part Time";

                    }
                    Student st = new Student();
                    st.AddStudent(txtFirstName.Text, txtLastName.Text, txtStudentID.Text, cmbDepartment.SelectedItem.ToString(), enrollmentType);
                    frmstudentinfo.persons.Add(st);
                    this.Hide();
                    frmstudentinfo.initializeGreedView();
                    frmstudentinfo.Show();

                }
                else
                {
                    MessageBox.Show("Please Fill all the information is provided");
                }
            }
            else
            {
                MessageBox.Show("the student ID should be in xxx-xx-xxxx pattern");
            }
        }

        public bool IsStudentIDOk(string ID)
        {
            bool isvalid = false;
            Regex rgx = new Regex(@"^\d{3}-\d{2}-\d{4}$");
            isvalid=  rgx.IsMatch(ID) ? true : false;

            return isvalid;
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStudentID.Text = "";
            cmbDepartment.SelectedIndex = 0;
            rbFullTime.IsChecked = true;
            btnReset.IsEnabled = false;
            btnAdd.IsEnabled = false;
        }

        private void EnableResetButton(object sender, TextChangedEventArgs e)
        {
            btnReset.IsEnabled = true;
            btnAdd.IsEnabled = true;
            //int x = cmbDepartment.SelectedIndex;
            //if (txtFirstName.Text.Trim() != "" && txtLastName.Text.Trim() != "" &&
            //     txtStudentID.Text.Trim() != "" && cmbDepartment.SelectedIndex != -1)
            //{
            //    btnAdd.IsEnabled = true;
            //}
        }

        private void EnableResetButton(object sender, RoutedEventArgs e)
        {
            btnReset.IsEnabled = true;
            int x = cmbDepartment.SelectedIndex;
            if (txtFirstName.Text.Trim() != "" && txtLastName.Text.Trim() != "" &&
                 txtStudentID.Text.Trim() != "" && cmbDepartment.SelectedIndex != -1)
            {
                btnAdd.IsEnabled = true;
            }
        }
    }
}

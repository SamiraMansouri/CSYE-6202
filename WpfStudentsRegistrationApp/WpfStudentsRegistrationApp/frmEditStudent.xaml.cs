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
    /// Interaction logic for frmEditStudent.xaml
    /// </summary>
    public partial class frmEditStudent : Window
    {
        internal frmStudentInfo frmstudentinfo;
        Student student;
        int index = 0;

        internal frmEditStudent(Student st, int index)
        {
            this.student = st;
            this.index = index;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            frmstudentinfo.Show();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (IsStudentIDOk(txtStudentID.Text))
            {
                MessageBoxResult dialogResult = MessageBox.Show("Are you sure you want to edit this student?", "Edit Student Registration Confirmation", MessageBoxButton.YesNo);
                if (dialogResult == MessageBoxResult.Yes)
                {
                    UdateStudentsList();
                    this.Close();
                    frmstudentinfo.Show();
                }
                else if (dialogResult == MessageBoxResult.No)
                {
                    this.Close();
                    frmstudentinfo.Show();
                }
            }
            else
            {
                MessageBox.Show("the student ID should be in xxx-xx-xxxx pattern");
            }
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

            
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtStudentID.Text = student.StudentID;
            cmbDepartment.Items.Add(student.Department);
            cmbDepartment.SelectedValue = student.Department;
            string enrollmentType = student.EnrollmentPay;
            if (enrollmentType.ToLower().Trim() == "Part Time")
            {
                rbPartTime.IsChecked = true;
            }
            else
            {
                rbFullTime.IsChecked = true;
            }
        }

        public bool IsStudentIDOk(string ID)
        {
            bool isvalid = false;
            Regex rgx = new Regex(@"^\d{3}-\d{2}-\d{4}$");
            isvalid = rgx.IsMatch(ID) ? true : false;

            return isvalid;
        }

        internal void UdateStudentsList()
        {

            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.StudentID = txtStudentID.Text;
            student.Department = cmbDepartment.Text;
            string enrollmentType;
            if (rbFullTime.IsChecked==true)
            {
                enrollmentType = "Full Time";
            }
            else
            {
                enrollmentType = "Part Time";

            }
            student.EnrollmentPay = enrollmentType;
            frmstudentinfo.persons[index] = student;

        }
    }
}

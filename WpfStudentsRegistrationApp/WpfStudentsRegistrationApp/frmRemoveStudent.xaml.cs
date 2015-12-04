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
    /// Interaction logic for frmRemoveStudent.xaml
    /// </summary>
    public partial class frmRemoveStudent : Window
    {
        internal frmStudentInfo frmstudentinfo;
        Student student;
        int index = 0;

        internal frmRemoveStudent(Student st, int index)
        {
            student = st;
            this.index = index;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            frmstudentinfo.initializeGreedView();
            frmstudentinfo.Show();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult dialogResult = MessageBox.Show("Are you sure you want to delete this student?", "Remove Student Registration Confirmation", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                frmstudentinfo.persons.RemoveAt(index);
                this.Close();
                frmstudentinfo.initializeGreedView();
                frmstudentinfo.Show();
            }
            else if (dialogResult == MessageBoxResult.No)
            {
                this.Close();
                frmstudentinfo.initializeGreedView();
                frmstudentinfo.Show();
            }
        }
        
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtStudentID.Text = student.StudentID;
            cmbDepartment.Items.Add( student.Department);
            cmbDepartment.SelectedIndex = 0;
            string enrollmentType = student.EnrollmentPay;
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

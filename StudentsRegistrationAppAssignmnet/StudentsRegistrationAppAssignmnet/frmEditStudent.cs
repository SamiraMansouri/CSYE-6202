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
    public partial class frmEditStudent : Form
    {
        internal frmStudentInfo frmstudentinfo;
        Student student;
        int index = 0;

        internal frmEditStudent(Student st,int index)
        {
            this.student = st;
            this.index = index;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmstudentinfo.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to edit this student?", "Edit Student Registration Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UdateStudentsList();
                this.Close();
                frmstudentinfo.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
                frmstudentinfo.Show();
            }
        }

        private void frmEditStudent_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtStudentID.Text = student.StudentID;
            cmbDepartment.Text = student.Department;
            string enrollmentType = student.EnrollmentPay;
            if (enrollmentType.ToLower().Trim() == "parttime")
            {
                rbPartTime.Checked = true;
            }
            else
            {
                rbFullTime.Checked = true;
            }
        }

        internal  void UdateStudentsList()
        {
            
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.StudentID = txtStudentID.Text;
            student.Department = cmbDepartment.Text;
            string enrollmentType;
            if (rbFullTime.Checked)
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

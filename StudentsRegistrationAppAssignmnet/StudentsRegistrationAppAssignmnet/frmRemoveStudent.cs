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


    public partial class frmRemoveStudent : Form
    {
        internal frmStudentInfo frmstudentinfo;
        Student student;
        int index=0;

        internal frmRemoveStudent(Student st,int index)
        {
            student = st;
            this.index = index;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmstudentinfo.initializeGreedView();
            frmstudentinfo.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult= MessageBox.Show("Are you sure you want to delete this student?", "Remove Student Registration Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmstudentinfo.persons.RemoveAt(index);
                this.Close();
                frmstudentinfo.initializeGreedView();
                frmstudentinfo.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
                frmstudentinfo.initializeGreedView();
                frmstudentinfo.Show();
            }
        }

        private void frmRemoveStudent_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtStudentID.Text = student.StudentID;
            cmbDepartment.Text = student.Department;
            string enrollmentType = student.EnrollmentPay;
            if (enrollmentType.ToLower().Trim() == "parttime")
            {
                rblPartTime.Checked = true;
            }
            else
            {
                rbFullTime.Checked = true;
            }
        }
    }
}

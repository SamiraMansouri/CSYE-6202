using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsRegistrationAppAssignmnet
{
    public partial class frmAddStudent : Form
    {

        internal frmStudentInfo frmstudentinfo;
        

        public frmAddStudent()
        {

            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStudentID.Text = "";
            cmbDepartment.SelectedIndex = 0;
            rbFullTime.Checked = true;
            btnAdd.Enabled = false;
        }

        private void EnableResetButton(object sender, EventArgs e)
        {
            btnReset.Enabled = true;
            btnAdd.Enabled = true;
            //int x = cmbDepartment.SelectedIndex;
            //if (txtFirstName.Text.Trim() != "" && txtLastName.Text.Trim() != "" &&
            //     txtStudentID.Text.Trim() != "" && cmbDepartment.SelectedIndex != -1)
            //{
            //    btnAdd.Enabled = true;
            //}
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnReset.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (IsStudentIDOk(txtStudentID.Text))
            {
                if (txtFirstName.Text.Trim() != "" && txtLastName.Text.Trim() != "" &&
                     txtStudentID.Text.Trim() != "" && cmbDepartment.SelectedIndex > 0)
                {
                    string enrollmentType;
                    if (rbFullTime.Checked == true)
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
            isvalid = rgx.IsMatch(ID) ? true : false;

            return isvalid;
        }
    }
}

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
    internal partial class frmStudentInfo : Form
    {
        public frmStudentInfo(List <Person> persons)
        {
            InitializeComponent();
            this.persons = persons;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        public List <Person> persons ;

        private void frmStudentInfo_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                ADDTEMOPORRAYSTUDENT(i);
            }
            initializeGreedView();

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
            dataGridView1.DataSource = temp;
        }
        public void ADDTEMOPORRAYSTUDENT(int i)
        {
            Student st = new Student();
            bool flag =true;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtStudentID.Text= row.Cells[0].Value.ToString();
                txtFirstName.Text = row.Cells[3].Value.ToString();
                txtLastName.Text = row.Cells[4].Value.ToString();
                cmbDepartment.Text= row.Cells[1].Value.ToString();
                string enrollmentType= row.Cells[2].Value.ToString();
                if (enrollmentType.ToLower().Trim()=="parttime")
                {
                    rbPartTime.Checked = true;
                }
                else
                {
                    rbFullTime.Checked = true;

                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddStudent frmAddst = new frmAddStudent();
            frmAddst.frmstudentinfo = this;
            this.Hide();
            frmAddst.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int index = 0;
            Student st=null;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                foreach (Person person in persons)
                {
                   
                    if (person is Student)
                    {
                        st = (Student)person;
                        if (st.StudentID == row.Cells[0].Value.ToString())
                        {
                            index = persons.IndexOf(person);
                            break;
                        }
                    }
                }
            }
            
            frmRemoveStudent frmAddst = new frmRemoveStudent(st,index);
            frmAddst.frmstudentinfo = this;
            this.Hide();
            frmAddst.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = 0;
            Student st = null;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                foreach (Person person in persons)
                {

                    if (person is Student)
                    {
                        st = (Student)person;
                        if (st.StudentID == row.Cells[0].Value.ToString())
                        {
                            index = persons.IndexOf(person);
                            break;
                        }
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

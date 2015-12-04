using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStudentsRegistrationApp
{
    class Student : Person
    {
        public string StudentID { get; set; }
        public string Department { get; set; }
        public string EnrollmentPay { get; set; }

        public Student() { }

        public Student(string fNAme, string LName, string ID, string department, string enrollmentPay)
        {
            FirstName = fNAme;
            LastName = LName;
            StudentID = ID;
            Department = department;
            EnrollmentPay = enrollmentPay;
        }

        public void AddStudent(string fNAme, string LName, string ID, string department, string enrollmentPay)
        {
            FirstName = fNAme;
            LastName = LName;
            StudentID = ID;
            Department = department;
            EnrollmentPay = enrollmentPay;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsRegistrationAppAssignmnet
{
    class NewStudent : Student
    {
        public static Student GenerateStudentRandomly(int i)
        {
            Student student = new Student();


            //Generate FirstName
            Random r = new Random();
            int FNameLength = r.Next(3, 12);
            student.FirstName = RandomString(FNameLength);

            //Generate LastNAme
            Random LNameRandom = new Random();
            int LNameLength = LNameRandom.Next(6, 20);
            student.LastName = RandomString(LNameLength);

            //Generate ID
            Random IDRAndom = new Random();
            int ID = IDRAndom.Next(100000010, 999999999);
            
            string StudentID = ID.ToString();
            StudentID.Insert(3, "-");
            StudentID=StudentID.Insert(3, "-");
            StudentID=StudentID.Insert(6, "-");
            student.StudentID = StudentID;

            //Generate Department
            Random DepartmentRandom = new Random();
            string[] Departments =  { "Information Systems","International Affairs","Nursing","Pharmacy",
                                       "Professional Studies","Psychology","Public Administration"};
            int DepartmentRandomIndex = DepartmentRandom.Next(0, 6);
            student.Department = Departments[DepartmentRandomIndex];

            //Generate EnrollmentPay
            Random EnrollmentPayRandom = new Random();
            string[] EnrollmentPAy = { "Full Time", "Part Time" };
            int EnrollmentPAyRandomIndex = EnrollmentPayRandom.Next(0, 1);
            student.EnrollmentPay = EnrollmentPAy[DepartmentRandomIndex];

            return student;
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

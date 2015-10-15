using System;
namespace HealthRecordApp
{
	public enum Gender
	{
		Unspecified,
		Male,
		Female
	}
    
	public class HealthProfile
	{

		private const int UnknownValue = -1;

        private string firstName ;
        private string lastName ;
        private Gender patientsGender = new Gender();
        private DateTime patientsDateofBirt = new DateTime();
        private int patientsHeight =0;
        private int patientsWeight = 0;

        #region Methods

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }

        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Gender Gender
        {
            get { return patientsGender; }
            set { patientsGender = value; }
        }

        public DateTime DOB
        {
            get { return patientsDateofBirt; }
            set { patientsDateofBirt = value; }
        }

        public int HeightInInches
        {
            get { return patientsHeight; }
            set { patientsHeight = value; }
        }

        public int WeightInPounds
        {
            get { return patientsWeight; }
            set { patientsWeight = value; }
        }

        public int CalculateAge()
		{
            int Age = DateTime.Today.Year - DOB.Year;
            return Age;
		}

		public int CalculateMaxHeartRate()
		{
			int Age = DateTime.Today.Year - DOB.Year;
            int Max = 220 - Age;
            return Max;
        }

		public decimal CalculateBMI()
		{
            decimal BMI;
            BMI =Convert.ToDecimal (WeightInPounds * 703.00m) / Convert.ToDecimal(HeightInInches * HeightInInches);
            BMI = Math.Round(BMI,2);
            return BMI;
		}

		public void DisplayPatientProfile()
		{
            Console.WriteLine("\n\n\n" + "Displaying Patient profile:");
            Console.WriteLine("===========================");
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Gender: " + patientsGender);
            Console.WriteLine("Date of Birth: " + DOB.ToShortDateString());
            Console.WriteLine("Height: " + patientsHeight + " inches");
            Console.WriteLine("Weight: " + patientsWeight + " pounds");
            Console.WriteLine("Age: " + CalculateAge());
            Console.WriteLine("Max: " + CalculateMaxHeartRate());
            Console.WriteLine("BMI: " + CalculateBMI());
        }

		#endregion
	}
}

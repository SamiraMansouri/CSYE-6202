namespace HealthRecordApp
{
    using System;
    using HealthRecordApp;
	class Program
	{
        static void Main(string[] args)
        {
            string firstName = string.Empty;
            string lastName = string.Empty;
            Gender patientsGender=new Gender(); 
            DateTime patientsDateofBirt = new DateTime();
            int patientsHeight = 0;
            int patientsWeight = 0;
            
            bool firstNameIsValid = false;
            while (!firstNameIsValid)
            {
                Console.Write("Please enter patient's first name: ");
                firstName = Console.ReadLine();
                firstNameIsValid = HealthRecordApp.HealthProfileHelper.ValidateFirstName(firstName);
                
            }

            bool lastNameIsValid = false;
            while (!lastNameIsValid)
            {
                Console.Write("Please enter patient's last name: ");
                lastName = Console.ReadLine();
                lastNameIsValid = HealthRecordApp.HealthProfileHelper.ValidateLastName(lastName);

            }

            bool genderIsValid = false;
            while (!genderIsValid)
            {
                string gender = string.Empty;
                Console.Write("Please enter patient's gender (Unspecified/Male/Female): ");
                gender = Console.ReadLine();
                genderIsValid = HealthRecordApp.HealthProfileHelper.ValidateGender(gender,ref patientsGender);

            }

            bool dateofBirthIsValid = false;
            while (!dateofBirthIsValid)
            {
                string dateofBirth = string.Empty;
                Console.Write("Please enter patient's date of birth: ");
                dateofBirth = Console.ReadLine();
                dateofBirthIsValid = HealthRecordApp.HealthProfileHelper.ValidateDateOfBirth(dateofBirth, ref patientsDateofBirt);

            }

            bool heightIsValid = false;
            while (!heightIsValid)
            {
                string height = string.Empty;
                Console.Write("Please enter patient's height: ");
                height = Console.ReadLine();
                heightIsValid = HealthRecordApp.HealthProfileHelper.ValidateHeight(height, ref patientsHeight);

            }

            bool weightIsValid = false;
            while (!weightIsValid)
            {
                string weight = string.Empty;
                Console.Write("Please enter patient's weight: ");
                weight = Console.ReadLine();
                weightIsValid = HealthRecordApp.HealthProfileHelper.ValidateWeight(weight, ref patientsWeight);

            }

            HealthProfile PatientHealthProfile = new HealthProfile();
            PatientHealthProfile.FirstName = firstName;
            PatientHealthProfile.LastName = lastName;
            PatientHealthProfile.Gender = patientsGender;
            PatientHealthProfile.DOB = patientsDateofBirt;
            PatientHealthProfile.WeightInPounds=patientsWeight;
            PatientHealthProfile.HeightInInches = patientsHeight;
            PatientHealthProfile.DisplayPatientProfile();
            Console.Read();
            

        }
	}
}

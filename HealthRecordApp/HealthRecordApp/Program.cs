namespace HealthRecordApp
{
    using System;
    using HealthRecordApp;
	class Program
	{
		static void Main(string[] args)
		{
            bool firstNameIsValid = false;
            while (!firstNameIsValid)
            {
                string firstName = string.Empty;
                Console.Write("Please enter patient's first name: ");
                firstName = Console.ReadLine();
                firstNameIsValid = HealthRecordApp.HealthProfileHelper.ValidateFirstName(firstName);
                
            }

            bool lastNameIsValid = false;
            while (!lastNameIsValid)
            {
                string lastName = string.Empty;
                Console.Write("Please enter patient's last name: ");
                lastName = Console.ReadLine();
                firstNameIsValid = HealthRecordApp.HealthProfileHelper.ValidateLastName(lastName);

            }
            Console.Read();
            

        }
	}
}

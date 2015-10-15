using System;

namespace HealthRecordApp
{
    
	public class HealthProfileHelper
	{
		public static bool ValidateFirstName(string firstName)
		{
            bool isValid = false;
            try
            {
                double x = Convert.ToDouble(firstName);
            }
            catch (Exception e)
            {
                if (firstName.Trim() != "")
                {
                    isValid = true;
                }
            }
            return isValid;
		}

		public static bool ValidateLastName(string lastName)
		{
            bool isValid = false;
            try
            {
                double x = Convert.ToDouble(lastName);
            }
            catch (Exception e)
            {
                if (lastName.Trim() != "")
                {
                    isValid = true;
                }
            }
            return isValid;
        }

		public static bool ValidateGender(string enteredGender, ref Gender patientGender)
		{
            if (enteredGender.ToLower().Trim()==Gender.Female.ToString().ToLower())
            {
                patientGender = Gender.Female;
                return true;
            }
            else if (enteredGender.ToLower().Trim() == Gender.Male.ToString().ToLower())
            {
                patientGender = Gender.Male;
                return true;
            }
            else if (enteredGender.ToLower().Trim() == Gender.Unspecified.ToString().ToLower())
            {
                patientGender = Gender.Unspecified ;
                return true;
            }
            else
            {
                return false;
            }
            
		}

		public static bool ValidateDateOfBirth(string enteredDOB, ref DateTime patientDOB)
		{
            bool isValid = false;
            if (DateTime.TryParse(enteredDOB,out patientDOB))
            {
                isValid = true;
            }
			return isValid;
		}

		public static bool ValidateHeight(string heightInString, ref int? patientHeight)
		{
            bool isValid = false;
            try
            {
                int x = Convert.ToInt32(heightInString);
                patientHeight = Convert.ToInt32(heightInString);
                isValid = true;
            }
            catch (Exception e)
            {
                isValid = false;
            }
            return isValid;
        }

		public static bool ValidateWeight(string weightInString, ref int? patientWeight)
		{
            bool isValid = false;
            try
            {
                int x = Convert.ToInt32(weightInString);
                patientWeight = Convert.ToInt32(weightInString);
                isValid = true;
            }
            catch (Exception e)
            {
                isValid = false;
            }
            return isValid;
        }
	}
}

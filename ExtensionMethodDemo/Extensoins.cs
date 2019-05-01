using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodDemo
{
    public static class Extensoins
    {
        /**
         To Turn The Method To an extension Method, simply there are two steps you need to follow:
            1- first of all make the class which contains the method as a static class.
            2- already you defined the method as static method but in this step you need to define the class which you need to extend as first parameter,
               and you should proceed the type name with 'this' KeyWord */
        public static string ChangeFirstLetter(this string input)
        {
            if (input.Length > 0)
            {
                char[] charArray = input.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);
            }
            return input;
        }

        /**Extension Method For int Type To calculate the age from DateTime Input as The Date Of Birth*/
        public static int CalculateAge(this DateTime DateOfBirth)
        {
            var age = DateTime.Today.Year - DateOfBirth.Year;
            if (DateOfBirth.AddYears(age) > DateTime.Today)
                age--;
            return age;
        }
    }
}

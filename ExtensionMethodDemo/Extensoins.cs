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
    }
}

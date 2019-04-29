using System;

namespace ExtensionMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Anas";
            //string result = Extensoins.ChangeFirstLetter(inputString);
            /**Extension Methods enable you to 'add' methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type*/
            /**Extension methods are a special kind of static method, but they are called as if they were instance methods on the extended type.*/
            string result = inputString.ChangeFirstLetter();
            Console.WriteLine(result);
        }
    }
}

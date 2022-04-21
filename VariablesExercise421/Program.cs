using System;

namespace VariablesExercise421
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Gus";
            int myAge = 29;
                        Console.WriteLine($"Hello, my name is {myName} & I am {myAge} years old.");

            char Letter = 'G';
            Console.WriteLine($"The 7th letter of the alphabet is {Letter}");

            bool Answer = false;
            Console.WriteLine($"Boolean means either true or {Answer}");

            double realNumber = 35.5;
            Console.WriteLine($"If you divide 71 in half, you'll get {realNumber}");

            decimal PI = 3.1415926535897932384626433832m;
            Console.WriteLine($"The decimal data type allows you to input up to 28 digits past the decimal point, here's PI for example {PI}");

            Console.WriteLine($"Thanks for reading, this gave me a better understaind of how these data types work - slowly but surely improving!!");

        }
    }
}

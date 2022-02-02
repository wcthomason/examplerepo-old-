using System;

namespace examplerepo
{
    class Program
    {
         static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double answer = 0;

            string answerStr;

            Console.WriteLine("\n\n---------------Welcome to 2 Number Multiplication!!---------------\n");
            Console.WriteLine("All I can do for you is multiply one number by a second number...");
            Console.WriteLine("Don't know how to put commas in your answer either so sorry about that...\n");
            Console.WriteLine("Have fun though! Multiply as many combinations of 2 numbers as your heart desires\n\n");

            Console.WriteLine("Enter value 1: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter value 2: ");
            num2 = double.Parse(Console.ReadLine());

            answer = num1*num2;
            answerStr = answer.ToString();

            Console.WriteLine("Answer is: " + answer);

        }
    }
}

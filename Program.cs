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

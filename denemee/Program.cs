using System;

namespace denemee
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            Console.WriteLine("Please enter first number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please select an operation (+,-,*,/)");

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine(result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("That is not a valid option!");
                    break;



            }


        }
    }
}
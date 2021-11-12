using System;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second value:");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter symbol:");
            char symbol = char.Parse(Console.ReadLine());

            int plus = number1 + number2;
            int minus = number1 - number2;
            int multiplication = number1 * number2;
            int division = number1 / number2;

            if (symbol == '+')
            {
                Console.WriteLine("Your result: "+ plus);
            }
            else if(symbol =='-')
            {
                Console.WriteLine("Your result: " + minus);
            }
            else if (symbol == '*')
            {
                Console.WriteLine("Your result: " + multiplication);
            }
            else if (symbol == '/')
            {
                Console.WriteLine("Your result: " + division);
            }
        }
    }
}

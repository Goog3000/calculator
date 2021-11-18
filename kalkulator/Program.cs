using System;

namespace kalkulator
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value:");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second value:");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter symbol:");
            char symbol = char.Parse(Console.ReadLine());

            double plus = number1 + number2;
            double minus = number1 - number2;
            double multiplication = number1 * number2;
            double division = number1 / number2;

            if (symbol == '+')
            {
                Console.WriteLine("Your result: " + plus);
            }
            else if (symbol == '-')
            {
                Console.WriteLine("Your result: " + minus);
            }
            else if (symbol == '*')
            {
                Console.WriteLine("Your result: " + multiplication);
            }
            else if (symbol == '/')
            {
                if (number2 == 0)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    Console.WriteLine("Your result: " + division);
                }
            }
        }
    }
}

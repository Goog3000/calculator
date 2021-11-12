using System;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value:");
            int number1 = int.Parse(Console.ReadLine();

            Console.WriteLine("Enter second value:");
            int number2 = int.Parse(Console.ReadLine();

            Console.WriteLine("Enter symbol:");
            int symbol = int.Parse(Console.ReadLine();

            int plus = number1 + number2;

            if (symbol == '+')
            {
                Console.WriteLine(plus);
            }
        }
    }
}

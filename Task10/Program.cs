using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine("{0}! = {1}", i, Factorial(i));
            }
            Console.ReadLine();
        }
        static double Factorial(double number)
        {
            if (number <= 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }
    }
}

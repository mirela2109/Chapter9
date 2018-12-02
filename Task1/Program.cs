using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи име: ");
            ReturnName(Console.ReadLine());
        }
        static void ReturnName(string name)
        {
            Console.WriteLine("Hello, {0}", name);
        }
    }
}

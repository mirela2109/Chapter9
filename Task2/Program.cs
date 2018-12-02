using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи първо число: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Въведи второ число: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Въведи трето число: ");
            int c = Int32.Parse(Console.ReadLine());

            GetMax(a, b);
            GetMax(a, c);

            Console.WriteLine("Най-голямото от тях е: {0}", a);
        }
        static int a;

        static void GetMax(int first, int second)
        {
            if (first > second) a = first;
            else a = second;
        }
    }
}

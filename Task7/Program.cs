using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число: ");
            string number = Console.ReadLine();

            Console.WriteLine(Reverse(number));
        }
        public static string Reverse(string number)
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

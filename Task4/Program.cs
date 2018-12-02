using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете дължина: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Въведете елемент {0}: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Въведете число: ");
            int number = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Числото{0} се повтаря {1} пъти.", number, CountNumber(number, arr));
        }
        static int CountNumber(int number, int[] arr)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length; i++) if (number == arr[i]) counter++;

            return counter;
        }
    }
}

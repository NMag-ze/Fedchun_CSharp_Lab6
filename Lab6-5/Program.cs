using System;

namespace Lab6_5
{
    class Program
    {
        static void Addition(params int[] integers)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
        }
        // передача массива
        static void AdditionMas(int[] integers, int k)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += (integers[i] * k);
            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Addition(1, 2, 3, 4, 5);

            int[] array = new int[] { 1, 2, 3, 4 };
            AdditionMas(array, 2);

            Console.ReadLine();
        }
    }
}

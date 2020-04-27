using System;

namespace Lab6_4
{
    class Program
    {
        static double Average(params int[] arr) 
        {
            double av = 0;
            foreach (int elem in arr)
                av += elem;
            return (av / arr.Length);
        }
        static void Main(string[] args)
        {
            int[] mas = new int[4];
            Console.WriteLine("Введите значения массива:");
            for (int i = 0; i < mas.Length; i++)
                mas[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Сред. значение массива: {0}", Average(mas));

            short z = 1, e = 12;
            byte v = 107;
            Console.WriteLine("Среднее значений трех переменных: {0}",Average(z, e, v));
            Console.WriteLine("Среднее значение функций без параметров: {0}",Average());
        }
    }
}

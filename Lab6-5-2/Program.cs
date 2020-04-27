using System;

namespace Lab6_5_2
{
    class Program
    {
        static void Val(params int[] mas)
        {
            Random rnd = new Random();
            Console.WriteLine("Функция с params:");
            for (int i=0;i<mas.Length;i++)
            {
                mas[i] = rnd.Next(0, 20);
                Console.Write(mas[i]+"\t");
            }
            Console.WriteLine();
        }
        static void Ref(ref int a, ref int b, ref int c, ref int d)
        {
            Random rnd = new Random();
            a = rnd.Next(0, 20); b = rnd.Next(0, 20); c = rnd.Next(0, 20); d = rnd.Next(0, 20);
            Console.WriteLine("Функция ref:\n{0}\t{1}\t{2}\t{3}\t", a, b, c, d);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int a = 5, b = 14, c = 21, d = 4;
            Console.WriteLine("Переменные:\na\tb\tc\td\t");
            Console.WriteLine("Исходные:\n{0}\t{1}\t{2}\t{3}\t",a,b,c,d);
            Val(a, b, c, d);
            Console.WriteLine("После функции с params:\n{0}\t{1}\t{2}\t{3}\t", a, b, c, d);
            Ref(ref a,ref b, ref c,ref d);
            Console.WriteLine("После функции с ref:\n{0}\t{1}\t{2}\t{3}\t", a, b, c, d);
        }
    }
}

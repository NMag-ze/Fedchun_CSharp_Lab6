using System;

namespace Lab6_5_4
{
    class Program
    {
        static void getType(params Object[] mas)
        {
            for (int i=0;i<mas.Length;i++)
            {
                Console.WriteLine("Объект: {0}", mas[i]);
                Console.WriteLine("Тип объекта: {0}", mas[i].GetType().Name);
            }
        }

        static void Main(string[] args)
        {
            Object x = 3, y = "Объект", z = true;
            getType(x, y, z);

        }
    }
}

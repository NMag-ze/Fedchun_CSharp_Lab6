using System;

namespace Lab6_3
{
    class Example
    {
        public int x, y;

        public Example()
        {

        }

        public Example(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static void Sqr(ref double a, ref double b)
        {
            a = Math.Pow(a, 2);
            b = Math.Pow(b, 2);
            Console.WriteLine("В методе Sqr\na^2 = {0}\nb^2 = {1}", a, b);

        }
        public static void Init(ref Example ex)
        {
            ex = new Example(5, 9);
            Console.WriteLine("В методе Init:\nx={0}\ny={1}", ex.x, ex.y);
            ex.x = 1;
            ex.y = 1;
            Console.WriteLine("В методе Init:\nx={0}\ny={1}", ex.x, ex.y);
        }
        public static void Zad3(double d, out int sign, out bool isInt, out double abs, out double sqr)
        {
            sign = Math.Sign(d);
            isInt = (d%1==0)?true:false;
            abs = Math.Abs(d);
            sqr = d * d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double a = 42, b = -12.67;
            double c, d;
            int i;
            bool blean;
            /*Console.WriteLine("a = {0}\nb = {1}", a, b);
            Example.Sqr(ref a, ref b);
            Example.Sqr(a * 2, b * 2);
            параметры с двойным значением
            Console.WriteLine("В функции main\na = {0}\nb = {1}", a, b);

            Example ob1 = new Example();
            Example.Init(ref ob1);

            double c;
            Example.Sqr(ref a, ref c);// Использование локальной переменной "c", которой не присвоено значение.*/
            Example.Zad3(a,out i, out blean, out c, out d);
            Console.WriteLine("Число: {0}\nЗнак: {1}\nЦелое число: {2}\nМодуль: {3}\nКвадрат числа: {4}\n",a,i,blean,c,d);
            Example.Zad3(b, out i, out blean, out c, out d);
            Console.WriteLine("Число: {0}\nЗнак: {1}\nЦелое число: {2}\nМодуль: {3}\nКвадрат числа: {4}\n", b, i, blean, c, d);

        }
    }
}

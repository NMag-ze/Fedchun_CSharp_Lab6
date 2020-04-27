using System;

namespace Lab6_1
{
    class Example
    {
        public int x,y;

        public Example()
        {

        }

        public Example(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static void Sqr(double a, double b)
        {
            a = Math.Pow(a, 2);
            b = Math.Pow(b, 2);
            Console.WriteLine("В методе Sqr\na^2 = {0}\nb^2 = {1}", a, b);

        }
        public static void Init(Example ex)
        {
            ex = new Example(5,9);
            Console.WriteLine("В методе Init:\nx={0}\ny={1}", ex.x, ex.y);
            ex.x = 1;
            ex.y = 1;
            Console.WriteLine("В методе Init:\nx={0}\ny={1}", ex.x, ex.y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double da = 2.3, db = 4.2;
            Console.WriteLine("a = {0}\nb = {1}",da, db);
            Example.Sqr(da,db);
            Example.Sqr(da * 2, db * 2);//параметры с двойным значением
            Console.WriteLine("В функции main\na = {0}\nb = {1}", da, db);//переменные не изменились

            Example ob1=new Example();
            Example.Init(ob1);
            

        }
    }
}

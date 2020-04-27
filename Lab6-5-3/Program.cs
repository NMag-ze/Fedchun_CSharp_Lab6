using System;
using System.Text;

namespace Lab6_5_3
{
    class Program
    {
        static void ChangeStr(ref string s)
        {
            StringBuilder sb = new StringBuilder(s);
            sb.Remove(4, 5);
            Console.WriteLine(sb);
            sb.Append("KEK");
            s = sb.ToString();//изменение переменной
            Console.WriteLine(sb);

        }

        static void Main(string[] args)
        {
            string str="adkjd:Jwqp2J9J9APSDJ1-JM[=0I";
            Console.WriteLine("Строка до вызова функции: {0}",str);
            ChangeStr(ref str);
            Console.WriteLine("Строка после вызова функции: {0}",str);

        }
    }
}

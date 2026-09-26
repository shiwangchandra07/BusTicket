using System;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1.12;
            int c = Convert.ToInt32(a);

            string z = "a";
            char b = Convert.ToChar(z);

            string i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(c);
            Console.WriteLine(c.GetType());

            Console.WriteLine(b);
            Console.WriteLine(b.GetType());

            Console.WriteLine(i);
            Console.WriteLine(i.GetType());

            Console.WriteLine(j);
            Console.WriteLine(j.GetType());

            Console.ReadKey();
        }
    }
}
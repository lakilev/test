using System;

namespace if20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, s, d;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a < b & a < c)
            {
                s = b - a;
                d = c - a;
                if (s > d)
                {
                    Console.WriteLine(c);
                }
                else
                    Console.WriteLine(b);
            }
            else if (a > b & a > c){
                s = a - b;
                d = a - c;
                if (s > d)
                {
                    Console.WriteLine(c);
                }
                else
                    Console.WriteLine(b);
            }
            else if (a > b & a < c)
            {
                s = a - b;
                d = c - a;
                if (Math.Pow(s, 2) > Math.Pow(d, 2))
                {
                    Console.WriteLine(c);
                }
                else
                    Console.WriteLine(b);
            }
            else if (a > c & a < b)
            {
                s = a - c;
                d = b - a;
                if (Math.Pow(s, 2) > Math.Pow(d, 2))
                {
                    Console.WriteLine(b);
                }
                else
                    Console.WriteLine(c);
            }

        }
    }
}

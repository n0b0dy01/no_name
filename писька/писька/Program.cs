using System;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double x1 = x, rez = x;
            int i;
            for (i = 2; i <= n; i++)
            {
                x1 *= -1 * x;
                rez += x1 / 1;

            }
            Console.WriteLine(rez);
        }
    }
}

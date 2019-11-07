using System;

namespace среднее_арифметическое_с_шарп
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double i, x = 0;
            for (i = -47; i <= 3; i++)
            {
                sum += i;
                x++;
            }
            Console.WriteLine(sum / x);


        }
    }
}

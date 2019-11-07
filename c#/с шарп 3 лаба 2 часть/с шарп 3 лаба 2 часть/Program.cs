using System;

namespace с_шарп_3_лаба_2_часть
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("введите число A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("введите число N: ");
             double N = double.Parse(Console.ReadLine());
            double w = 0;
            for (int i = 0; i <= N;i++)
            {
                w = A + Math.Pow(A, N);
                N *= i;
                i++;
                
            }

            Console.WriteLine(w);
           
        }
    }
}

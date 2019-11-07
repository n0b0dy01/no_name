using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x");
            double number_x = double.Parse(Console.ReadLine());
            double G = 9.8;
            double e = 2.71;
            if (0 < number_x)
            {
                Console.WriteLine("ответ ={0} ", Math.Log(number_x + 1) + (3 / 2) * Math.Pow(number_x,2) - G * Math.Cos(number_x));

            }
            else if (number_x < 0)
            {
                Console.WriteLine("ответ = {0}", Math.Log(Math.Abs(number_x / G)) + Math.Pow(e,number_x));

            }
            else if (number_x == 0)
            {
                Console.WriteLine("ответ ={0} ",(1 / 3) * Math.Sin(G));

            }
            else
            {
                Console.WriteLine("введите пожалуйста другие числа");
            }
            Console.ReadKey();

        }
    }
}

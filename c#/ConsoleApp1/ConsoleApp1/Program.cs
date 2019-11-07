using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа r,t");
            double number_r = double.Parse(Console.ReadLine());
            double number_t = double.Parse(Console.ReadLine());
            if (0< number_t && number_t <= 1)
            {
                Console.WriteLine("ответ ={0} ", Math.Pow(number_r,2) - Math.Sin(number_t));
                
            }
            else if (number_t <= 0)
            {
                Console.WriteLine("ответ = 0 ");
                
            }
            else if (number_t > 1)
            {
                Console.WriteLine("ответ ={0} ", Math.Pow(number_t,2) - Math.Sin(Math.Pow(number_r,2) + number_t));
                
            }
            else
            {
                Console.WriteLine("введите пожалуйста другие числа");
            }
            Console.ReadKey();

        }
    }
}

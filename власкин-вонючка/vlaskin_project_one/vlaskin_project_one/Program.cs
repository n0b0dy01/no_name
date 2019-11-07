using System;

namespace vlaskin_project_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите c,d,a");
            double number_c = double.Parse(Console.ReadLine());
            double number_d = double.Parse(Console.ReadLine());
            double number_a = double.Parse(Console.ReadLine());
            Console.WriteLine("ответ: {0}", (Math.Atan(number_c / 4) - number_d * 62) / number_a * number_a - 1);
            Console.ReadKey();
        }
    }
}

using System;

namespace среднее_арифметическое_с_шарп
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("гущин дурак");
            double res = 1;
            for (int i = -47; !(i == 3); i--)
                res += i; res /= (-47 + 3);
            Console.Write("среднее арифметическое чисел от -47 до 3 = ");
            Console.Write(res);

        }
    }
}

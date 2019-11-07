using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите массу: ");
            double number_a = double.Parse(Console.ReadLine());
            Console.WriteLine("какая величина?");
            Console.WriteLine("1-кг");
            Console.WriteLine("2-мг");
            Console.WriteLine("3-г");
            Console.WriteLine("4-тонна");
            Console.WriteLine("4-центнер");

            Console.Write("введите номер величины:");
            double number_b = double.Parse(Console.ReadLine());
            switch(number_b)
            {
                case 1 :
                    Console.WriteLine("ответ:{0}", number_a * 1);
                break;
                case 2 :
                    Console.WriteLine("ответ:{0}", number_a / 1000000);
                break;
                case 3 :
                    Console.WriteLine("ответ:{0}", number_a / 1000);
                break;
                case 4:
                    Console.WriteLine("ответ:{0}", number_a * 1000) ;
                break;
                case 5:
                    Console.WriteLine("ответ:{0}", number_a * 100);
                    break;
                default :
                    Console.WriteLine("введите другие значения действия");
                break;
             }
            Console.ReadKey();
        }
    }
}

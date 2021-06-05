using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           int a=0;
           Class1 clas = new Class1();
           while (clas.Sum<100)
            {
                Console.Write(" ");
                clas.Sum=int.Parse(Console.ReadLine());
                a++;
            }
            Console.WriteLine("Сумма чисел = {0}",clas.Sum);
            Console.WriteLine("количество просуммированных чисел = {0}",a);
            Console.ReadKey();
        }
    }
}

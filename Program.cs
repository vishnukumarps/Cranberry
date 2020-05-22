using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("{0} +{1 }={2} ",a,b,c);
            Console.WriteLine("Sum="+c);
            Console.ReadLine();



        }
    }
}

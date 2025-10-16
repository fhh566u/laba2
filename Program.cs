using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть початкове значення X1min: ");
            double x1Min = double.Parse(Console.ReadLine());

            Console.Write("Введiть кiнцеве значення X1max: ");
            double x1Max = double.Parse(Console.ReadLine());

            Console.Write("Введiть прирiст dX1: ");
            double dx1 = double.Parse(Console.ReadLine());

            Console.Write("Введiть початкове значення X2min: ");
            double x2Min = double.Parse(Console.ReadLine());

            Console.Write("Введiть кiнцеве значення X2max: ");
            double x2Max = double.Parse(Console.ReadLine());

            Console.Write("Введiть прирiст dX2: ");
            double dx2 = double.Parse(Console.ReadLine());

            double x1 = x1Min;
            double x2;
            double y;

            while (x1 <= x1Max)
            {
                x2 = x2Min;
                while (x2 <= x2Max)
                {
                    y = Math.Pow(x2, 2) / (Math.Pow(x1, 2) + 16);

                    Console.WriteLine(
                        "x1 = {0:e}\tx2 = {1:e}\ty = {2:e}", x1, x2, y);

                    x2 += dx2;
                }
                x1 += dx1;
            }

            Console.ReadKey();
        }
    }
}
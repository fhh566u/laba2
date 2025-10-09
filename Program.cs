using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть початкове значення Xmin: ");
            double xMin = double.Parse(Console.ReadLine());

            Console.Write("Введiть кiнцеве значення Xmax: ");
            double xMax = double.Parse(Console.ReadLine());

            Console.Write("Введiть прирiст dX: ");
            double dx = double.Parse(Console.ReadLine());

            double x = xMin;
            double y;

            while (x <= xMax)
            {
                double x1 = x;
                double x2 = 3 * x;

                y = Math.Cos(Math.Sqrt(x2) + 34 * x1) - 4 * Math.Sin(x2);

                Console.WriteLine("x = {0:F3}\t y = {1:F5}", x, y);
                x += dx;
            }

            if (Math.Abs(x - xMax - dx) > 0.0001)
            {
                double x1 = xMax;
                double x2 = 3 * xMax;
                y = Math.Cos(Math.Sqrt(x2) + 34 * x1) - 4 * Math.Sin(x2);
                Console.WriteLine("x = {0:F3}\t y = {1:F5}", xMax, y);
            }

            Console.ReadKey();
        }
    }
}
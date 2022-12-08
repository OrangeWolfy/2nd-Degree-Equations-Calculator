using System;

namespace _2nd_Degree_Equations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2nd degree equations calculator");
            while (true)
            {
                Console.Write("a = ");
                string? stringA = Console.ReadLine();
                Console.Write("b = ");
                string? stringB = Console.ReadLine();
                Console.Write("c = ");
                string? stringC = Console.ReadLine();
                double a = Convert.ToDouble(string.IsNullOrEmpty(stringA) ? 0 : stringA);
                double b = Convert.ToDouble(string.IsNullOrEmpty(stringB) ? 0 : stringB);
                double c = Convert.ToDouble(string.IsNullOrEmpty(stringC) ? 0 : stringC);

                double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2;
                double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2;

                Console.WriteLine($"\n{a}x²{b}x{c} ");
                Console.WriteLine($"x1 = {x1}\nx2 = {x2}\n");
            }
        }
    }
}
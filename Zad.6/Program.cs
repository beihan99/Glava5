
// Напишете програма, която при въвеждане на коефициентите (a, b и c) на квадратно уравнение: ax2+bx+c, изчислява и извежда неговите реални корени (ако има такива). Квадратните уравнения могат да имат 0, 1 или 2 реални корена.

using System;


namespace Zad._6
{
    class Program
    {
        static void Main()
        {
            double x1, x2;

            Console.WriteLine(" ax^2 + bx + c = 0");
            Console.WriteLine("");

            Console.Write(" a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write(" b = ");
            double b = double.Parse(Console.ReadLine());

            Console.Write(" c = ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine(" Вашето уравнение е {0}x^2 + {1}x + {2} = 0", a, b, c);
            Console.WriteLine("");

            double d = (Math.Pow(b, 2) - (4 * (a * c)));
            Console.WriteLine(" D = {0}", d);
            Console.WriteLine("");

            if (d < 0)
            {
                Console.WriteLine(" Уравнението няма решение !");
            }
            if (d == 0)
            {
                x1 = x2 = (-b / (2 * a));
                Console.WriteLine(" x1 = x2 = {0}", x1);
            }
            if (d > 0)
            {
                x1 = ((-b + Math.Sqrt(d)) / 2 * a);
                x2 = ((-b - Math.Sqrt(d)) / 2 * a);
                Console.WriteLine(" x1 = {0}", x1);
                Console.WriteLine(" x2 = {0}", x2);
            }
        }
    }
}



// Напишете програма, която намира най-голямото по стойност число, измежду три дадени числа.

using System;


namespace Zad._3
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете I-во число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write(" Въведете II-ро число: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write(" Въведете III-то число: ");
            int c = int.Parse(Console.ReadLine());

             if (a>b && a>c)
              {
                Console.WriteLine(" Най-голямото число е {0}", a);
              }
             if (b > a && b > c)
              {
                Console.WriteLine(" Най-голямото число е {0}", b);
              }
             else if (c > a && c > b)
              {
                Console.WriteLine(" Най-голямото число е {0}", c);
              }

        }
    }
}

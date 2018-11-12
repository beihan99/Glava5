
// Напишете програма, която намира най-голямото по стойност число измежду дадени 5 числа.

using System;


namespace Zad._7
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

           Console.Write(" Въведете IV-то число: ");
           int d = int.Parse(Console.ReadLine());

           Console.Write(" Въведете V-то число: ");
           int e = int.Parse(Console.ReadLine());

            if (a > b && a > d && a > c && a > e) Console.WriteLine(" Най-голямото число е {0}",a);
            if (b > a && b > d && b > c && b > e) Console.WriteLine(" Най-голямото число е {0}",b);
            if (c > a && c > b && c > d && c > e) Console.WriteLine(" Най-голямото число е {0}",c);
            if (d > a && d > b && d > c && d > e) Console.WriteLine(" Най-голямото число е {0}",d);
            if (e > a && e > b && e > c && e > d) Console.WriteLine(" Най-голямото число е {0}",e);
        }
    }
}

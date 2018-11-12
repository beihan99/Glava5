
// Сортирайте 3 реални числа в намаляващ ред. Използвайте вложени if оператори.

using System;


namespace Zad._4
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

            if (a < b)
            {
                if (a < c)
                {
                    a = a + c;
                    c = a - c;
                    a = a - c;

                    if (b > c)
                    {
                        a = a + b;
                        b = a - b;
                        a = a - b;
                    }
                }
                else if (a >= c)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
            }
            else if (a == b)
            {
                if (a < c)
                {
                    a = a + c;
                    c = a - c;
                    a = a - c;
                }
            }
            else
            {
                if (b < c)
                {
                    b = b + c;
                    c = b - c;
                    b = b - c;
                }
                if (a < b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
            }

            Console.WriteLine(" {0}, {1}, {2}", a, b, c);
        }
    }
}

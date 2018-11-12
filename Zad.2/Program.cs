
// Напишете програма, която показва знака (+ или -) от произведението на три реални числа, без да го пресмята. Използвайте последователност от if оператори.

using System;


namespace Zad._2
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


              if (a < 0 && b < 0 && c < 0) Console.WriteLine(" Знака на получената стойност при произведение е: -");
              else if (a >= 0 && b >= 0 && c >= 0) Console.WriteLine(" Знака на получената стойност при произведение е: +");
              else if (a < 0 && b < 0 && c >= 0) Console.WriteLine(" Знака на получената стойност при произведение е: +");
              else if (a < 0 && b >= 0 && c < 0) Console.WriteLine(" Знака на получената стойност при произведение е: +");
              else if (a >= 0 && b < 0 && c < 0) Console.WriteLine(" Знака на получената стойност при произведение е: +");
              else if (a < 0 && b >= 0 && c >= 0) Console.WriteLine(" Знака на получената стойност при произведение е: -");
              else if (a >= 0 && b < 0 && c >= 0) Console.WriteLine(" Знака на получената стойност при произведение е: -");
              else if (a >= 0 && b >= 0 && c < 0) Console.WriteLine(" Знака на получената стойност при произведение е: -");
        }
    }
}

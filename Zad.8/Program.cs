
// Напишете програма, която по избор на потребителя прочита от конзолата променлива от тип int, double или string. Ако променливата е int или double, трябва да се увеличи с 1. Ако променливата е string, трябва да се прибави накрая символа "*". Отпечатайте получения резултат на конзолата. Използвайте switch конструкция.

using System;


namespace Zad._8
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Изберете тип променлива (1 - int, 2 - double, 3 string): ");
            int prom = int.Parse(Console.ReadLine());

              switch (prom)
              {
                case 1:
                    {
                        Console.Write(" Въведете число(int): ");
                        prom = int.Parse(Console.ReadLine());
                        prom++;
                        Console.WriteLine(" Стойноста + 1 = {0}", prom);
                        break;
                    }
                case 2:
                    {
                        Console.Write(" Въведете число(double): ");
                        double Dprom = double.Parse(Console.ReadLine());
                        Dprom++;
                        Console.WriteLine(" Стойноста + 1 = {0}", Dprom);
                        break;
                    }
                case 3:
                    {
                        Console.Write(" Въведете текс(string): ");
                        string Sprom = Console.ReadLine();
                        Sprom = Sprom + '*';
                        Console.WriteLine(" Текста + * = {0}", Sprom);
                        break;
                    }
                default: Console.WriteLine(" Грешен избор !"); break;
              }
        }
    }
}

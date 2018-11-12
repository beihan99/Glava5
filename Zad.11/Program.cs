
// Напишете програма, която преобразува дадено число в интервала [0..999] в текст, съответстващ на българското произношение на числото.

using System;


namespace Zad._11
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int n = int.Parse(Console.ReadLine());

              if (n >= 0 && n <= 999)
              {
                int x = n;
                switch (x / 100)
                {
                   case 1:
                        Console.Write(" Сто ");
                        break;
                    case 2:
                        Console.Write(" Двеста ");
                        break;
                    case 3:
                        Console.Write(" Триста ");
                        break;
                    case 4:
                        Console.Write(" Четиристотин ");
                        break;
                    case 5:
                        Console.Write(" Петстотин ");
                        break;
                    case 6:
                        Console.Write(" Шестстотин ");
                        break;
                    case 7:
                        Console.Write(" Седемстотин ");
                        break;
                    case 8:
                        Console.Write(" Осемстотин ");
                        break;
                    case 9:
                        Console.Write(" Деветстотин ");
                        break;
                }
                if (x / 100 != 0 && x % 100 != 0)
                {
                    Console.Write("и ");
                }
                switch (x / 10 % 10)
                {
                    case 1:
                        {
                            switch (x % 10)
                            {
                                case 0:
                                    Console.WriteLine(" десет ");
                                    break;
                                case 1:
                                    Console.WriteLine(" единадесет ");
                                    break;
                                case 2:
                                    Console.WriteLine(" дванайсет ");
                                    break;
                                case 3:
                                    Console.WriteLine(" тринайсет ");
                                    break;
                                case 4:
                                    Console.WriteLine(" четиринайсет ");
                                    break;
                                case 5:
                                    Console.WriteLine(" петнайсет ");
                                    break;
                                case 6:
                                    Console.WriteLine(" шестнайсет ");
                                    break;
                                case 7:
                                    Console.WriteLine(" седемнайсет ");
                                    break;
                                case 8:
                                    Console.WriteLine(" осемнайсет ");
                                    break;
                                case 9:
                                    Console.WriteLine(" деветнайсет ");
                                    break;

                           }
                        }
                        break;
                    case 2:
                        Console.Write(" двайсет и ");
                        break;
                    case 3:
                        Console.Write(" трийсет и ");
                        break;
                    case 4:
                        Console.Write(" четирсет и ");
                        break;
                    case 5:
                        Console.Write(" педесет и ");
                        break;
                    case 6:
                        Console.Write(" шейсет и ");
                        break;
                    case 7:
                        Console.Write(" седемдесет и ");
                        break;
                    case 8:
                        Console.Write(" осемдесет и ");
                        break;
                    case 9:
                        Console.Write(" деветдесет и ");
                        break;

                }
                switch (x % 10)
                {
                    case 0:
                        if (x == 0)
                        {
                            Console.Write("нула");
                        }
                        Console.Write("\n ");
                        break;
                    case 1:
                        if (x/ 10 % 10 == 1) break;
                        Console.WriteLine(" едно");
                        break;
                    case 2:
                        if (x / 10 % 10 == 1) break;
                        Console.WriteLine(" две");
                        break;
                    case 3:
                        if (x / 10 % 10 == 1) break;
                        Console.WriteLine(" три ");
                        break;
                    case 4:
                        if (x / 10 % 10  == 1) break;
                        Console.WriteLine(" четири");
                        break;
                    case 5:
                        if (x / 10 % 10 == 1) break;
                        Console.WriteLine(" пет");
                        break;
                    case 6:
                        if (x / 10 % 10 == 1) break;
                        Console.WriteLine(" шест");
                        break;
                    case 7:
                        if (x / 10 % 10 == 1) break;
                        Console.WriteLine(" седем ");
                        break;
                    case 8:
                        if (x / 10 % 10 == 1) break;
                        Console.WriteLine(" осем ");
                        break;
                    case 9:
                        if (x / 10 % 10 == 1) break;
                        Console.WriteLine(" девет ");
                        break;

                }
              }
              else
              {
                Console.WriteLine(" Невалидна стойност !");
              }

        }
    }
}

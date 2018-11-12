
// Напишете програма, която за дадена цифра (0-9), зададена като вход, извежда името на цифрата на български език.

using System;


namespace Zad._5
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 0:
                    Console.WriteLine(" Въведохте числото: Нула");
                    break;
                case 1:
                    Console.WriteLine(" Въведохте числото: Едно");
                    break;
                case 2:
                    Console.WriteLine(" Въведохте числото: Две");
                    break;
                case 3:
                    Console.WriteLine(" Въведохте числото: Три");
                    break;
                case 4:
                    Console.WriteLine(" Въведохте числото: Четири");
                    break;
                case 5:
                    Console.WriteLine(" Въведохте числото: Пет");
                    break;
                case 6:
                    Console.WriteLine(" Въведохте числото: Шест");
                    break;
                case 7:
                    Console.WriteLine(" Въведохте числото: Седем");
                    break;
                case 8:
                    Console.WriteLine(" Въведохте числото: Осем");
                    break;
                case 9:
                    Console.WriteLine(" Въведохте числото: Девет");
                    break;

            }
        }
    }
}

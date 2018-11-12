
// Да се напише if-конструкция, която проверява стойността на две целочислени променливи и разменя техните стойности, ако стойността на първата променлива е по-голяма от втората.

using System;


namespace Zad._1
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write(" Въведете число: ");
            int n2 = int.Parse(Console.ReadLine());

             if (n1>n2)
              {
                Console.WriteLine(" n1 > n2");
                Console.WriteLine(" n1 = {0}", n2);
                Console.WriteLine(" n2 = {0}", n1);
              }
             else
              {
                Console.WriteLine(" n1 < n2");
                Console.WriteLine(" n1 = {0}", n1);
                Console.WriteLine(" n2 = {0}", n2);
              }

        }
    }
}

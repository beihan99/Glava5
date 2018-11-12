
// Дадени са пет цели числа. Напишете програма, която намира онези подмножества от тях, които имат сума 0. 

using System;


namespace Zad._9
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

              if (a + b == 0) Console.WriteLine(" {0} + {1} = 0",a,b);
              if (a + b + c == 0) Console.WriteLine(" {0} + {1} + {2} = 0",a,b,c);
              if (a + b + c + d == 0) Console.WriteLine(" {0} + {1} + {2} + {3}= 0",a,b,c,d);
              if (a + b + c + d + e == 0) Console.WriteLine(" {0} + {1} + {2} + {3} + {4} = 0",a,b,c,d,e);

              if (a + c == 0) Console.WriteLine(" {0} + {1} = 0",a,c);

              if (a + d == 0) Console.WriteLine(" {0} + {1} = 0", a, d);
              if (a + d + b == 0) Console.WriteLine(" {0} + {1} + {2} = 0", a, d,b);

              if (a + e == 0) Console.WriteLine(" {0} + {1} = 0", a, e);
              if (a + e + b == 0) Console.WriteLine(" {0} + {1} + {2} = 0", a, e, b);
              if (a + e + b + c == 0) Console.WriteLine(" {0} + {1} + {2} + {3}= 0", a, e, b, c);

              else Console.WriteLine(" Няма подмножества равни на 0 !");
        }
    }
}

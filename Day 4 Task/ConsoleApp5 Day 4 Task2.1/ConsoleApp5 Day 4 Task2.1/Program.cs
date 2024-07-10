using System;

namespace SeriesGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // a.  1  4  9  16   25  36  49  64  81 100

            for (int j = 1; j <= 10; j++)
            {
                Console.Write("{0} ", j * j);
            }
            Console.WriteLine();

            Console.WriteLine("\n------------------------------------");

            // b.  0   1    1   2   3  5  8  13  21  34  55 89 144

            int a = 0, b = 1, next, count = 0;

            Console.Write("{0} {1} ", a, b);
            count = 2;

            while (count < 15)
            {
                next = a + b;
                Console.Write("{0} ", next);
                a = b;
                b = next;
                count++;
            }
            Console.WriteLine();

            Console.WriteLine("\n------------------------------------");

            //c.   3   5   6   9    10  12  15  18  20  21 24  25  27  30


            int i = 3;
            do
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.Write("{0} ", i);
                }
                i++;
            } while (i <= 30);

            Console.WriteLine();

        }
    }
}

using System;

namespace SumEvenOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            int sumEven = 0;
            int sumOdd = 0;
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEven += numbers[i];
                }
                else
                {
                    sumOdd += numbers[i];
                }
            }

            Console.WriteLine("Sum of even numbers: " + sumEven);
            Console.WriteLine("Sum of odd numbers: " + sumOdd);
            Console.ReadLine();
        }
    }
}

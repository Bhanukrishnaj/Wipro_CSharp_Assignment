using System;

namespace ProductTotalAmount
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfProducts = 5;
            double totalAmount = 0;

            double[] prices = new double[numberOfProducts];
            int[] quantities = new int[numberOfProducts];

            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.Write("Enter price for product {0}: ", i + 1);
                prices[i] = double.Parse(Console.ReadLine());

                Console.Write("Enter quantity for product {0}: ", i + 1);
                quantities[i] = int.Parse(Console.ReadLine());

                totalAmount += prices[i] * quantities[i];
            }

            Console.WriteLine("Total amount for all products: " + totalAmount);

            Console.ReadLine();
        }
    }
}

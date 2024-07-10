using System;

namespace NumberToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            string result = NumberToWords(input);
            Console.WriteLine(result);
        }

        static string NumberToWords(string number)
        {
            string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string result = "";

            for (int i = 0; i < number.Length; i++)
            {
                char digit = number[i];
                if (char.IsDigit(digit))
                {
                    result += words[digit - '0'];
                }
                else
                {
                    return "Invalid input.";
                }
            }

            return result.Trim();
        }
    }
}

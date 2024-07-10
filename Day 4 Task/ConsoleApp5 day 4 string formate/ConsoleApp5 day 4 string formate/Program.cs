using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_day_4_string_formate
{
    class Program
    {
        static void Main(string[] args)
        {
            string userId = "admin";
            string message = string.Format("Welcome, {0}!", userId);
            Console.WriteLine(message);

            int day = 10;
            string month = "July";
            int year = 2024;
            string dateMessage = string.Format("Today is {0} {1}, {2}.", day, month, year);
            Console.WriteLine(dateMessage);

            double price = 19.99;
            string formattedPrice = string.Format("The price is {0}.", price);
            Console.WriteLine(formattedPrice);
        }
    }
}

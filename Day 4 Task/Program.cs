using System;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter User Id: ");
            string userId = Console.ReadLine();

            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();

            if (userId.Trim().ToLower() == "admin" && password.Trim().ToLower() == "admin123")
            {
                Console.WriteLine("Welcome to Admin");
            }
            else
            {
                Console.WriteLine("Invalid User Id or Password");
            }

            Console.ReadLine();
        }
    }
}

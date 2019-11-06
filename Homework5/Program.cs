using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //vanus sekundites 
            string userInput;
            Console.WriteLine("Hello! Enter your birth date(yyyy/mm/dd): ");
            userInput = Console.ReadLine();

            string[] userData = userInput.Split('/');
            int year = int.Parse(userData[0]);
            int month = int.Parse(userData[1]);
            int day = int.Parse(userData[2]);

            var userBirthDay = new DateTime(year, month, day);
            var now = DateTime.Now;
            var seconds = (now - userBirthDay).TotalSeconds;
            Console.WriteLine($"You were born {seconds} seconds ago.");

            Console.ReadLine();
            
            
        }
    }
}
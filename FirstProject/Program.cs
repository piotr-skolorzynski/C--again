using System;

namespace FirstProject // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Year of birth? ");
            string userInput = Console.ReadLine();

            bool isOver18 = DateTime.Now.Date.Year - int.Parse(userInput) > 18; 

            if (isOver18)
            {
                Console.WriteLine("hello");
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Oh well its Sunday");
            }
            else
            {
                Console.WriteLine("Access denied");
            }

        }
    }
}

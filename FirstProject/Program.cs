using System;

namespace FirstProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Mazda" };

            int i = 0;
            while (i < cars.Length)
            {
                Console.WriteLine(cars[i]);
                if (cars[i] == "BMW")
                {
                    Console.WriteLine(cars[i]);
                    break;
                }
                i++;
            }

            Console.WriteLine("To exit, type 'x");

            string userInput;

            do
            {
                userInput = Console.ReadLine();
                Console.WriteLine($"Echo: {userInput}");
            } while (userInput != "x");

            for (int j = 0; j < cars.Length; j++)
            {
                Console.WriteLine(cars[j]);

                if (cars[i] == "BMW")
                {
                    Console.WriteLine("Bye");
                    break;
                }
            }

            foreach (string car in cars)
            {
                Console.WriteLine(car);

                if (car == "BMW")
                {
                    Console.WriteLine("bye");
                    break;
                }
            }
        }
    }
}

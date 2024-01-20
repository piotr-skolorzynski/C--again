using System;

namespace FirstProject // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            string someText = "Some text";

            char jChar = 'j';
            char jCharUnicode = '\u006A';

            bool isUserReady = true;

            DateTime now = DateTime.Now;
            DateTime dateOfBirt = new DateTime(1982, 8, 25);
            Console.Write("Date of birth: " + dateOfBirt);

            byte byteNumber = 200;

            float floatNumber = 1.5F;
            decimal decimalNumber = 1.5M;
            double doubleNumber = 1.5;




            Console.ReadLine();


        }
    }
}

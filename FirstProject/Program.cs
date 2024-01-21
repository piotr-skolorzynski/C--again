using System;

namespace FirstProject // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("It is Monday ;(");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("It is a last day of work week :)");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It is a weekend");
                    break;
                default:
                    Console.WriteLine("It is a middle of work week");
                    break;
            }

        }
    }
}

using System;

namespace FirstProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Mazda" };

            try
            {
                cars[4] = "Tesla"; //throws System.IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Handling IndexOutOfRangeException");
            }
            catch (Exception e)
            {
                Console.WriteLine("Handling any exception");
            }
            finally
            {
                Console.WriteLine("Cleanup");
            }
        }
    }
}

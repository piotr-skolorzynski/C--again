using System;

namespace FirstProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Wick");
            bill.DateOfBirth = new DateTime(1992, 8, 25);
            Console.WriteLine(bill.DateOfBirth);
            bill.SayHi();

            bill.ContactNumber = "999888777";
            Console.WriteLine(bill.ContactNumber);

            Person john = new Person(new DateTime(1986, 12, 5), "John", "Doe");
            john.SayHi();
        }
    }
}

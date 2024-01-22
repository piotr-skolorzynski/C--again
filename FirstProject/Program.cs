using System;

namespace FirstProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Wick");
            bill.SetDateOfBirth(new DateTime(1992, 8, 25));
            bill.SayHi();

            Person john = new Person(new DateTime(1986, 12, 5), "John", "Doe");
            john.SayHi();
        }
    }
}

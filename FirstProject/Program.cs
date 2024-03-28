using System;
using System.Collections.Generic;

namespace FirstProject
{
  internal class Program
  {
      static void Main(string[] args)
      {
        // var restaurants = new List<Reastaurant>();

        // var results = new PaginatedResult<Reastaurant>();

        // results.Results = restaurants;

        // var stringRepository = new Repository<string>();
        // stringRepository.AddElement("some value");
        // string firstElement = stringRepository.GetElement(0);

        // var userRepository = new Repository<string, User>();

        // userRepository.AddElement("Bill", new User() { Name = "Bill" });
        // User bill = userRepository.GetElement("Bill");

        int[] intArray = new []{ 1, 3, 5 };
        Utils.Swap(ref intArray[0], ref intArray[2]);
        Console.WriteLine(string.Join(" ", intArray));
      }
  }
}

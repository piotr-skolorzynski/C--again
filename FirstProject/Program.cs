using System.Collections.Generic;

namespace FirstProject
{
  internal class Program
  {
      static void Main(string[] args)
      {
        var restaurants = new List<Reastaurant>();

        var results = new PaginatedResult<Reastaurant>();

        results.Results = restaurants;
      }
  }
}

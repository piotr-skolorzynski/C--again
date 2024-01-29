using System;
using System.Collections.Generic;

namespace FirstProject
{
    internal class Program
    {
      public static IEnumerable<int> GetYieldedData()
      {
        //przykład iteratora zwracającego liczbę całkowitą
        for (int i = 0; i <= 9; i++)
        {
          yield return i;
          if (i % 3 == 0) 
          {
            //możliwe jest zakończenie działania iteratora 
            //w przypadku spełnienia konkretnego warunku
            yield break;
          }
        }
      }
      private static void Main(string[] args)
      {
        //przykład wykorzystania iteratora
        var yieldedData = GetYieldedData();
        foreach (int element in yieldedData)
        {
          Console.WriteLine(element); //0 1 2 3 4 5 6 7 8 9
        }
      }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace FirstProject
{
    internal class Program
    {
      private static void Main(string[] args)
      {
        var path = @"d:\Repos\26. C# basics\FirstProject\playerSerialized.json";

        //załóżmy że mamy bardzo prosty program, który wykorzystuje klasę FileStream 
        // do czytania pracy z plikiem i tworzymy metodę do czytania i zapisu.
        //praca z plikiem ma to do sibie że jak otworzymy go w jednej metodzie i nie zamkniemy 
        // to inna metoda nie może z nim pracować
        //więc jeśli pracujemy z plikiem i np. pojawi się wyjątek to może okazać się że nie zamknięmy pliku
        // żeby zapobiec temy kod metody można zamknąć w bloku try -> catch -> finally gdzie w finally zawsze 
        // zamykamy plik
        // var readFileStream = new FileStream(path, FileMode.Open);
        // try
        // {
        //   throw new Exception();
        // }
        // finally
        // {
        //   readFileStream.Close();
        // }
        //Microsoft stworzył rozwiązanie, które robi to za nas automatycznie
        // w tym celu używa się wyrażenia using
        using (var readFileStream = new FileStream(path, FileMode.Open))
        {
          throw new Exception();
        }
        //using można użyć dla każdej klasy, która implementuje interfejs IDisposable
      }
    }
}

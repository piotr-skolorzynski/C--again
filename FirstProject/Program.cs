using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace FirstProject
{
    internal class Program
    {
      private static void Main(string[] args)
      {
        // DateTimeModification();
        // DateTimeFormatting();
        // TimeMeasurement();
        DateTimeHelpers();
      }

      static void DateTimeModification()
      {
        //daty można od siebie odejmować a rezultatem jest typ TimeSpan okreslający różnicę 
        // podając ją w latach, dniach, minutach itd zależnie w jakiej formie chcemy
        DateTime now = DateTime.Now;
        DateTime openDate = new DateTime(1992, 6, 17);
        
        TimeSpan result = now - openDate;

        Console.WriteLine(result.Days); //pełne dni
        Console.WriteLine(result.TotalDays); //dni z ułamkiem jeśli jest

        //Dat do siebie nie można dodawać 
        //ale oczywiście do daty można dodawać jakąś konkretną jednostkę czasu
        DateTime expiresAt = now.AddDays(7);
        DateTime expiresAt2 = now.Add(new TimeSpan(7, 1, 0, 0));

        Console.WriteLine(expiresAt);
        Console.WriteLine(expiresAt2);

        //porównywanie dat
        bool expiresAtTheSameDay = expiresAt == expiresAt2; // false -> dlaczego pomimo że są tego samego dnia? bo porównywana jest również godzina
        bool expiresAtTheSameDay2 = expiresAt.Date == expiresAt2.Date; // true -> w tym przypadku porównywane są tylko daty bez godzin
      }

      static void DateTimeFormatting()
      {
        DateTime now = DateTime.Now;
        //sposoby formatowania dat na bazie wbudowanych metod
        Console.WriteLine(now.ToShortDateString()); // 03.02.3024 -> Polska/Warszawa
        Console.WriteLine(now.ToLongDateString()); //sobota, 3 lutego 2024
        //metoda ToString która przyjmuje w postaci litery format dla dat
        Console.WriteLine(now.ToString("g")); // 03.02.2024 19:54
        Console.WriteLine(now.ToString("G")); // 03.02.2024 19:54:49
        //najbardziej elastycznym sposobem jest przekazanie do metody ToString() własnego formatu
        Console.WriteLine(now.ToString("yyyy-MM-dd")); //2024-02-03
        Console.WriteLine(now.ToString("yyyy-MM-dd hh:mm:ss")); //2024-02-03 08:46:04
      }
      static void TimeMeasurement()
      {
        // przykład jak mierzyć czas udzielania przez użytkownika odpowiedzi
        Console.WriteLine("What is 2 + 2");
        Console.WriteLine("A) 4");
        Console.WriteLine("B) 6");
        Console.WriteLine("C) 8");

        DateTime start = DateTime.Now;
        string userInput = Console.ReadLine();
        DateTime end = DateTime.Now;

        TimeSpan responseTime = end - start;
        Console.WriteLine($"Response took you {responseTime.TotalSeconds} seconds");

        //To był najprostszy sposób jak można sobie z tym poradzić.
        // W c# stworzono specjalny typ do mierzenia czasu i nazywa się StopWatch (czyli stoper)
        // Stopwatch stopwatch = new Stopwatch();
        // stopwatch.Start();
        //jeżeli chcemy stoper utworzyć i od razu uruchomić to można użyć poniższego kodu
        Stopwatch stopwatch = Stopwatch.StartNew();
        string userInput2 = Console.ReadLine();
        stopwatch.Stop();
        Console.WriteLine($"Response took you {stopwatch.Elapsed.TotalSeconds} seconds");
      }

      static void DateTimeHelpers()
      {
        //propka DaysInMonth
        int daysInFeb2024 = DateTime.DaysInMonth(2024, 2);
        Console.WriteLine($"Days in February 2024: {daysInFeb2024}"); //29
        //sprawdzenie czy rok jest przestępny
        bool isLeapYear = DateTime.IsLeapYear(2024);
        Console.WriteLine($"Is 2024 a leap year: {isLeapYear}"); //true

      }
    }
}

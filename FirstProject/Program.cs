using System;
using System.Collections.Generic;

namespace FirstProject
{
    internal class Program
    {
      static Dictionary<string, Currency> GetCurrencies()
      {
        return new Dictionary<string, Currency>
        {
          { "usd", new Currency("usd", "United States Dollar", 1)},
          { "eur", new Currency("eur", "Euro", 0.83975)},
          { "gbp", new Currency("gbp", "British Pound", 0.74771)},
          { "cad", new Currency("cad", "Canadian Dollar", 1.30724)},
          { "inr", new Currency("inr", "Indian Rupee", 73.04)},
          { "mxn", new Currency("mxn", "Mexican Peso", 21.7571)},

        };
      }

      private static void Main(string[] args)
      {
        Dictionary<string, Currency> currencies = GetCurrencies();
        Console.WriteLine("Check the rate for: ");
        string userInput = Console.ReadLine();

        // //pobieranie wartości ze słownika
        // Currency selectedCurrency = currencies[userInput];
        //żeby się zabezpieczyć przed sytuacją że w słowniku nie ma wpisanej przez użytkownika wartości
        //można skorzystać z metody TryGetValue dla słownika
        Currency selectedCurrency = null;
        if (currencies.TryGetValue(userInput, out selectedCurrency)) 
        {
          Console.WriteLine($"Rate for USD to {selectedCurrency.FullName} is {selectedCurrency.Rate}");
        }
        else 
        {
          Console.WriteLine("Currency not found");
        }

        //usuwanie elementu ze słownika
        currencies.Remove("usd");

        //dodawanie elementów do słownika (klucz, wartość)
        currencies.Add("pln", new Currency("pln", "Polski Nowy", 4.5));

        //Jeżeli będę chciał dodać element do słownika i klucz będzie się powtarzał to 
        // otrzymamy błąd Dlatego bezpieczniejszą metodą dodania klucza jest użycie metody TryAdd. Przesyła się tak samo 
        // oba argumenty klucz - wartość ale ponadto sama metoda zwraca wartość logiczną czy udało się dodać element 
        // do słownika
        currencies.TryAdd("usd", new Currency("usd", "Dollar", 1));
      }
    }
}

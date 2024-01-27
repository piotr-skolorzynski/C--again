using System;
using System.Collections.Generic;

namespace FirstProject
{
    internal class Program
    {
        static void DisplayElements(List<int> list)
        {
          Console.WriteLine("** List **");
          foreach(int item in list)
          {
          Console.Write($"{item}, ");
          }
          Console.WriteLine();
        }
        private static void Main(string[] args)
        {
          //deklaracja listy z deklaracją początkowych wartości
          List<int> intList = new List<int>() { 6, 1, 20 };
          DisplayElements(intList); //wyświetlanie listy

          Console.WriteLine("New element: ");
          string userInput = Console.ReadLine();
          int intValue = int.Parse(userInput);
          //dodawanie elementów do listy
          intList.Add(intValue);
          DisplayElements(intList);

          //sortowanie listy
          intList.Sort();
          Console.WriteLine("Sorted list: ");
          DisplayElements(intList);

          //sposoby uswania elementów z listy
          List<int> intList1 = new List<int>() { 6, 1, 20, 3, 45, 60, 100, 2 };
          intList1.RemoveAt(2); //nr indexu -> usunie wartość 20

          bool IsGreaterThan5(int x)
          {
            return x > 5;
          }

          List<int> intList2 = new List<int> { 6, 1, 20, 3, 45, 60, 100, 2 };
          intList2.RemoveAll(IsGreaterThan5); //przekazuje warunek po spełnieniu którego należy usunąć element / elementy

          List<int> intList3 = new List<int> { 1, 2, 1 };
          intList3.Remove(1); //usuwa pierwsze wystąpienie określonej wartości.

          List<int> intList4 = new List<int> { 6, 1, 20, 3, 45, 60, 100, 2 };
          intList4.RemoveRange(2, 3); //Usuwa elementy w zakresie indexu początkowego oraz liczby elementów do usunięcia
          // czyli tutaj zacznij od wartości na pozycji 2 czyli liczby 20 i usuń 3 kolejne liczby czyli 20, 3 oraz 45
        }
    }
}

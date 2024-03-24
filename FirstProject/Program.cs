using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;

namespace FirstProject
{
  internal class Program
  {
      static void Main(string[] args)
      {
        var people = LoadPeople();
        var addresses = LoadAdresses();

        var joinedData = people.Join(addresses,
            p => p.Id,
            a => a.PersonId,
            (person, address) => new { person.Name, address.Street, address.City });

        foreach (var element in joinedData)
        {
          Console.WriteLine($"Name: {element.Name}, address: {element.City}, {element.Street}");
        }
      }

      private static List<Persona> LoadPeople()
      {
        var currentDir = Directory.GetCurrentDirectory();
        var jsonFullPath = Path.GetRelativePath(currentDir, "Person/People.json");
        var json = File.ReadAllText(jsonFullPath);

        return JsonConvert.DeserializeObject<List<Persona>>(json);
      }

      private static List<Address> LoadAdresses()
      {
        var currentDir = Directory.GetCurrentDirectory();
        var jsonFullPath = Path.GetRelativePath(currentDir, "Person/Address.json");
        var json = File.ReadAllText(jsonFullPath);

        return JsonConvert.DeserializeObject<List<Address>>(json);
      }
  }
}

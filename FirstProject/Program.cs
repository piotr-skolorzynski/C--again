using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace FirstProject
{
  internal class Program
  {
      static void Main(string[] args)
      {
        var people = LoadPeople();
        var addresses = LoadAdresses();

        var joinedData = people.GroupJoin(addresses,
            p => p.Id,
            a => a.PersonId,
            (person, addresses) => new { person.Name, Addresses = addresses });

        foreach (var element in joinedData)
        {
          Console.WriteLine($"Name: {element.Name}");
          foreach (var address in element.Addresses)
          {
            Console.WriteLine($"\t City: {address.City}, street: {address.Street}");
          }
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

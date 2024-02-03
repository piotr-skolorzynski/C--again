using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FirstProject
{
    internal class Program
    {
      private static void Main(string[] args)
      {
          var player = new Player()
          {
            Name = "Mario",
            Level = 1,
            HealthPoints = 100,
            Statistics = new List<Statistics>()
            {
              new Statistics()
              {
                Name = "Strength",
                Points = 10
              },
              new Statistics()
              {
                Name = "Intelligance",
                Points = 10
              }
            }
          };
          player.Level++;
          //use method Newtonsoft.Json nuget to serialize to JSON 
          string playerSerialized = JsonConvert.SerializeObject(player);
          //save JSON to the file
          File.WriteAllText(@"d:\Repos\26. C# basics\FirstProject\playerSerialized.json", playerSerialized);

          //Wczytywanie pliku JSON
          string playerFromJson = File.ReadAllText(@"d:\Repos\26. C# basics\FirstProject\playerSerialized.json");
          //deserializacja
          Player newPlayer = JsonConvert.DeserializeObject<Player>(playerFromJson);
      }
    }
}

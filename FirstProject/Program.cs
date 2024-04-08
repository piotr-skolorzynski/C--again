using System;
using System.Threading.Tasks;

namespace FirstProject
{
  internal class Program
  {

      static async Task FooAsync() 
      {
        Console.WriteLine("Foo start");
        await Task.Delay(2000);
        throw new Exception();
      }
      static async Task Main(string[] args)
      {
        Console.WriteLine("Main started");
        try
        {
          await FooAsync();
        }
        catch(Exception e)
        {
         Console.WriteLine("Exception");
        }
        Console.ReadKey();
      }
  }
}

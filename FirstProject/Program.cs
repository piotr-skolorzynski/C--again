using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
  internal class Program
  {
      static void Main(string[] args)
      {

      }

      private async void Read_Files_Async_Handler(object sender, RoutedEventArgs e)
      {
        ResultLabel.Content = "Reading started:";
        var stopwatch = Stopwatch.StartNew();
        var result = await ProcessFilesAsync();
        stopwatch.Stop();
        ResltLabel.Content = $"Finished in: {stopwatch.ElapsedMilliseconds} ms. Result: {result}";
      }

      private async Task<int> ProcessFilesAsync() 
      {
        var filesPath = "D:/files/";
        var totalLength = 0;
        List<Task> tasks = new List<Task>();
        for (int i = 1; i <= 5; i++)
        {
          var filePath = filesPath + $"{i}.txt";
          var task = Task.Run(() => 
            {
              using (var render = new StreamReader(filePath, Encoding.UTF8))
              {
                var fileContent =  render.ReadToEnd();
                totalLength += fileContent.Length;
              }
            });
          tasks.Add(task);
        }
        await Task.WhenAll(tasks);
        // await Task.WhenAny(tasks);
        return totalLength;
      }
  }
}

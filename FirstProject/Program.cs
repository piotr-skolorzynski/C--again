﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace FirstProject
{
  internal class Program
  {
      static void Main(string[] args)
      {
          string csvPath = @"CSV_PATH";
          var googleApps = LoadGoogleAps(csvPath);

          Display(googleApps);
      }

      static void Display(IEnumerable<GoogleApp> googleApps)
      {
          foreach (var googleApp in googleApps)
          {
              Console.WriteLine(googleApp);
          }
      }
      static void Display(GoogleApp googleApp)
      {
          Console.WriteLine(googleApp);
      }

      static List<GoogleApp> LoadGoogleAps(string csvPath)
      {
          using (var reader = new StreamReader(csvPath))
          using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
          {
              csv.Context.RegisterClassMap<GoogleAppMap>();
              var records = csv.GetRecords<GoogleApp>().ToList();
              return records;
          }
      }
  }
}

using System;
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
          string csvPath = @"D:\Repos\26. C# basics\FirstProject\googleplaystore.csv";
          var googleApps = LoadGoogleAps(csvPath);

        //   Display(googleApps);
        // GetData(googleApps);
        // ProjectData(googleApps);
        // DivideData(googleApps);
        // OrderData(googleApps);
        // DataSetOperation(googleApps);
        DataVerification(googleApps);
      }

      static void DataVerification(IEnumerable<GoogleApp> googleApps)
      {
        var wheatherApps = googleApps.Where(a => a.Category == Category.WEATHER);

        var allOperatorResult = wheatherApps.All(a => a.Reviews > 10);
        Console.WriteLine($"allOperatorResult {allOperatorResult}");

        var allOperatorResult2 = wheatherApps.All(a => a.Reviews > 20);
        Console.WriteLine($"allOperatorResult2 {allOperatorResult2}");

        var anyOperatorResult = wheatherApps.Any(a => a.Reviews > 2_000_000);
        Console.WriteLine($"anyOperatorResult {anyOperatorResult}");

        var anyOperatorResult2 = wheatherApps.Any(a => a.Reviews > 3_000_000);
        Console.WriteLine($"anyOperatorResult {anyOperatorResult2}");
      }

      static void DataSetOperation(IEnumerable<GoogleApp> googleApps) 
      {
        var paidAppsCategories = googleApps.Where((app) => app.Type == Type.Paid)
              .Select(a => a.Category).Distinct(); //Distinct works like in JS Array.from(new Set([array with many values])) to set array of unique values

        // Console.WriteLine($"Paid apps categories: {string.Join(", ", paidAppsCategories)}");

        var setA = googleApps.Where(a => a.Rating > 4.7 && a.Type == Type.Paid && a.Reviews > 1000);
        var setB = googleApps.Where(a => a.Name.Contains("Pro") && a.Rating > 4.6 && a.Reviews > 10000);

        // Display(setA);
        // Console.WriteLine("*************");
        // Display(setB);

        // var appsUnion = setA.Union(setB);
        // Display(appsUnion);

        // var appsIntersect = setA.Intersect(setB);
        // Display(appsIntersect);

        var appsExcept = setA.Except(setB);
        Display(appsExcept);

      }

      static void OrderData(IEnumerable<GoogleApp> googleApps)
      {
        var highRatedBeautyApps = googleApps.Where(app => app.Rating > 4.4 && app.Category == Category.BEAUTY);
        //sorts ascending
        // var sortedResults = highRatedBeautyApps.OrderBy(app => app.Rating);
        //sorts descending
        var sortedResults = highRatedBeautyApps.OrderByDescending(app => app.Rating)
              .ThenBy(app => app.Name);
        Display(sortedResults);
      }

      static void DivideData(IEnumerable<GoogleApp> googleApps)
      {
        var highRatedBeautyApps = googleApps.Where(app => app.Rating > 4.4 && app.Category == Category.BEAUTY);

        // var first5HighRatedBeautyApps = highRatedBeautyApps.Take(5);
        // var highRatedBeautyAppsWithHighReviews = highRatedBeautyApps.TakeWhile(app => app.Reviews >= 1000);
        // Display(highRatedBeautyAppsWithHighReviews);

        var dataAfterSkipFirts5Apps = googleApps.Skip(5);
        //SkipLast
        //SkipWhile
        //similar to Take

      }

      static void ProjectData(IEnumerable<GoogleApp> googleApps) 
      {
        var highRatedBeautyApps = googleApps.Where(app => app.Rating > 4.6 && app.Category == Category.BEAUTY);
        
        //Choose only names
        // var highRatedBeautyAppsNames = highRatedBeautyApps.Select(app => app.Name);
        // Console.WriteLine(string.Join(", ", highRatedBeautyAppsNames));

        // var dtos = highRatedBeautyApps.Select(app => new GoogleAppDto()
        // {
        //     Name = app.Name,
        //     Reviews = app.Reviews
        // });

        // foreach (var dto in dtos) 
        // {
        //     Console.WriteLine($"{dto.Name}: {dto.Reviews}");
        // }

        // //selects and flatens
        // var genres = highRatedBeautyApps.SelectMany(app => app.Genres);
        // Console.WriteLine(string.Join(":", genres));

        //annonymous data type
        var annonymousDtos = highRatedBeautyApps.Select(app => new 
        {
            Name = app.Name,
            Reviews = app.Reviews
        });

        foreach (var dto in annonymousDtos)
        {
            Console.WriteLine($"{dto.Name}: ${dto.Reviews}");
        }
      }

      static void GetData(IEnumerable<GoogleApp> googleApps)
      {
        var highRatedBeautyApps = googleApps.Where(app => app.Rating > 4.6 && app.Category == Category.BEAUTY);
        Display(highRatedBeautyApps);

        //first element from collection
        var firtsHighRatedBeautyApp = highRatedBeautyApps.First();
        Console.WriteLine("First High Rated App");
        Display(firtsHighRatedBeautyApp);

        //first element from collection filtered by predicate sent to First operator
        // var firstHighRatedBeautyWithLowReviews = highRatedBeautyApps.First(app => app.Reviews < 300);
        // Console.WriteLine("First High Rated App with low reviews");
        // Display(firstHighRatedBeautyWithLowReviews);

        //if we do not want to have axception it is possible to replace First with FirstOrDefault operator and 
        // in case of no match default value will be null
        // var firstHighRatedBeautyWithLowReviews = highRatedBeautyApps.FirstOrDefault(app => app.Reviews < 50);
        // Console.WriteLine("First High Rated App with low reviews");
        // Display(firstHighRatedBeautyWithLowReviews);

        //Operator single
        // var firstHighRatedBeautyWithLowReviews = highRatedBeautyApps.Single(app => app.Reviews < 50);
        var firstHighRatedBeautyWithLowReviews = highRatedBeautyApps.SingleOrDefault(app => app.Reviews < 50);
        Console.WriteLine("First High Rated App with low reviews");
        Display(firstHighRatedBeautyWithLowReviews);

        // If we do not want to have no matching exception you can use SingleOrDefault operator

        //Operator Last - similiar to First, returns last element from collection and also has it version LastOrDefault
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

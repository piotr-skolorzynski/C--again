using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace FirstProject
{
  internal class Program
  {

      static async Task Main(string[] args)
      {
        using (var httpClient = new HttpClient())
        {
          var result = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");
          //zamiana wyniku na plik json
          var json = await result.Content.ReadAsStringAsync();
          //deserializacja json-a do listy obiektów Post
          var posts = JsonConvert.DeserializeObject<List<Post>>(json);
          var selectedPost = posts.First(p => p.Id == 30);
          Console.WriteLine($"title: {selectedPost.Title}");
          Console.WriteLine($"body: {selectedPost.Body}");

          // Można pracować bezpośrednio na takim obiekcie
          selectedPost.Title = "test title";
          selectedPost.Body = "test body";

          Console.WriteLine($"title: {selectedPost.Title}");
          Console.WriteLine($"body: {selectedPost.Body}");

          // Tworzenie ciała w postaci JSON do wysłania w metodzie POST
          // var postResult = await httpClient.PostAsync("https://jsonplaceholder.typicode.com/posts", postJsonContent);

          var postJsonContent = new StringContent(JsonConvert.SerializeObject(selectedPost));
          // zapytania można wykonywać również w inny sposób niż powyżej korzystajac z klasy HttpRequestMessage
          // poniższa klasa również implementuje interfejs IDisposable więc również powinna znajdować w using
          // using (var postRequestMessage = new HttpRequestMessage(HttpMethod.Post, "https://jsonplaceholder.typicode.com/posts"))
          // {
          //   // w przeciwieństwie do powyższego rozwiązania można dodać headers, ilość zależnie od potrzeb
          //   postRequestMessage.Headers.Add("content-type", "application/json");
          //   // ciało 
          //   postRequestMessage.Content = postJsonContent;
          //   // wysłanie na serwer tak utworzonego zapytania
          //   var post2Result = await httpClient.SendAsync(postRequestMessage);
          // }

          // tworzenie query params
          var queryParams = HttpUtility.ParseQueryString(string.Empty);
          queryParams["postId"] = "1"; //jest to klucz-wartość więc liczba musi być stringiem
          queryParams["someParam"] = "someValue";

          // sformatowana wartość w postaci stringa
          var formattedParams = queryParams.ToString();
          Console.WriteLine(formattedParams);
        }
      }
  }
}

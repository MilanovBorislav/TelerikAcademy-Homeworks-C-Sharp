using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace HttpRequestProject
{
    class Program
    {
        static async void ShowArticles(string query ,int count )
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync("http://api.feedzilla.com/v1/articles/search.json?q=" + query + "&count=" + count).Result;
            var jsonStr = response.Content.ReadAsStringAsync().Result;
            var articleList = JsonConvert.DeserializeObject<ArticleCollection>(jsonStr);
            Console.WriteLine();

            foreach (var item  in articleList.Articles)
            {
                var article =JsonConvert.DeserializeObject<Article>(item.ToString());
                Console.WriteLine("Title");
                Console.WriteLine(article.title);
                Console.WriteLine("Url");
                Console.WriteLine(article.source_url);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Write Query");
            string query = Console.ReadLine();
            Console.WriteLine("Write Count");
            string count = Console.ReadLine();
            int intCount = int.Parse(count);
            ShowArticles(query,intCount);
        }
    }
}

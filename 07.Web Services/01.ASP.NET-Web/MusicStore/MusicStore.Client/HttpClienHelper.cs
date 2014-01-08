using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MusicStore.Client
{
    public static class HttpClienHelper
    {
        public static readonly HttpClient Client = new HttpClient { BaseAddress = new Uri("http://localhost:53814/") };

        public static void ListItems<T>(string controller)
        {
            Client.DefaultRequestHeaders.Accept.Add(new
              MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response =
                Client.GetAsync("api/" + controller).Result;
            if (response.IsSuccessStatusCode)
            {
                var list = response.Content.ReadAsAsync<IEnumerable<T>>().Result;
                Console.WriteLine();
                Console.WriteLine((typeof(T).ToString().ToUpper()));
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})",
                    (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        public static void FindItem<T>(string controller, int id)
        {
            Client.DefaultRequestHeaders.Accept.Add(new
              MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response =
                Client.GetAsync("api/" + controller + "/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var obj = response.Content.ReadAsAsync<T>().Result;
                Console.WriteLine();
                Console.WriteLine("Finded Item");
                Console.WriteLine((typeof(T).ToString().ToUpper()));
                Console.WriteLine(obj);
            }
            else
            {
                Console.WriteLine("{0} ({1})",
                    (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        public static void AddItem(string controller, object item)
        {
            var response = Client.PostAsJsonAsync("api/" + controller, item).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Item added!");
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        public static void DeleteItem(string controller, int id)
        {
            HttpResponseMessage response =
              Client.DeleteAsync("api/" + controller + "/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Item deleted!");
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        public static void UpdateItem<T>(string controller, int objId, T item)
        {
        //http://localhost:53814/api/Artist/2
            var baseUrl = "http://localhost:53814/api/" + controller + "/" + objId;
            var response = Client.PutAsJsonAsync<T>(baseUrl, item).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Updated");
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }
    }
}

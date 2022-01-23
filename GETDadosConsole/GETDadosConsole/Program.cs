using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GETDadosConsole
{
    class Program
    {
        static  async Task Main(string[] args)
        {
            HttpClient client = new HttpClient { BaseAddress = new Uri("https://jsonplaceholder.typicode.com") };
            var response = await client.GetAsync("users");

            var content = await response.Content.ReadAsStringAsync();

            var users = JsonConvert.DeserializeObject<Users[]>(content);

            foreach (var item in users)
            {
                Console.WriteLine(item.Username +" - "+ item.Email);
            }
        }
    }
}

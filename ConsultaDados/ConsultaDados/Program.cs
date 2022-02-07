using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsultaDados
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient { BaseAddress = new Uri("https://jsonplaceholder.typicode.com/posts") };
            Console.WriteLine("Digite um numero entre 1 - 10");
            int numero = Int32.Parse(Console.ReadLine());

            var response = await client.GetAsync("posts?id=" + numero);

            var content = await response.Content.ReadAsStringAsync();

            var post = JsonConvert.DeserializeObject<Dados[]>(content);
            foreach(var item in post)
            {
                Console.WriteLine("Você escolheu o Post: " + item.id);
                Console.WriteLine("Titulo: " + item.title);
                Console.WriteLine("Texto: " + item.body); 
            }
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace GETDadosConsole
{
    class Program
    {
        private static Person person;

        static  async Task Main(string[] args)
        {
            HttpClient client = new HttpClient { BaseAddress = new Uri("https://jsonplaceholder.typicode.com") };
            var response = await client.GetAsync("users");

            var content = await response.Content.ReadAsStringAsync();

            var users = JsonConvert.DeserializeObject<Users[]>(content);

            foreach (var item in users)
            {
                person = new Person();
                person.first_name = item.Nome;
                person.username = item.Username;
                person.email = item.Email;

                DataBase.SalvaDados(person);


                if (DataBase.ret == 1)
                {
                    Console.WriteLine("Dados cadastrados");
                }
                else
                {
                    Console.WriteLine("Erro na conexão");
                }
            }
        }
    }
}

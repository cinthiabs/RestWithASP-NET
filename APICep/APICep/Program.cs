using Refit;
using System;
using System.Threading.Tasks;


namespace APICep
{
    class Program
    {
        static async Task Main (string[] args)
        {
            try
            {
                CepResponse response = new CepResponse();
                var cepClient = RestService.For<CepService>("https://viacep.com.br");
                
                Console.WriteLine("Informe seu cep");

                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Consultado informações do CEP: " + cepInformado);

                var address = cepClient.GetAddressAsync(cepInformado);
                Console.Write($"\nLogradouro: {response.logradouro},\nBairro: {response.bairro} \nCidade: {response.logradouro}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na consulta de cep: " + e.Message);
            }
        }
    }
}

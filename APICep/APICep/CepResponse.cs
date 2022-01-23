using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Refit;

namespace APICep
{
    public class CepResponse
    {

       [JsonProperty("cep")]      
       public string Cep { get; set; }
       
        [JsonProperty("logradouro")]
        public string logradouro { get; set; }
        
        [JsonProperty("complemento")]
        public string complemento { get; set; }
        
        [JsonProperty("bairro")]
        public string bairro { get; set; }

        [JsonProperty("localidade")]
        public string localidade { get; set; }

        [JsonProperty("uf")]
        public string uf { get; set; }

        internal object GetAddressAsync(string cepInformado)
        {
            throw new NotImplementedException();
        }

        [JsonProperty("ibge")]
        public string ibge { get; set; }

        [JsonProperty("gia")]
        public string gia { get; set; }

        [JsonProperty("ddd")]
        public string ddd { get; set; } 

    }
}

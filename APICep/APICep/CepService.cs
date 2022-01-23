using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APICep
{
    public interface CepService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse>GetAdressAsync(string cep);
        object GetAddressAsync(string cepInformado);
    }
}

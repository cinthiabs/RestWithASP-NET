using APICadastro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICadastro.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>(); // criando lista

        [HttpGet]
        public List<Cliente> GET()
        {
            return clientes;
        }
        public  void Post(string  nome)
        {
            if(!string.IsNullOrEmpty(nome)) // null ou vazio
                clientes.Add(new Cliente(nome));
        }
        public void Delete(string nome)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome))));
            
        }
    }
}

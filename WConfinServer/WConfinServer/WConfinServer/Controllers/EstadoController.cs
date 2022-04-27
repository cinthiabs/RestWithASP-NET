using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WConfinServer.Models;

namespace WConfinServer.Controllers
{
    [Route("api/[controller]")] // chamar a rota https://localhost:44300/api/Estado
    [ApiController]
    public class EstadoController : ControllerBase
    {
        public static List<Estado> lista = new List<Estado>();

        [HttpGet]
        public List<Estado> GetEstados()
        {
            return lista;
        }

        [HttpPost]
        public string PostEstado(Estado estado)
        {
            lista.Add(estado);

            return "Estado cadastrado com sucesso!";
        }

        [HttpPut]
        public string PutEstado(Estado estado)
        {
            Estado estadoAux = lista.Where(x => x.Sigla == estado.Sigla).FirstOrDefault();
            estadoAux.Nome = estado.Nome;
            return "Estado alterado com sucesso!";
        }

        [HttpDelete]
        public string DeleteEstado(Estado estado)
        {
            Estado estadoAux = lista.Where(x => x.Sigla == estado.Sigla).FirstOrDefault();
            lista.Remove(estadoAux);
            return "Estado excluido com sucesso!";
        }
    }
}

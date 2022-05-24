using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TemaController : ControllerBase
    {

        public TemaController()
        {
           
        }

        [HttpGet]
        public string Get()
        {
            return "Metodo Get chamado";
        }
        
        [HttpPost]
        public string Post()
        {
            return "Metodo Post chamado";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Metodo Put chamado id:{id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Metodo Delete chamado id: {id}";
        }
    }
}

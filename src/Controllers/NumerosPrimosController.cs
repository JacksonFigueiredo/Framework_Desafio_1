using FrameWork_Challenge_2.Negocio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameWork_Challenge_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumerosPrimosController : ControllerBase
    {


        private readonly ILogger<NumerosPrimosController> _logger;
        private readonly ICamadaNegocio _camadaNegocio;

        public NumerosPrimosController(ILogger<NumerosPrimosController> logger, ICamadaNegocio camadaNegocio)
        {
            _logger = logger;
            _camadaNegocio = camadaNegocio;
        }

        [HttpPost]
        public IActionResult Post([FromBody] NumerosPrimos entidade)
        {
            if (entidade == null)
            {
                return BadRequest();
            }
            else
            {
                 return new ObjectResult(_camadaNegocio.GerarNumerosPrimos(entidade.entrada));
           
            }
        }
    }
}

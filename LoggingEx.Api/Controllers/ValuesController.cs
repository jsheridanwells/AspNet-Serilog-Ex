using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace LoggingEx.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            Log.Information("Pedimos el controlador de valores");
            
            try
            {
                throw new Exception("Ay! Hubo un error grave.");
            }
            catch(Exception ex)
            {
                Log.Error($"Error en ControladorDeValores :: {ex.ToString()}");
            }
            return Ok("la repuesta");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Laboratorio0_RenatoCabrera_1010617.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        // GET: api/Peliculas
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Peliculas/5
        [HttpGet]
        public IEnumerable<Pelicula> Get()
        {
            return "value";
        }

        // POST: api/Peliculas
        [HttpPost]
        public string Test([FromBody]Pelicula peliculas)
        {
            var json = JsonConvert.SerializeObject(peliculas);
            Console.Write("¡Hecho!");
            return json;
        }

    }
}

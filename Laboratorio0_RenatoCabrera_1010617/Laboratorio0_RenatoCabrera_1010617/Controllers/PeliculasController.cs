using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace Laboratorio0_RenatoCabrera_1010617.Controllers
{
    [Route("api/PeliculasController")]
    [ApiController]

    public class PeliculasController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Pelicula> Get()
        {
            return Peliculas
        }

        [HttpPost]
        public string Test([FromBody]Pelicula peliculas)
        {
            var json = JsonConvert.SerializeObject(peliculas);
            Console.Write("¡Hecho!");
            
            return json;
        }

    }
}

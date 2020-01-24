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
        public List<DatosPelicula> Get()
        {
            List<DatosPelicula> aux = new List<DatosPelicula>();
            int CuentaPeliculas = RutaObjeto.Instancia.Peliculas.Count;

        }

        [HttpPost]
        public DatosPelicula Post([FromBody]DatosPelicula peliculas)
        {
            
        }

    }
}

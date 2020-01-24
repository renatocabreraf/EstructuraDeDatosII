using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio0_RenatoCabrera_1010617
{
    public class RutaObjeto
    {
        public List<Pelicula> Peliculas { get; set; }
    }

    public class Pelicula
    {
        public int id { get; set; }
        public string Nombre { get; set; }

        public int Anio { get; set; }

        public string Director { get; set; }
    }
}

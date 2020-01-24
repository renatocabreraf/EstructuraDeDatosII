using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio0_RenatoCabrera_1010617
{
    public class RutaObjeto
    {
        private static RutaObjeto i = null; //i es el nombre que escogí para la Instancia

        public static RutaObjeto Instance
        {
            get
            {
                if (i == null) i = new RutaObjeto();
                return i;
            }
        }

    public class Pelicula
    {
        public int id { get; set; }
        public string Nombre { get; set; }

        public int Anio { get; set; }

        public string Director { get; set; }
    }
}

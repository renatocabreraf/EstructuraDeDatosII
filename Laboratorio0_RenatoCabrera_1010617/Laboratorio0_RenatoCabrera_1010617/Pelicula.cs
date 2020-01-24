﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio0_RenatoCabrera_1010617
{
    public class RutaObjeto
    {
        private static RutaObjeto i = null; //i es el nombre que escogí para la Instancia

        public static RutaObjeto Instancia
        {
            get
            {
                if (i == null) i = new RutaObjeto();
                return i;
            }
        }

        private static Pelicula[] peliculas = {
            new Pelicula { ID = 1, Nombre = "Once Upon A Time... In Hollywood", Año = 2020, Director = "Quentin Tarantino"
            }
        };

        public Stack<Pelicula> Peliculas = new Stack<Pelicula>(peliculas);
    }
    public class Pelicula
    {
        public int ID {get; set;}
        public string Nombre { get; set; }
        public int Año { get; set; }
        public string Director { get; set; }
    }
}
       

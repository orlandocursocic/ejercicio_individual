﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicio_individual
{
    public class Pelicula
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public int Anyo { get; set; }
        public string Director { get; set; }
        public string Pais { get; set; }
    }
}
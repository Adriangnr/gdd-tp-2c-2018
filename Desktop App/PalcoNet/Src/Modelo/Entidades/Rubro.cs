﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Rubro
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public Rubro() { }

        public Rubro(int codigo, string desc)
        {
            this.Codigo = codigo;
            this.Descripcion = desc;
        }

        public override string ToString() {
            return this.Descripcion;
        }
    }
}

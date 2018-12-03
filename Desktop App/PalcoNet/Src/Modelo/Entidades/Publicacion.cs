﻿using PalcoNet.Src.Modelo.Estados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Publicacion : DatabaseEntity
    {
        /*int, date, string, date, int, string, int, int, string*/
        public int Codigo { get; set; }

        [DisplayName("Fecha de Evento")]
        public DateTime FechaEvento { get; set; }

        public string Descripcion { get; set; }

        [DisplayName("Fecha de Publicación")]
        public DateTime FechaPublicacion { get; set; }
		
        public Rubro Rubro { get; set; }
        public string Direccion { get; set; }
        public Grado Grado { get; set; }
        public Empresa Empresa { get; set; }
        public Estado Estado { get; set; }

        public Publicacion() {}

        public List<List<object>> SearchActivasValidas(System.Windows.Forms.Control.ControlCollection filters)
        {
            return Search(filters, this.GetType().Name + "ActivaValida");
        }

        public List<List<object>> SearchPagedPublicacion(int offset, int itemsPerPage)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>() {
                    new SqlParameter("@offset", offset),
                    new SqlParameter("@items", itemsPerPage)
                };

                return this.spExecuteDataReader(this.schema + ".SearchPagedPublicacion", parameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
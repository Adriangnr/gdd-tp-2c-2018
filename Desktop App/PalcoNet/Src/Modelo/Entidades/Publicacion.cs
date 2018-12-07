using PalcoNet.Src.Modelo.Estados;
using System;
using System.Collections.Generic;
using System.ComponentModel;

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

        public List<Ubicacion> ubicaciones { get; set; }
        public List<FechaHora> fechas { get; set; }

        private int empresaId;

        public Publicacion() {}

        public void setEmpresaId(int id)
        {
            this.empresaId = id;
        }

        public int getEmpresaId()
        {
            return this.empresaId;
        }
    }
}
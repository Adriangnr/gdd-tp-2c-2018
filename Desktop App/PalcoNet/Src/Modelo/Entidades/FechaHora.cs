using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class FechaHora : DatabaseEntity
    {
        private int codigoPublicacion;

        [DisplayName("Dia y Horario")]
        public DateTime fechaHora { get; set; }

        public FechaHora(DateTime fechaHora)
        {
            this.fechaHora = fechaHora;
        }

        public FechaHora(int codigoPublicacion, DateTime fechaHora)
        {
            this.codigoPublicacion = codigoPublicacion;
            this.fechaHora = fechaHora;
        }

        public void setCodigoPublicacion(int codigo)
        {
            this.codigoPublicacion = codigo;
        }

        public int getCodigoPublicacion()
        {
            return this.codigoPublicacion;
        }

        public override string ToString()
        {
            return this.fechaHora.ToString();
        }
    }
}

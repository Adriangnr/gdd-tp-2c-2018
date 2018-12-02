
namespace PalcoNet.Src.Modelo.Entidades
{
    public class Grado
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Comision { get; set; }

        public Grado(int id, string desc, double comision)
        {
            this.Id = id;
            this.Descripcion = desc;
            this.Comision = comision;
        }

        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}


namespace PalcoNet.Src.Modelo.Entidades
{
    public class Tipo_Ubicacion : DatabaseEntity
    {
        /*id, descripcion*/
        public int id { get; set; }
        public string descripcion { get; set; }

        public Tipo_Ubicacion() { }

        public Tipo_Ubicacion(int id, string desc)
        {
            this.id = id;
            this.descripcion = desc;
        }

        public override string ToString()
        {
            return this.descripcion;
        }
    }
}

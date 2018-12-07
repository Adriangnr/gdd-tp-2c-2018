
namespace PalcoNet.Src.Modelo.Entidades
{
    public class Tipo_Ubicacion : DatabaseEntity
    {
        /*id, descripcion*/
        public int id { get; set; }
        public string descripcion { get; set; }

        public override string ToString()
        {
            return this.descripcion;
        }
    }
}

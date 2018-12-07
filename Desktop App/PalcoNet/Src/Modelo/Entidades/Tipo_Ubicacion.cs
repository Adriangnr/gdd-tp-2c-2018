
namespace PalcoNet.Src.Modelo.Entidades
{
    public class Tipo_Ubicacion : DatabaseEntity
    {
        /*id, descripcion, menorFila, mayorFila, menorAsiento, mayorAsiento*/
        public int id { get; set; }
        public string descripcion { get; set; }
        public string menorFila { get; set; }
        public string mayorFila { get; set; }
        public string menorAsiento { get; set; }
        public string mayorAsiento { get; set; }
    }
}

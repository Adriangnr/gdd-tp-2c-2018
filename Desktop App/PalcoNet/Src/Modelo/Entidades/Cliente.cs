using System.ComponentModel;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Cliente : DatabaseEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        [DisplayName("Numero de documento")]
        public string NumDoc { get; set; }

        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Habilitado { get; set; }
        public string TipoDoc { get; set; }
        public string Cuil { get; set; }
        public string FechaNacimiento { get; set; }
        public string DatosTarjeta { get; set; }
        public Usuario UsuarioObj { get; set; }
        

    }
}

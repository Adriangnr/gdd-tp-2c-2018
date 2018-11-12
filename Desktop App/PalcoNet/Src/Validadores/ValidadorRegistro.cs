using PalcoNet.Src.Excepciones;
using System;
using System.Windows.Forms;

namespace PalcoNet.Src.Validadores
{
    class ValidadorRegistro : Validador
    {
        public void textBox_usuario(TextBox username)
        {
            if( username.Text == "")
            {
                throw new ValidadorException("Falta el usuario");
            }
        }

        public void textBox_contrasena(TextBox contrasena)
        {
            Console.WriteLine("Validando contrasenia");
        }

        public void textBox_mail(TextBox mail)
        {
            Console.WriteLine("Validando mail");
        }

        public void textBox_telefono(TextBox telefono)
        {
            Console.WriteLine("Validando telefono");
        }
        /*
         FUTURO METODO -> groupBox2
FUTURO METODO -> groupBox1
FUTURO METODO -> label5
FUTURO METODO -> 
FUTURO METODO -> label4
FUTURO METODO -> 
FUTURO METODO -> register_title
FUTURO METODO -> label2
FUTURO METODO -> 
FUTURO METODO -> label1
FUTURO METODO -> 
FUTURO METODO -> link_limpiar
FUTURO METODO -> register_btn_cancel
FUTURO METODO -> register_btn_registrar
FUTURO METODO -> panel_roldata
FUTURO METODO -> footer
FUTURO METODO -> title
         */
    }
}

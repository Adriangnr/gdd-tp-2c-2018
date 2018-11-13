using PalcoNet.Src.Excepciones;
using System;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PalcoNet.Src.Validadores
{
    class ValidadorRegistro : Validador
    {
        public void textBox_usuario(TextBox username)
        {
            if( username.Text == "")
            {
                throw new ValidadorException("El nombre de usuario es un campo requerido!");
            }
            else
            {
                Regex pattern = new Regex("^[a-zA-Z0-9_-]{3,15}$");
                if (!pattern.IsMatch(username.Text))
                {
                    throw new ValidadorException("El nombre de usuario no cumple con el minimo de caracteres (3) o posee caracteres invalidos!");
                }
            }
        }

        public void textBox_contrasena(TextBox contrasena)
        {
            if (contrasena.Text == "")
            {
                throw new ValidadorException("La contrasenia es un campo requerido!");
            }
            else
            {
                Regex pattern = new Regex("^.{4,15}$");
                if (!pattern.IsMatch(contrasena.Text))
                {
                    throw new ValidadorException("La contraseña debe tener minimo tres (3) y maximo quince (15) caracteres!");
                }
            }
        }

        public void textBox_mail(TextBox mail)
        {
            if (mail.Text == "")
            {
                throw new ValidadorException("El mail es un campo requerido!");
            }
            else
            {
                try
                {
                    MailAddress m = new MailAddress(mail.Text);
                }
                catch (FormatException)
                {
                    throw new ValidadorException("El mail es invalido!");
                }
            }
        }

        public void textBox_telefono(TextBox telefono)
        {
            this.validarCampoTexto(telefono, "Telefono", new Regex(@"^\D?(\d{3})\D?\D?(\d{3})\D?(\d{4})$"));
        }

        public void groupBoxDireccion(GroupBox direccion)
        {
            this.validar(direccion.Controls);
        }

        public void panel_roldata(Panel roldata)
        {
            this.validar(roldata.Controls);
        }

        protected void textBox_calle(TextBox calle)
        {
            this.validarCampoTexto(calle, "Calle", new Regex("^[a-zA-Z0-9_.-]*$"));
        }
        
        protected void textBox_piso(TextBox piso)
        {
            this.validarCampoTexto(piso, "Piso", new Regex("^[a-zA-Z0-9]{1,3}$"));
         }

        protected void textBox_depto(TextBox depto)
        {
            this.validarCampoTexto(depto, "Depto", new Regex("^[a-zA-Z0-9]{1,3}$"));
        }

        protected void textBox_localidad(TextBox localidad)
        {
            this.validarCampoTexto(localidad, "Localdad", new Regex(@"^[a-zA-Z0-9\.,]*$"));
        }

        protected void textBox_cp(TextBox cp)
        {
            this.validarCampoTexto(cp, "CP", new Regex(@"^\d{5}$"));
        }

        protected void nombre(TextBox nombreCliente)
        {
            this.validarCampoTexto(nombreCliente, "Nombre", new Regex(@"^[a-zA-Z]+(([\'\,\.\-][a-zA-Z])?[a-zA-Z]*)*$"));
        }

        protected void apellido(TextBox apellidoCliente)
        {
            this.validarCampoTexto(apellidoCliente, "Apellido", new Regex(@"^[a-zA-Z]+(([\'\,\.\-][a-zA-Z])?[a-zA-Z]*)*$"));
        }

        protected void nrodoc(TextBox nrodocCliente)
        {
            this.validarCampoTexto(nrodocCliente, "Numero de documento", new Regex(@"^[0-9]{8,8}$"));
        }

        protected void cuil(TextBox cuilCliente)
        {
            this.validarCampoTexto(cuilCliente, "Cuil", new Regex(@"^[0-9]{2}-[0-9]{8}-[0-9]$"));
        }

        protected void razonSocial(TextBox razonSocial)
        {
            this.validarCampoTexto(razonSocial, "Razon Social", new Regex(@"^[a-zA-Z]+(([\'\,\.\-][a-zA-Z])?[a-zA-Z]*)*$"));
        }

        protected void cuit(TextBox cuitEmpresa)
        {
            this.validarCampoTexto(cuitEmpresa, "Cuit", new Regex(@"^[0-9]{2}-[0-9]{8}-[0-9]$"));
        }

        protected void ciudad(TextBox ciudadEmpresa)
        {
            this.validarCampoTexto(ciudadEmpresa, "Ciudad", new Regex(@"^[a-zA-Z]+(([\'\,\.\-][a-zA-Z])?[a-zA-Z]*)*$"));
        }
    }
}

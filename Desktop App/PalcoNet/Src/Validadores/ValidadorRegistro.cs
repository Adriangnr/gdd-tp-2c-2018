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
            this.validarCampoTexto(telefono, "Telefono", new Regex(@"^[0-9]{4,20}$"));
        }

        public void groupBoxDireccion(GroupBox direccion)
        {
            this.validar(direccion.Controls);
        }

        public void panel_roldata(Panel roldata)
        {
            this.validar(roldata.Controls[0].Controls);
        }

        public void textBox_calle(TextBox calle)
        {
            this.validarCampoTexto(calle, "Calle", new Regex(@"^[a-zA-Z0-9_.\- ]$*"));
        }

        public void textBox_piso(TextBox piso)
        {
            this.validarCampoTexto(piso, "Piso", new Regex("^[a-zA-Z0-9 ]{1,3}$"));
         }

        public void textBox_depto(TextBox depto)
        {
            this.validarCampoTexto(depto, "Depto", new Regex("^[a-zA-Z0-9 ]{1,3}$"));
        }

        public void textBox_localidad(TextBox localidad)
        {
            this.validarCampoTexto(localidad, "Localidad", new Regex(@"^[a-zA-Z0-9\., ]*$"));
        }

        public void textBox_cp(TextBox cp)
        {
            this.validarCampoTexto(cp, "CP", new Regex(@"^\d{2,5}$"));
        }

        public void nombre(TextBox nombreCliente)
        {
            if (nombreCliente.Text == "")
            {
                throw new ValidadorException("El campo Nombre es requerido!");
            }
            this.validarCampoTexto(nombreCliente, "Nombre", new Regex(@"^[a-zA-Z ]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z ]*)*$"));
        }

        public void apellido(TextBox apellidoCliente)
        {
            this.validarCampoTexto(apellidoCliente, "Apellido", new Regex(@"^[a-zA-Z ]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z ]*)*$"));
        }

        public void nrodoc(TextBox nrodocCliente)
        {
            if (nrodocCliente.Text == "")
            {
                throw new ValidadorException("El campo Numero de documento es requerido!");
            }
            this.validarCampoTexto(nrodocCliente, "Numero de documento", new Regex(@"^[0-9]{6,8}$"));
        }

        public void cuil(TextBox cuilCliente)
        {
            if (cuilCliente.Text == "")
            {
                throw new ValidadorException("El campo Cuil es requerido!");
            }
            this.validarCampoTexto(cuilCliente, "Cuil", new Regex(@"^(20|23)-[0-9]{6,8}-[0-9]$"));
        }

        public void nacimiento(DateTimePicker nacimiento)
        {
            if (DateTime.Compare(nacimiento.Value, Utils.Utilities.getCurrentDate()) > 0)
            {
                throw new ValidadorException("Fecha de nacimiento invalida!");
            }
        }

        public void razonSocial(TextBox razonSocial)
        {
            if (razonSocial.Text == "")
            {
                throw new ValidadorException("El campo Razon Social es requerido!");
            }
            this.validarCampoTexto(razonSocial, "Razon Social", new Regex(@"^[a-zA-Z ]+(([\'\,\.\-][a-zA-Z ])?[a-zA-Z ]*)*$"));
        }

        public void cuit(TextBox cuitEmpresa)
        {
            if (cuitEmpresa.Text == "")
            {
                throw new ValidadorException("El campo Cuit es requerido!");
            }
            this.validarCampoTexto(cuitEmpresa, "Cuit", new Regex(@"^30-[0-9]{6,8}-[0-9]$"));
        }

        public void ciudad(TextBox ciudadEmpresa)
        {
            this.validarCampoTexto(ciudadEmpresa, "Ciudad", new Regex(@"^[a-zA-Z ]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z ]*)*$"));
        }

        public void tarjeta(TextBox tarjeta)
        {
            this.validarCampoTexto(tarjeta, "Numero de tarjeta", new Regex(@"^[0-9]{16}$"));
        }

        public void tarjetaNueva(TextBox tarjeta)
        {
            if (tarjeta.Text == "")
            {
                throw new ValidadorException("El número de tarjeta no puede estar vacío!");
            }
            if(tarjeta.Text.Length != 16)
                throw new ValidadorException("El cantidad de números de la tarjeta debe ser 16!");
            this.validarCampoTexto(tarjeta, "Numero de tarjeta", new Regex(@"^[0-9]{16}$"));
        }
    }
}

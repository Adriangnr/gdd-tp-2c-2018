using PalcoNet.Src.Excepciones;
using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using PalcoNet.Src.Validadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.General
{
    public partial class Cambio_Password : Master
    {
        private string username;

        public Cambio_Password(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void btn_cambiarPass_Click(object sender, EventArgs e)
        {

            if (string.Equals(textBox_contrasena.Text, repeticionPassword.Text))
            {
                try
                {
                    ValidadorRegistro validReg = new ValidadorRegistro();
                    validReg.validar(this.Controls);
                    UsuarioService usuarioService = (UsuarioService)ServiceFactory.GetService("Usuario");
                    usuarioService.cambioPassword(this.username, textBox_contrasena.Text);
                    MessageBox.Show("Se cambio la contraseña con exito!", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (ValidadorException exception)
                {
                    MessageBox.Show(exception.Message, "Error en cambio de contraseña.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                repeticionPassword.Text = "";
                MessageBox.Show("Las contraseñas no coinciden", "Erroren  cambio de contraseña",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.previous.Show();
        }

        private void Cambio_Password_Load(object sender, EventArgs e)
        {

        }

    }
}

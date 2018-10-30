using PalcoNet.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Login
{
    public partial class Login : Layouts.Master
    {
        int intentosFallidos;

        public Login()
        {
            InitializeComponent();
            this.AcceptButton = login_btn_entrar;
            this.intentosFallidos = 0;
        }

        private void login_btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_btn_entrar_Click(object sender, EventArgs e)
        {
            var username = login_tbox_usuario.Text;
            var password = login_tbox_password.Text;

            if (username == "" && password == "")
            {
                MessageBox.Show("Debe ingresar valores.", "Error al inicio de sesión.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else if (username == "")
            {
                MessageBox.Show("Debe ingresar usuario.", "Error al inicio de sesión.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (password == "")
            {
                MessageBox.Show("Debe ingresar contraseña.", "Error al inicio de sesión.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int result = Database.spExecuteScalar("ESECUELE.Login",
                                        new List<SqlParameter> {
                                                        new SqlParameter("@username", username),
                                                        new SqlParameter("@plain_password", password)
            });

            switch (result)
            {
                case 0:
                    {
                        //new AbmRol.RoleLoginSelection(this, username).Show();
                        //this.Hide();
                        MessageBox.Show(String.Format("Se deberian elegir roles."));
                        break;
                    }
                case -1:
                    {
                        MessageBox.Show(@"El usuario se encuentra deshabilitado.");
                        break;
                    }
                case -2:
                    {
                        intentosFallidos++;
                        MessageBox.Show(String.Format("Contraseña incorrecta. Tiene {0} intentos restantes.", 3 - intentosFallidos));
                        break;
                    }
                case -3:
                    {
                        MessageBox.Show(@"El usuario no existe.");
                        break;
                    }
                default:
                    {
                        intentosFallidos = 0;
                        //new MenuPrincipal.MainMenu(this, Role.Get(result, username)).Show();
                        //this.Hide();
                        MessageBox.Show(String.Format("El usuario tiene solo 1 rol"));
                        break;
                    }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void login_label_titulo_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_registrar_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void login_tbox_password_Click(object sender, EventArgs e)
        {
            login_tbox_password.UseSystemPasswordChar = true;
            login_tbox_password.Text = "";
        }

        private void login_tbox_usuario_Click(object sender, EventArgs e)
        {
            login_tbox_usuario.Text = "";
        }
    }
}

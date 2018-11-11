using System;
using PalcoNet.Src.Servicios;
using System.Windows.Forms;
using PalcoNet.Src.Servicios.ServiceFactory;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Forms.Layouts;

namespace PalcoNet.Src.Forms.Vistas.General
{
    public partial class Login : Master
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

            /*
             Aca llamo a ServiceFactory y le paso el nombre del servicio que quiero. Hay que castearlo, porque 
             la factory devuelve un servicio generico que se llama DatabaseService.
             */
            LoginService loginService = (LoginService)ServiceFactory.GetService("LoginService");
            int result = loginService.GetLogin(username, password);
            
            switch (result)
            {
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
                case -4:
                    {
                        MessageBox.Show(@"El usuario no tiene roles asignados.");
                        break;
                    }
                case -5:
                    {
                        UserService usrService = (UserService)ServiceFactory.GetService("UserService");
                        Usuario usr = usrService.GetUser(username);
                        new Selector_Rol(this, usr).Show();
                        this.Hide();
                        break;
                    }
                default:
                    {
                        intentosFallidos = 0;
                        UserService usrService = (UserService)ServiceFactory.GetService("UserService");
                        Usuario usr = usrService.GetUser(username);
                        //new MenuPrincipal.MainMenu(this, Usuario).Show();
                        //this.Hide();
                        MessageBox.Show(String.Format("El usuario tiene solo 1 rol"));
                        break;
                    }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = login_tbox_usuario;
        }

        private void login_label_titulo_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_registrar_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro(this);
            registro.Show();
            this.Hide();
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

        private void login_tbox_usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using PalcoNet.Src.Servicios;
using System.Windows.Forms;
using PalcoNet.Src.Servicios.ServiceFactory;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Forms.Layouts;
using System.Configuration;
using PalcoNet.Properties;
using System.Data.SqlClient;

namespace PalcoNet.Src.Forms.Vistas.General
{
    public partial class Login : Master
    {
        private bool cambioUsuario = false;
        private bool cambioPass = false;
        private bool ingresoUsuario = false;
        private bool ingresoPass = false;

        public Login()
        {
            InitializeComponent();
            this.ActiveControl = titulo;
            
            login_tbox_usuario.LostFocus += login_tbox_usuario_LostFocus;
            login_tbox_usuario.GotFocus += login_tbox_usuario_GotFocus;
            login_tbox_usuario.KeyDown += login_tbox_usuario_KeyDown;
            login_tbox_usuario.TextChanged += login_tbox_usuario_TextChanged;
            login_tbox_password.LostFocus += login_tbox_password_LostFocus;
            login_tbox_password.GotFocus += login_tbox_password_GotFocus;
            login_tbox_password.KeyDown += login_tbox_password_KeyDown;
            login_tbox_password.TextChanged += login_tbox_password_TextChanged;
        }

        public void clearFields()
        {
            Utils.Utilities.clearForm(this.Controls);
        }

        void login_tbox_password_GotFocus(object sender, EventArgs e)
        {
            login_tbox_password_Click(sender, e);
        }

        void login_tbox_usuario_GotFocus(object sender, EventArgs e)
        {
            login_tbox_usuario_Click(sender, e);
        }

        void login_tbox_usuario_TextChanged(object sender, EventArgs e)
        {
            cambioUsuario = true;
        }

        void login_tbox_password_TextChanged(object sender, EventArgs e)
        {
            cambioPass = true;
        }

        void login_tbox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (login_tbox_password.Text != "" && cambioPass)
                    ingresoPass = true;
                login_btn_entrar_Click(sender, new EventArgs());
            }
        }

        void login_tbox_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (login_tbox_usuario.Text != "" && cambioUsuario)
                    ingresoUsuario = true;
                login_btn_entrar_Click(sender, new EventArgs());
            }
        }

        void login_tbox_password_LostFocus(object sender, EventArgs e)
        {
            if (login_tbox_password.Text == "")
            {
                login_tbox_password.Text = "password";
                this.ingresoPass = false;
            }
            else
                this.ingresoPass = true;
        }

        void login_tbox_usuario_LostFocus(object sender, EventArgs e)
        {
            if (login_tbox_usuario.Text == "")
            {
                login_tbox_usuario.Text = "Usuario";
                this.ingresoUsuario = false;
            }
            else
                this.ingresoUsuario = true;
        }

        private void login_btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_btn_entrar_Click(object sender, EventArgs e)
        {
            var username = login_tbox_usuario.Text;
            var password = login_tbox_password.Text;

            if ( !ingresoUsuario && !ingresoPass )
            {
                MessageBox.Show("Debe ingresar valores.", "Error al inicio de sesión.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!ingresoUsuario)
            {
                MessageBox.Show("Debe ingresar usuario.", "Error al inicio de sesión.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!ingresoPass)
            {
                MessageBox.Show("Debe ingresar contraseña.", "Error al inicio de sesión.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /*
             Aca llamo a ServiceFactory y le paso el nombre del servicio que quiero. Hay que castearlo, porque 
             la factory devuelve un servicio generico que se llama DatabaseService.
             */
            LoginService loginService = (LoginService)ServiceFactory.GetService("Login");
            int result;
            try
            {
                result = loginService.GetLogin(username, Utils.Utilities.Hash(password));

                if(result == 4)
                    {
                        UsuarioService usrService = (UsuarioService)ServiceFactory.GetService("Usuario");
                        Usuario usr = usrService.GetUser(username);
                        new Selector_Rol(this, usr).Show();
                        this.Hide();
                    }
                else if(result > 0)
                    {
                        UsuarioService usrService = (UsuarioService)ServiceFactory.GetService("Usuario");
                        Usuario usr = usrService.GetUser(username);
                        new MenuPrincipal(this, usr).Show();
                        this.Hide();
                    }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error Login",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Login_Load(object sender, EventArgs e)
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
            if(!ingresoPass)
                login_tbox_password.Text = "";
        }

        private void login_tbox_usuario_Click(object sender, EventArgs e)
        {
            if (!ingresoUsuario)
            {
                login_tbox_usuario.Text = "";
            }
        }

    }
}

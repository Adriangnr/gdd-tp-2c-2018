using PalcoNet.Servicios;
using PalcoNet.Servicios.ServiceFactory;
using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Forms.Vistas.Administrador;
using PalcoNet.Src.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.General
{
    public partial class Registro : Master
    {
        public Registro(Form previous)
        {
            this.previous = previous;
            InitializeComponent();
            this.rolSelector.DataSource = new List<string> { "Cliente", "Empresa" };
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void register_btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.previous.Show();
        }

        private Dictionary<string, string> loadUserParams()
        {
            Dictionary<string, string> userParams = new Dictionary<string, string>();
            userParams.Add("usr_username", this.textBox_usuario.Text);
            userParams.Add("usr_pass", this.textBox_contrasena.Text);
            userParams.Add("usr_tipo", (string)this.rolSelector.SelectedItem);
            userParams.Add("usr_email", this.textBox_mail.Text);
            userParams.Add("usr_telefono", textBox_telefono.Text);
            userParams.Add("usr_direccion", textBox_calle.Text + ", piso " + textBox_piso.Text + ", depto "
                + textBox_depto.Text + ", " + textBox_localidad.Text);
            userParams.Add("usr_codigo_postal", textBox_cp.Text);

            return userParams;
        }

        private void loadUserTypeParams(Dictionary<string, string> userParams)
        {
            if(userParams["usr_tipo"] == "Cliente")
            {

            }
            else
            {

            }
        }

        private void register_btn_registrar_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> userParams = this.loadUserParams();
            this.loadUserTypeParams(userParams);

            UserService usrService = (UserService)ServiceFactory.GetService("UserService");
            //UserService.save(userParams);

            MessageBox.Show("Crear la entidad Usuario. Crear la entidad tipo de usuario y metarla dentro de " +
                "Usuario. Guardar usuario. Redireccionar a Login.");
            this.Hide();
            this.previous.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rolSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("PalcoNet.Src.Forms.Vistas.Administrador." + (string)this.rolSelector.SelectedItem + "_Registro");
            this.panel_roldata.Controls.Clear();
            UserControl typeRegister =
                Utilities.createInstance("PalcoNet.Src.Forms.Vistas.Administrador."+ (string)this.rolSelector.SelectedItem + "_Registro") as UserControl;
            this.panel_roldata.Controls.Add(new Cliente_Registro());        
        }
    }
}

using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using PalcoNet.Src.Excepciones;
using PalcoNet.Src.Validadores;

namespace PalcoNet.Src.Forms.Vistas.General
{
    public partial class Registro : Master
    {
        public Registro() { }

        public bool fromAdmin { get; set; }

        public Registro(Form previous)
        {
            this.previous = previous;
            InitializeComponent();
            this.rolSelector.DataSource = new List<string> { "Cliente", "Empresa" };
        }

        public void setearTipoUsuario(string tipo)
        {
            this.rolSelector.SelectedItem = tipo;
            this.rolSelector.Enabled = false;
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
            userParams.Add("usr_pass", Utils.Utilities.Hash(this.textBox_contrasena.Text));
            userParams.Add("usr_tipo", (string)this.rolSelector.SelectedItem);
            userParams.Add("usr_email", this.textBox_mail.Text);
            userParams.Add("usr_telefono", textBox_telefono.Text);
            userParams.Add("usr_direccion", textBox_calle.Text + "," + textBox_piso.Text + ","
                + textBox_depto.Text + "," + textBox_localidad.Text);
            userParams.Add("usr_codigo_postal", textBox_cp.Text);

            if (this.fromAdmin)
            {
                userParams.Add("usr_primer_login", "true");
            }
            else
            {
                userParams.Add("usr_primer_login", "false");
            }

            this.loadUserTypeParams(userParams);

            return userParams;
        }

        private void loadUserTypeParams(Dictionary<string, string> userParams)
        {
            if(userParams["usr_tipo"] == "Cliente")
            {
                userParams.Add("cliente_nombre", this.panel_roldata.Controls[0].Controls["nombre"].Text);
                userParams.Add("cliente_apellido", this.panel_roldata.Controls[0].Controls["apellido"].Text);
                userParams.Add("cliente_tipo_doc", this.panel_roldata.Controls[0].Controls["doc"].Text);
                userParams.Add("cliente_num_doc", this.panel_roldata.Controls[0].Controls["nrodoc"].Text);
                userParams.Add("cliente_cuil", this.panel_roldata.Controls[0].Controls["cuil"].Text);
                userParams.Add("cliente_fecha_nacimiento", this.panel_roldata.Controls[0].Controls["nacimiento"].Text);
                userParams.Add("cliente_datos_tarjeta", this.panel_roldata.Controls[0].Controls["tarjeta"].Text);
                userParams.Add("cliente_usuario", this.textBox_usuario.Text);
            }
            else
            {
                userParams.Add("empresa_razon_social", this.panel_roldata.Controls[0].Controls["razonSocial"].Text);
                userParams.Add("empresa_ciudad", this.panel_roldata.Controls[0].Controls["ciudad"].Text);
                userParams.Add("empresa_cuit", this.panel_roldata.Controls[0].Controls["cuit"].Text);
                userParams.Add("empresa_usuario", this.textBox_usuario.Text);
            }
        }

        private void register_btn_registrar_Click(object sender, EventArgs e)
        {
            try {
                ValidadorRegistro validReg = new ValidadorRegistro();
                validReg.validar(this.Controls);
                Dictionary<string, string> userParams = this.loadUserParams();
                UsuarioService usrService = (UsuarioService)ServiceFactory.GetService("Usuario");
                usrService.save(userParams);
                MessageBox.Show("Usuario guardado con exito!", "Nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(ValidadorException exception)
            {
                MessageBox.Show(exception.Message, "Error al registrar el usuario.",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (SqlException excep)
            {
                Console.WriteLine(excep.Message);
                if(excep.Message.Contains("Usuario"))
                    MessageBox.Show("El usuario ya existe!", "Error al registrar el usuario."
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (excep.Message.Contains("Cliente"))
                    MessageBox.Show("Ya existe un cliente con ese documento/CUIL!", "Error al registrar el usuario."
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (excep.Message.Contains("Empresa"))
                    MessageBox.Show("Ya existe una empresa con ese CUIT!", "Error al registrar el usuario."
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(excep.Message, "Error al registrar el usuario."
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            this.Hide();
            this.previous.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rolSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.panel_roldata.Controls.Clear();
            UserControl typeRegister =
                Utilities.createInstance("PalcoNet.Src.Forms.Vistas.Administrador."+ (string)this.rolSelector.SelectedItem + "_Registro") as UserControl;
            this.panel_roldata.Controls.Add(typeRegister);        
        }

        private void limpiarFormulario(Control.ControlCollection campos)
        {
            Utilities.clearForm(campos);
        }

        private void link_limpiar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.limpiarFormulario(this.Controls);
        }
    }
}

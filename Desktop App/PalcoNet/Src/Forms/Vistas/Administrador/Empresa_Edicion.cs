using PalcoNet.Src.Excepciones;
using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using PalcoNet.Src.Validadores;
using System;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Empresa_Edicion : Master
    {
        PalcoNet.Src.Modelo.Entidades.Empresa empresa;
        EmpresaService empresaService = (EmpresaService)ServiceFactory.GetService("Empresa");
        public bool fromMenu { get; set; }

        public Empresa_Edicion()
        {
            InitializeComponent();
            this.panel_dataempresa.Controls.Add(new Empresa_Registro());
        }

        public Empresa_Edicion(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.panel_dataempresa.Controls.Add(new Empresa_Registro());
            if(this.empresa == null && this.usuario != null)
            {
                this.empresa = empresaService.GetEmpresa(this.usuario.getEmpresaId());
                this.loadData(this.empresa);
            }
        }

        public void loadData(PalcoNet.Src.Modelo.Entidades.Empresa empresa)
        {
            this.empresa = empresa;
            this.textBox_usuario.Text = empresa.Usuario;
            this.textBox_mail.Text = empresa.UsuarioObj.Email;
            this.textBox_telefono.Text = empresa.UsuarioObj.Telefono;
            this.textBox_calle.Text = (this.usuario.Username == "admin") ? "" : empresa.UsuarioObj.Direccion.Split(',')[0];
            this.textBox_cp.Text = empresa.UsuarioObj.CodigoPostal;
            this.textBox_depto.Text = (this.usuario.Username == "admin") ? "" : empresa.UsuarioObj.Direccion.Split(',')[2];
            this.textBox_localidad.Text = (this.usuario.Username == "admin") ? "" : empresa.UsuarioObj.Direccion.Split(',')[3];
            this.textBox_piso.Text = (this.usuario.Username == "admin") ? "" : empresa.UsuarioObj.Direccion.Split(',')[1];
            this.panel_dataempresa.Controls[0].Controls["razonSocial"].Text = empresa.RazonSocial;
            this.panel_dataempresa.Controls[0].Controls["cuit"].Text = empresa.Cuit;
            this.panel_dataempresa.Controls[0].Controls["ciudad"].Text = empresa.Ciudad;
        }

        private void register_btn_cancel_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Hide();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidadorRegistro validReg = new ValidadorRegistro();
                validReg.validar(this.Controls);
                this.empresa.RazonSocial = this.panel_dataempresa.Controls[0].Controls["razonSocial"].Text;
                this.empresa.Ciudad = this.panel_dataempresa.Controls[0].Controls["ciudad"].Text;
                this.empresa.Cuit = this.panel_dataempresa.Controls[0].Controls["cuit"].Text;
                this.empresa.Usuario = this.textBox_usuario.Text;
                this.empresa.UsuarioObj.CodigoPostal = this.textBox_cp.Text;
                this.empresa.UsuarioObj.Direccion = this.textBox_calle.Text + "," + this.textBox_depto.Text + "," + this.textBox_piso.Text + "," + this.textBox_localidad.Text;
                this.empresa.UsuarioObj.Telefono = this.textBox_telefono.Text;
                this.empresa.UsuarioObj.Email = this.textBox_mail.Text;
                this.empresa.UsuarioObj.Username = this.textBox_usuario.Text;

                if (this.panel_datausuario.Controls["textBox_pass"].Text != "")
                {
                    this.empresa.UsuarioObj.Password = Utils.Utilities.Hash( this.panel_datausuario.Controls["textBox_pass"].Text);
                    UsuarioService usrService = (UsuarioService)ServiceFactory.GetService("Usuario");
                    usrService.updatePassword(this.empresa.UsuarioObj);
                }

                empresaService.update(this.empresa);
                
                MessageBox.Show("Empresa actualizada con éxito!", "Actualizar empresa.",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!this.fromMenu)
                {
                    ((Empresa_Listado)this.previous).cargarListadoEmpresas();   
                }
                this.previous.Show();
                this.Hide();
            }
            catch (ValidadorException exception)
            {
                MessageBox.Show(exception.Message, "Error al registrar el usuario.",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al editar la empresa!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                this.previous.Show();
                this.Hide();
            }
        }
    }
}

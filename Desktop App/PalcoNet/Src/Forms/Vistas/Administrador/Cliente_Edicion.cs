using PalcoNet.Src.Excepciones;
using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Validadores;
using System;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Cliente_Edicion : Master
    {
        PalcoNet.Src.Modelo.Entidades.Cliente client;

        public Cliente_Edicion()
        {
            InitializeComponent();
            this.panel_datacliente.Controls.Add(new Cliente_Registro());
        }

        public void loadData(PalcoNet.Src.Modelo.Entidades.Cliente client)
        {
            this.client = client;
            this.textBox_usuario.Text = client.Usuario;
            this.textBox_mail.Text = client.UsuarioObj.Email;
            this.textBox_telefono.Text = client.UsuarioObj.Telefono;
            this.textBox_calle.Text = client.UsuarioObj.Direccion.Split(',')[0];
            this.textBox_cp.Text = client.UsuarioObj.CodigoPostal;
            this.textBox_depto.Text = client.UsuarioObj.Direccion.Split(',')[2];
            try
            {
                this.textBox_localidad.Text = client.UsuarioObj.Direccion.Split(',')[3];
            }catch(Exception)
            {
                this.textBox_localidad.Text = "";
            }

            try
            {
                this.textBox_piso.Text = client.UsuarioObj.Direccion.Split(',')[1];
            }
            catch (Exception)
            {
                this.textBox_piso.Text = "";
            }
            
            this.panel_datacliente.Controls[0].Controls["nombre"].Text = client.Nombre;
            this.panel_datacliente.Controls[0].Controls["apellido"].Text = client.Apellido;
            this.panel_datacliente.Controls[0].Controls["nrodoc"].Text = client.NumDoc;
            this.panel_datacliente.Controls[0].Controls["doc"].Text = client.TipoDoc; 
            this.panel_datacliente.Controls[0].Controls["cuil"].Text = client.Cuil;
            this.panel_datacliente.Controls[0].Controls["nacimiento"].Text = client.FechaNacimiento;
        }

        private void register_btn_cancel_Click(object sender, System.EventArgs e)
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
                this.client.Apellido = this.panel_datacliente.Controls[0].Controls["Apellido"].Text;
                this.client.Nombre = this.panel_datacliente.Controls[0].Controls["nombre"].Text;
                this.client.FechaNacimiento = this.panel_datacliente.Controls[0].Controls["nacimiento"].Text;
                this.client.Cuil = this.panel_datacliente.Controls[0].Controls["cuil"].Text;
                this.client.NumDoc = this.panel_datacliente.Controls[0].Controls["nrodoc"].Text;
                this.client.TipoDoc = this.panel_datacliente.Controls[0].Controls["doc"].Text;
                this.client.Usuario = this.textBox_usuario.Text;
                this.client.UsuarioObj.CodigoPostal = this.textBox_cp.Text;
                this.client.UsuarioObj.Direccion = this.textBox_calle.Text + "," + this.textBox_depto.Text + "," + this.textBox_piso.Text + "," + this.textBox_localidad.Text;
                this.client.UsuarioObj.Telefono = this.textBox_telefono.Text;
                this.client.UsuarioObj.Email = this.textBox_mail.Text;
                this.client.UsuarioObj.Username = this.textBox_usuario.Text;

                if (this.panel_datausuario.Controls["textBox_pass"].Text != "")
                {
                    this.client.UsuarioObj.Password = this.panel_datausuario.Controls["textBox_pass"].Text;
                    this.client.UsuarioObj.updatePassword();
                }
                this.client.update();
                MessageBox.Show("Cliente actualizado con éxito!", "Actualizar cliente.",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((Cliente_Listado)this.previous).loadClientList();
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
                MessageBox.Show("Error al editar el cliente!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.previous.Show();
                this.Hide();
            }
        }
    }
}

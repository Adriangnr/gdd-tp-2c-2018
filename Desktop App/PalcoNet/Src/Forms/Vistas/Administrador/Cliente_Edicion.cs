using PalcoNet.Src.Forms.Layouts;
using System;

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
                string[] piso = client.UsuarioObj.Direccion.Split(',')[2].Split(' ');
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
            this.client.Apellido = this.panel_datacliente.Controls[0].Controls["nombre"].Text;
            this.client.Nombre = this.panel_datacliente.Controls[0].Controls["nombre"].Text;
            this.client.FechaNacimiento = this.panel_datacliente.Controls[0].Controls["nacimiento"].Text;
            this.client.Cuil = this.panel_datacliente.Controls[0].Controls["cuil"].Text;
            this.client.NumDoc = this.panel_datacliente.Controls[0].Controls["nrodoc"].Text;
            this.client.TipoDoc = this.panel_datacliente.Controls[0].Controls["doc"].Text;
            this.client.Usuario = this.textBox_usuario.Text;
        }
    }
}

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

namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    public partial class Compra_Agregar_Tarjeta : Master
    {
        private Src.Modelo.Entidades.Cliente cliente;

        public Compra_Agregar_Tarjeta(Form anterior, Src.Modelo.Entidades.Cliente cliente)
        {
            this.cliente = cliente;
            this.previous = anterior;
            InitializeComponent();
        }

        private void Compra_Agrega_Tarjeta_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe tener una tarjeta asociada para conmprar!", "Error compra",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidadorRegistro validReg = new ValidadorRegistro();
                validReg.validar(this.Controls);
                ClienteService clienteService = (ClienteService)ServiceFactory.GetService("Cliente");
                clienteService.updateTarjeta(this.cliente.Id, tarjetaNueva.Text);
                cliente.DatosTarjeta = tarjetaNueva.Text;
                MessageBox.Show("Tarjeta guardada con exito!", "Nueva Tarjeta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (ValidadorException exception)
            {
                MessageBox.Show(exception.Message, "Error al registrar nueva tarjeta.",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

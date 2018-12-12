using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Utils;
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
    public partial class Compra_Sin_Numerar : Master
    {
        private int publicacion;
        private SortableBindingList<Entrada> entradasDisponibles;
        private List<Entrada> entradasCompradas;
        private double total;
        private double precio;

        public Compra_Sin_Numerar(Compra_Detalle compra, int ubicacionId, List<Entrada> entradasCompradas, SortableBindingList<Entrada> entradasDisponibles)
        {
            this.previous = compra;
            this.publicacion = ubicacionId;
            this.entradasCompradas = entradasCompradas;
            this.entradasDisponibles = entradasDisponibles;
            this.comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            this.textBox1.TextChanged += textBox1_TextChanged;
            InitializeComponent();
        }

        void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                this.total = 0.0;
            else
                this.total = int.Parse(textBox1.Text) * precio;

            this.label_total.Text = total.ToString();
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entrada entrada = this.comboBox1.SelectedItem as Entrada;
            this.precio = entrada.Precio;
            this.label_precio.Text = this.precio.ToString();

        }

        private void Compra_Sin_Numerar_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = entradasDisponibles;
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_seleccion_Click(object sender, EventArgs e)
        {
            Entrada entrada = this.comboBox1.SelectedItem as Entrada;
            int cantidad = int.Parse(textBox1.Text);

            if (cantidad <= entrada.Asiento)
            {
                entrada.cantSinNumerar = cantidad;
                this.entradasCompradas.Add(entrada);
                this.entradasDisponibles.Remove(entrada);
                this.Hide();
            }
            else
            {
                MessageBox.Show("No hay tantas ubicaciones!", "Compra sin numerar.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Text = "";
            }
        }
    }
}

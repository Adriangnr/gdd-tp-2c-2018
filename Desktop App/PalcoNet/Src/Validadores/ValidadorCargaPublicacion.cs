using PalcoNet.Src.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Src.Validadores
{
    public class ValidadorCargaPublicacion : Validador
    {
        public void descripcion(TextBox descripcion)
        {
            if(descripcion.Text == "")
            {
                throw new ValidadorException("Debe ingresar la descripcion de su espectaculo!");
            }
            else
            {
                this.validarCampoTexto(descripcion, "Descripcion", new Regex(@"^[a-zA-Z0-9\., ]+$"));
            }
        }

        public void direccion(TextBox direccion)
        {
            if(direccion.Text == "")
            {
                throw new ValidadorException("Debe ingresar la direccion de su espectaculo!");
            }
            else
            {
                this.validarCampoTexto(direccion, "Direccion", new Regex(@"^[a-zA-Z0-9\., ]+$"));
            }
        }

        public void rubro(ComboBox rubros)
        {
            if (rubros.SelectedIndex == -1)
            {
                throw new ValidadorException("Debe ingresar el rubro de su espectaculo!");
            }
        }

        public void grado(ComboBox grados)
        {
            if (grados.SelectedIndex == -1)
            {
                throw new ValidadorException("Debe ingresar el grado de su espectaculo!");
            }
        }

        public void estado(ComboBox estados)
        {
            if (estados.SelectedIndex == -1)
            {
                throw new ValidadorException("Debe ingresar el estado de su espectaculo!");
            }
        }

        public void dataGridView_fechaHora(DataGridView fechaHora)
        {
            if(fechaHora.Rows.Count == 0)
            {
                throw new ValidadorException("Debe ingresar fechas y horarios para su espectaculo!");
            }
            else
            {
                foreach(DataGridViewRow row in fechaHora.Rows)
                {
                    Console.WriteLine((DateTime)row.Cells[0].Value);
                }
            }
        }

        public void dataGridViewUbicaciones(DataGridView fechaHora)
        {
            if (fechaHora.Rows.Count == 0)
            {
                throw new ValidadorException("Debe ingresar ubicaciones para su espectaculo!");
            }
        }

        public void comboBoxTipos(ComboBox tipos)
        {
            if (tipos.SelectedIndex == -1)
            {
                throw new ValidadorException("Debe ingresar el tipo de ubicacin!");
            }
        }

        public void txt_filas(TextBox filas)
        {
            if (filas.Text == "")
            {
                throw new ValidadorException("Ingrese la cantidad de filas de su ubicación!");
            }
            else
            {
                this.validarCampoTexto(filas, "Filas", new Regex("^[0-9]+$"));
            }
        }

        public void txt_asientos(TextBox asientos) 
        {
            if (asientos.Text == "")
            {
                throw new ValidadorException("Ingrese la cantidad de asientos de su ubicación!");
            }
            else
            {
                this.validarCampoTexto(asientos, "Asientos", new Regex("^[0-9]+$"));
            }
        }

        public void txt_cantidad(TextBox cantidad)
        {
            if (cantidad.Text == "" || (int.Parse(cantidad.Text) <= 0))
            {
                throw new ValidadorException("Ingrese el stock de su ubicación!");
            }
            else
            {
                this.validarCampoTexto(cantidad, "Cantidad", new Regex("^[0-9]+$"));
            }
        }

        public void txt_precio(TextBox precio)
        {
            if (precio.Text == "")
            {
                throw new ValidadorException("Ingrese el precio de su ubicación!");
            }
            else
            {
                this.validarCampoTexto(precio, "Precio", new Regex(@"^\d+(\.{1}\d+)?$"));
            }
        }
    }
}

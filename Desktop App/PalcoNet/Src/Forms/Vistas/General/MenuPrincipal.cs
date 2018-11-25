﻿using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Forms.Layouts;
using System.Drawing;
using PalcoNet.Src.Utils;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.General
{
    public partial class MenuPrincipal : Master
    {
        private Usuario user = null;
        public MenuPrincipal(Form previous, Usuario user)
        {
            this.previous = previous;
            this.user = user;
            this.agregarFuncionalidades(user.ObtenerRolSeleccionado());
            InitializeComponent();
        }

        private void agregarFuncionalidades(Rol rol)
        {
            Panel panelFuncionalidades = new Panel();
            panelFuncionalidades.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            panelFuncionalidades.Location = new Point(this.Width/4, this.Height / 4);

            int buttonLeft = 10;
            int buttonTop = 10;
            int i = 0;

            foreach (Funcionalidad f in rol.GetFuncionalidades())
            {
                Button newButton = new Button();
                newButton.Text = f.GetDescripcion();
                newButton.Name = f.GetNombre();
                newButton.BackColor = System.Drawing.SystemColors.Highlight;
                newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                newButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                newButton.ForeColor = System.Drawing.SystemColors.Window;
                newButton.Margin = new System.Windows.Forms.Padding(0);
                newButton.Size = new System.Drawing.Size(218, 69);
                newButton.UseVisualStyleBackColor = false;

                i++;
                if( i > rol.GetFuncionalidades().Count / 2)
                {
                    buttonTop = 10;
                    buttonLeft = 230;
                    i = 0;
                }

                newButton.Top = buttonTop;
                newButton.Left = buttonLeft;
                newButton.AutoSize = true;
                newButton.Click += (s, e) =>
                {
                    if (f.GetNombre() == "Empresa_Registro" || f.GetNombre() == "Cliente_Registro")
                    {
                        Registro registro = new Registro(this);
                        registro.Show();
                        this.Hide();
                    }
                    else
                    {
                        Master funcForm = Utilities.createInstance("PalcoNet.Src.Forms.Vistas." +
                        rol.Nombre + "." + f.GetNombre()) as Master;
                        funcForm.setPrevious(this);
                        funcForm.Show();
                        this.Hide();
                    }
                };

                buttonTop += (newButton.Height + 15);
                panelFuncionalidades.Controls.Add(newButton);
            }
            this.Controls.Add(panelFuncionalidades);
            this.Refresh();
        }

        private void menuPrincipalSalir_Click(object sender, System.EventArgs e)
        {
            this.previous.Controls["login_tbox_usuario"].Text = "";
            this.previous.Controls["login_tbox_password"].Text = "";
            this.previous.Show();
            this.Hide();
        }
    }
}

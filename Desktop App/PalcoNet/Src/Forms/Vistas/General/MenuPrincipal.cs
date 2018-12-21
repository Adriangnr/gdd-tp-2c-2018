using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Forms.Layouts;
using System.Drawing;
using PalcoNet.Src.Utils;
using System.Windows.Forms;
using System;
using PalcoNet.Src.Forms.Vistas.Administrador;

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

            panelFuncionalidades.Location = new Point(this.Width/10, this.Height/6);

            int totalHeight = this.Height / 6 + 80;
            int buttonLeft = 12;
            int buttonTop = 20;
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
                newButton.Size = new System.Drawing.Size(200, 52);
                newButton.UseVisualStyleBackColor = false;
                totalHeight = totalHeight + 35;
                i++;
                if( i > rol.GetFuncionalidades().Count / 2)
                {
                    buttonTop = 20;
                    buttonLeft = 250;
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
                        if( funcForm == null ) funcForm = Utilities.createInstance("PalcoNet.Src.Forms.Vistas.Administrador" + "." + f.GetNombre()) as Master;
                        if(f.GetNombre() == "Cliente_Edicion")
                        {
                            funcForm = new Cliente_Edicion(this.user);
                            ((Cliente_Edicion)funcForm).fromMenu = true;
                        }

                        if (f.GetNombre() == "Empresa_Edicion")
                        {
                            funcForm = new Empresa_Edicion(this.user);
                            ((Empresa_Edicion)funcForm).fromMenu = true;
                        }
                        funcForm.setPrevious(this);
                        funcForm.setUsuario(this.user);
                        funcForm.Show();
                        this.Hide();
                    }
                };

                buttonTop += (newButton.Height + 24);
                panelFuncionalidades.Controls.Add(newButton);
            }
            this.Controls.Add(panelFuncionalidades);
            this.Refresh();
            // 
            // menuPrincipalSalir
            //
            Button menuPrincipalSalir = new Button();
            menuPrincipalSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            menuPrincipalSalir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            menuPrincipalSalir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            menuPrincipalSalir.Location = new System.Drawing.Point(480, Math.Max(totalHeight,320));
            menuPrincipalSalir.Margin = new System.Windows.Forms.Padding(4, 5, 25, 25);
            menuPrincipalSalir.Name = "menuPrincipalSalir";
            menuPrincipalSalir.Size = new System.Drawing.Size(120, 40);
            menuPrincipalSalir.TabIndex = 2;
            menuPrincipalSalir.Text = "Salir";
            menuPrincipalSalir.UseVisualStyleBackColor = true;
            menuPrincipalSalir.Click += new System.EventHandler(this.menuPrincipalSalir_Click);
            this.Controls.Add(menuPrincipalSalir);
            this.Refresh();
        }

        private void menuPrincipalSalir_Click(object sender, System.EventArgs e)
        {
            if(this.user.GetRoles().Count > 1)
                ((Selector_Rol)this.previous).deseleccionarRol();
            else
                ((Login)this.previous).clearFields();
            this.previous.Show();
            this.Close();
        }

        private void MenuPrincipal_Load(object sender, System.EventArgs e)
        {

        }
    }
}

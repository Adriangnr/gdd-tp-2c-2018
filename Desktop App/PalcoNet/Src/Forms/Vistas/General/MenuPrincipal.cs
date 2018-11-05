using PalcoNet.Modelo.Entidades;
using PalcoNet.Src.Forms.Layouts;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.General
{
    public partial class MenuPrincipal : Master
    {
        private Form previous = null;
        private Usuario user = null;
        public MenuPrincipal(Form previous, Usuario user)
        {
            this.agregarFuncionalidades(user.ObtenerRolSeleccionado());
            InitializeComponent();
        }

        private void agregarFuncionalidades(Rol rol)
        {
            Panel panelFuncionalidades = new Panel();
            panelFuncionalidades.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            panelFuncionalidades.Top = 5;
            panelFuncionalidades.Left = 5;

            foreach (Funcionalidad f in rol.GetFuncionalidades())
            {
                Button newButton = new Button();
                newButton.Text = f.GetNombre();
                newButton.Name = f.GetNombre();

                panelFuncionalidades.Controls.Add(newButton);
            }
            this.Controls.Add(panelFuncionalidades);
            this.Refresh();
        }
    }
}

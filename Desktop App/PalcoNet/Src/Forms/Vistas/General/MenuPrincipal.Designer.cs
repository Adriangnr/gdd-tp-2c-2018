namespace PalcoNet.Src.Forms.Vistas.General
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPrincipalSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuPrincipalSalir
            // 
            this.menuPrincipalSalir.Location = new System.Drawing.Point(647, 391);
            this.menuPrincipalSalir.Name = "menuPrincipalSalir";
            this.menuPrincipalSalir.Size = new System.Drawing.Size(141, 47);
            this.menuPrincipalSalir.TabIndex = 2;
            this.menuPrincipalSalir.Text = "Salir";
            this.menuPrincipalSalir.UseVisualStyleBackColor = true;
            this.menuPrincipalSalir.Click += new System.EventHandler(this.menuPrincipalSalir_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPrincipalSalir);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Controls.SetChildIndex(this.menuPrincipalSalir, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuPrincipalSalir;
    }
}
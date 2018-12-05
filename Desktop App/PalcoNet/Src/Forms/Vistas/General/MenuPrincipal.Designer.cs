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
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(496, 629);
            // 
            // menuPrincipalSalir
            // 
            this.menuPrincipalSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuPrincipalSalir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipalSalir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuPrincipalSalir.Location = new System.Drawing.Point(643, 529);
            this.menuPrincipalSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuPrincipalSalir.Name = "menuPrincipalSalir";
            this.menuPrincipalSalir.Size = new System.Drawing.Size(194, 69);
            this.menuPrincipalSalir.TabIndex = 2;
            this.menuPrincipalSalir.Text = "Salir";
            this.menuPrincipalSalir.UseVisualStyleBackColor = true;
            this.menuPrincipalSalir.Click += new System.EventHandler(this.menuPrincipalSalir_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(850, 677);
            this.Controls.Add(this.menuPrincipalSalir);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.menuPrincipalSalir, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuPrincipalSalir;
    }
}
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
            this.footer.Location = new System.Drawing.Point(331, 409);
            this.footer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            // 
            // menuPrincipalSalir
            // 
            this.menuPrincipalSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuPrincipalSalir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipalSalir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuPrincipalSalir.Location = new System.Drawing.Point(429, 344);
            this.menuPrincipalSalir.Name = "menuPrincipalSalir";
            this.menuPrincipalSalir.Size = new System.Drawing.Size(129, 45);
            this.menuPrincipalSalir.TabIndex = 2;
            this.menuPrincipalSalir.Text = "Volver";
            this.menuPrincipalSalir.UseVisualStyleBackColor = true;
            this.menuPrincipalSalir.Click += new System.EventHandler(this.menuPrincipalSalir_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(567, 440);
            this.Controls.Add(this.menuPrincipalSalir);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.menuPrincipalSalir, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuPrincipalSalir;
    }
}
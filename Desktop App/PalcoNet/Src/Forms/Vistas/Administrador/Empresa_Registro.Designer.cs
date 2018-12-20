namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    partial class Empresa_Registro
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.razonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cuit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ciudad = new System.Windows.Forms.TextBox();
            this.label_cuil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // razonSocial
            // 
            this.razonSocial.Location = new System.Drawing.Point(112, 39);
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.Size = new System.Drawing.Size(137, 20);
            this.razonSocial.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Razón social:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(35, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CUIT:";
            // 
            // cuit
            // 
            this.cuit.Location = new System.Drawing.Point(112, 74);
            this.cuit.Name = "cuit";
            this.cuit.Size = new System.Drawing.Size(137, 20);
            this.cuit.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(35, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ciudad:";
            // 
            // ciudad
            // 
            this.ciudad.Location = new System.Drawing.Point(112, 119);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(137, 20);
            this.ciudad.TabIndex = 14;
            // 
            // label_cuil
            // 
            this.label_cuil.AutoSize = true;
            this.label_cuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cuil.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_cuil.Location = new System.Drawing.Point(117, 98);
            this.label_cuil.Name = "label_cuil";
            this.label_cuil.Size = new System.Drawing.Size(124, 13);
            this.label_cuil.TabIndex = 21;
            this.label_cuil.Text = "( Formato: xx-xxxxxxxx-x )";
            // 
            // Empresa_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label_cuil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ciudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.razonSocial);
            this.Name = "Empresa_Registro";
            this.Size = new System.Drawing.Size(311, 165);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox razonSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cuit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ciudad;
        private System.Windows.Forms.Label label_cuil;
    }
}

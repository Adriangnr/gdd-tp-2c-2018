namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    partial class Cliente_Registro
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
            this.label3 = new System.Windows.Forms.Label();
            this.nrodoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.doc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cuil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tarjeta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(52, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Documento:";
            // 
            // nrodoc
            // 
            this.nrodoc.Location = new System.Drawing.Point(260, 169);
            this.nrodoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nrodoc.Name = "nrodoc";
            this.nrodoc.Size = new System.Drawing.Size(112, 26);
            this.nrodoc.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(52, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellido:";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(168, 114);
            this.apellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(204, 26);
            this.apellido.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(52, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(168, 60);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(204, 26);
            this.nombre.TabIndex = 12;
            // 
            // doc
            // 
            this.doc.FormattingEnabled = true;
            this.doc.Location = new System.Drawing.Point(168, 169);
            this.doc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(80, 28);
            this.doc.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(52, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "CUIL:";
            // 
            // cuil
            // 
            this.cuil.Location = new System.Drawing.Point(168, 225);
            this.cuil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuil.Name = "cuil";
            this.cuil.Size = new System.Drawing.Size(204, 26);
            this.cuil.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(52, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nacimiento:";
            // 
            // nacimiento
            // 
            this.nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nacimiento.Location = new System.Drawing.Point(168, 278);
            this.nacimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nacimiento.Name = "nacimiento";
            this.nacimiento.Size = new System.Drawing.Size(204, 26);
            this.nacimiento.TabIndex = 17;
            this.nacimiento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(52, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tarjeta:";
            // 
            // tarjeta
            // 
            this.tarjeta.Location = new System.Drawing.Point(168, 332);
            this.tarjeta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tarjeta.Name = "tarjeta";
            this.tarjeta.Size = new System.Drawing.Size(204, 26);
            this.tarjeta.TabIndex = 18;
            // 
            // Cliente_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tarjeta);
            this.Controls.Add(this.nacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cuil);
            this.Controls.Add(this.doc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nrodoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cliente_Registro";
            this.Size = new System.Drawing.Size(466, 417);
            this.Load += new System.EventHandler(this.Cliente_Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nrodoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.ComboBox doc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cuil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker nacimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tarjeta;

    }
}

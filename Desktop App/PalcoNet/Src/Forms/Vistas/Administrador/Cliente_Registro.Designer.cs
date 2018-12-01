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
            this.label3.Location = new System.Drawing.Point(35, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Documento:";
            // 
            // nrodoc
            // 
            this.nrodoc.Location = new System.Drawing.Point(173, 110);
            this.nrodoc.Name = "nrodoc";
            this.nrodoc.Size = new System.Drawing.Size(76, 20);
            this.nrodoc.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(35, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellido:";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(112, 74);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(137, 20);
            this.apellido.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(112, 39);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(137, 20);
            this.nombre.TabIndex = 12;
            // 
            // doc
            // 
            this.doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doc.FormattingEnabled = true;
            this.doc.Location = new System.Drawing.Point(112, 110);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(55, 21);
            this.doc.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(35, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "CUIL:";
            // 
            // cuil
            // 
            this.cuil.Location = new System.Drawing.Point(112, 146);
            this.cuil.Name = "cuil";
            this.cuil.Size = new System.Drawing.Size(137, 20);
            this.cuil.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(35, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nacimiento:";
            // 
            // nacimiento
            // 
            this.nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nacimiento.Location = new System.Drawing.Point(112, 181);
            this.nacimiento.Name = "nacimiento";
            this.nacimiento.Size = new System.Drawing.Size(137, 20);
            this.nacimiento.TabIndex = 17;
            this.nacimiento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(35, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tarjeta:";
            // 
            // tarjeta
            // 
            this.tarjeta.Location = new System.Drawing.Point(112, 216);
            this.tarjeta.Name = "tarjeta";
            this.tarjeta.Size = new System.Drawing.Size(137, 20);
            this.tarjeta.TabIndex = 18;
            // 
            // Cliente_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Name = "Cliente_Registro";
            this.Size = new System.Drawing.Size(311, 271);
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

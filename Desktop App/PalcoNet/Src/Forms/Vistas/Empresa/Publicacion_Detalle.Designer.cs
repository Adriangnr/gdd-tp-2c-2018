namespace PalcoNet.Src.Forms.Vistas.Empresa
{
    partial class Publicacion_Detalle
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
            this.label1 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grado = new System.Windows.Forms.ComboBox();
            this.estado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rubro = new System.Windows.Forms.ComboBox();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.panelFechasHorarios = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTiposEntradas = new System.Windows.Forms.Panel();
            this.btn_pub_cargarFechasHoras = new System.Windows.Forms.Button();
            this.btn_pub_entradas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(48, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Descripción:";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(225, 121);
            this.descripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(270, 26);
            this.descripcion.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(48, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Rubro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(48, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Dirección:";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(225, 164);
            this.direccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(270, 26);
            this.direccion.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(48, 282);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Grado de publicación:";
            // 
            // grado
            // 
            this.grado.FormattingEnabled = true;
            this.grado.Location = new System.Drawing.Point(227, 277);
            this.grado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grado.Name = "grado";
            this.grado.Size = new System.Drawing.Size(268, 28);
            this.grado.TabIndex = 47;
            // 
            // estado
            // 
            this.estado.FormattingEnabled = true;
            this.estado.Location = new System.Drawing.Point(227, 344);
            this.estado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(268, 28);
            this.estado.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(48, 348);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Estado:";
            // 
            // rubro
            // 
            this.rubro.FormattingEnabled = true;
            this.rubro.Location = new System.Drawing.Point(225, 222);
            this.rubro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(270, 28);
            this.rubro.TabIndex = 52;
            // 
            // registerLink
            // 
            this.registerLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.registerLink.AutoSize = true;
            this.registerLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.registerLink.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerLink.Location = new System.Drawing.Point(69, 548);
            this.registerLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(172, 25);
            this.registerLink.TabIndex = 55;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "Limpiar Formulario";
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLink_LinkClicked);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(725, 527);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(194, 69);
            this.btn_cancel.TabIndex = 54;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_guardar.Location = new System.Drawing.Point(941, 527);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(194, 69);
            this.btn_guardar.TabIndex = 53;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // panelFechasHorarios
            // 
            this.panelFechasHorarios.Location = new System.Drawing.Point(627, 150);
            this.panelFechasHorarios.Name = "panelFechasHorarios";
            this.panelFechasHorarios.Size = new System.Drawing.Size(508, 170);
            this.panelFechasHorarios.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Fechas y horarios";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Tipos de entradas";
            // 
            // panelTiposEntradas
            // 
            this.panelTiposEntradas.Location = new System.Drawing.Point(627, 365);
            this.panelTiposEntradas.Name = "panelTiposEntradas";
            this.panelTiposEntradas.Size = new System.Drawing.Size(508, 154);
            this.panelTiposEntradas.TabIndex = 58;
            // 
            // btn_pub_cargarFechasHoras
            // 
            this.btn_pub_cargarFechasHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pub_cargarFechasHoras.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pub_cargarFechasHoras.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_pub_cargarFechasHoras.Location = new System.Drawing.Point(52, 437);
            this.btn_pub_cargarFechasHoras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pub_cargarFechasHoras.Name = "btn_pub_cargarFechasHoras";
            this.btn_pub_cargarFechasHoras.Size = new System.Drawing.Size(194, 69);
            this.btn_pub_cargarFechasHoras.TabIndex = 60;
            this.btn_pub_cargarFechasHoras.Text = "Cargar Fechas y Horarios";
            this.btn_pub_cargarFechasHoras.UseVisualStyleBackColor = true;
            // 
            // btn_pub_entradas
            // 
            this.btn_pub_entradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pub_entradas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pub_entradas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_pub_entradas.Location = new System.Drawing.Point(301, 437);
            this.btn_pub_entradas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pub_entradas.Name = "btn_pub_entradas";
            this.btn_pub_entradas.Size = new System.Drawing.Size(194, 69);
            this.btn_pub_entradas.TabIndex = 61;
            this.btn_pub_entradas.Text = "Cargar entradas y precios";
            this.btn_pub_entradas.UseVisualStyleBackColor = true;
            // 
            // Publicacion_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 678);
            this.Controls.Add(this.btn_pub_entradas);
            this.Controls.Add(this.btn_pub_cargarFechasHoras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelTiposEntradas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelFechasHorarios);
            this.Controls.Add(this.registerLink);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.rubro);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descripcion);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Publicacion_Detalle";
            this.Text = "Palco.NET - Creación de Publicación";
            this.Load += new System.EventHandler(this.Publicacion_Detalle_Load);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.descripcion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.direccion, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.grado, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.estado, 0);
            this.Controls.SetChildIndex(this.rubro, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.registerLink, 0);
            this.Controls.SetChildIndex(this.panelFechasHorarios, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.panelTiposEntradas, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btn_pub_cargarFechasHoras, 0);
            this.Controls.SetChildIndex(this.btn_pub_entradas, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox grado;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox rubro;
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Panel panelFechasHorarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelTiposEntradas;
        private System.Windows.Forms.Button btn_pub_cargarFechasHoras;
        private System.Windows.Forms.Button btn_pub_entradas;
    }
}
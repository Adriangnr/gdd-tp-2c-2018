using PalcoNet.Src.Forms.Layouts;

namespace PalcoNet.Src.Forms.Vistas.Empresa
{
    partial class Publicacion_Detalle : Master
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
            this.rubro = new System.Windows.Forms.ComboBox();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_pub_cargarFechasHoras = new System.Windows.Forms.Button();
            this.dataGridView_fechaHora = new System.Windows.Forms.DataGridView();
            this.fechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewUbicaciones = new System.Windows.Forms.DataGridView();
            this.txtTipoUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinNumerar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCargarUbicaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fechaHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUbicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(1390, 626);
            this.footer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(48, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Descripción:";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(225, 122);
            this.descripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(270, 26);
            this.descripcion.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(48, 229);
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
            this.label7.Location = new System.Drawing.Point(48, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Dirección:";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(225, 174);
            this.direccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(270, 26);
            this.direccion.TabIndex = 1;
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
            this.grado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grado.FormattingEnabled = true;
            this.grado.Location = new System.Drawing.Point(226, 277);
            this.grado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grado.Name = "grado";
            this.grado.Size = new System.Drawing.Size(268, 28);
            this.grado.TabIndex = 3;
            // 
            // rubro
            // 
            this.rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rubro.FormattingEnabled = true;
            this.rubro.Location = new System.Drawing.Point(225, 222);
            this.rubro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(270, 28);
            this.rubro.TabIndex = 2;
            // 
            // registerLink
            // 
            this.registerLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.registerLink.AutoSize = true;
            this.registerLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.registerLink.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerLink.Location = new System.Drawing.Point(46, 571);
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
            this.btn_cancel.Location = new System.Drawing.Point(1344, 526);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(194, 69);
            this.btn_cancel.TabIndex = 8;
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
            this.btn_guardar.Location = new System.Drawing.Point(1550, 526);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(194, 69);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Fechas y horarios";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(958, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Tipos de entradas de su espectaculo";
            // 
            // btn_pub_cargarFechasHoras
            // 
            this.btn_pub_cargarFechasHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pub_cargarFechasHoras.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pub_cargarFechasHoras.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_pub_cargarFechasHoras.Location = new System.Drawing.Point(52, 418);
            this.btn_pub_cargarFechasHoras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pub_cargarFechasHoras.Name = "btn_pub_cargarFechasHoras";
            this.btn_pub_cargarFechasHoras.Size = new System.Drawing.Size(194, 69);
            this.btn_pub_cargarFechasHoras.TabIndex = 5;
            this.btn_pub_cargarFechasHoras.Text = "Cargar Fechas y Horarios";
            this.btn_pub_cargarFechasHoras.UseVisualStyleBackColor = true;
            this.btn_pub_cargarFechasHoras.Click += new System.EventHandler(this.btn_pub_cargarFechasHoras_Click);
            // 
            // dataGridView_fechaHora
            // 
            this.dataGridView_fechaHora.AllowUserToAddRows = false;
            this.dataGridView_fechaHora.AllowUserToResizeColumns = false;
            this.dataGridView_fechaHora.AllowUserToResizeRows = false;
            this.dataGridView_fechaHora.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_fechaHora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_fechaHora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaHora,
            this.btnEliminar});
            this.dataGridView_fechaHora.Location = new System.Drawing.Point(592, 152);
            this.dataGridView_fechaHora.Name = "dataGridView_fechaHora";
            this.dataGridView_fechaHora.ReadOnly = true;
            this.dataGridView_fechaHora.RowHeadersVisible = false;
            this.dataGridView_fechaHora.RowTemplate.Height = 28;
            this.dataGridView_fechaHora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_fechaHora.Size = new System.Drawing.Size(344, 335);
            this.dataGridView_fechaHora.TabIndex = 66;
            this.dataGridView_fechaHora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_fechaHora_CellContentClick);
            // 
            // fechaHora
            // 
            this.fechaHora.HeaderText = "Dia y Horario";
            this.fechaHora.Name = "fechaHora";
            this.fechaHora.ReadOnly = true;
            this.fechaHora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fechaHora.Width = 150;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 60;
            // 
            // dataGridViewUbicaciones
            // 
            this.dataGridViewUbicaciones.AllowUserToAddRows = false;
            this.dataGridViewUbicaciones.AllowUserToResizeRows = false;
            this.dataGridViewUbicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUbicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtTipoUbicacion,
            this.fila,
            this.asiento,
            this.txtPrecio,
            this.txtCantidad,
            this.sinNumerar,
            this.btnQuitar});
            this.dataGridViewUbicaciones.Location = new System.Drawing.Point(962, 152);
            this.dataGridViewUbicaciones.MultiSelect = false;
            this.dataGridViewUbicaciones.Name = "dataGridViewUbicaciones";
            this.dataGridViewUbicaciones.RowHeadersVisible = false;
            this.dataGridViewUbicaciones.RowTemplate.Height = 28;
            this.dataGridViewUbicaciones.Size = new System.Drawing.Size(782, 335);
            this.dataGridViewUbicaciones.TabIndex = 67;
            this.dataGridViewUbicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUbicaciones_CellContentClick);
            // 
            // txtTipoUbicacion
            // 
            this.txtTipoUbicacion.HeaderText = "Tipo de Ubicacion";
            this.txtTipoUbicacion.Name = "txtTipoUbicacion";
            this.txtTipoUbicacion.ReadOnly = true;
            // 
            // fila
            // 
            this.fila.HeaderText = "Filas";
            this.fila.Name = "fila";
            // 
            // asiento
            // 
            this.asiento.HeaderText = "Asientos";
            this.asiento.Name = "asiento";
            // 
            // txtPrecio
            // 
            this.txtPrecio.HeaderText = "Precio";
            this.txtPrecio.Name = "txtPrecio";
            // 
            // txtCantidad
            // 
            this.txtCantidad.HeaderText = "Cantidad";
            this.txtCantidad.Name = "txtCantidad";
            // 
            // sinNumerar
            // 
            this.sinNumerar.HeaderText = "Sin Numerar";
            this.sinNumerar.Name = "sinNumerar";
            this.sinNumerar.ReadOnly = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.HeaderText = "";
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnQuitar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnCargarUbicaciones
            // 
            this.btnCargarUbicaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarUbicaciones.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarUbicaciones.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCargarUbicaciones.Location = new System.Drawing.Point(302, 418);
            this.btnCargarUbicaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargarUbicaciones.Name = "btnCargarUbicaciones";
            this.btnCargarUbicaciones.Size = new System.Drawing.Size(194, 69);
            this.btnCargarUbicaciones.TabIndex = 6;
            this.btnCargarUbicaciones.Text = "Cargar Ubicaciones";
            this.btnCargarUbicaciones.UseVisualStyleBackColor = true;
            this.btnCargarUbicaciones.Click += new System.EventHandler(this.btnCargarUbicaciones_Click);
            // 
            // Publicacion_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 678);
            this.Controls.Add(this.btnCargarUbicaciones);
            this.Controls.Add(this.dataGridViewUbicaciones);
            this.Controls.Add(this.dataGridView_fechaHora);
            this.Controls.Add(this.btn_pub_cargarFechasHoras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registerLink);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.rubro);
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
            this.Controls.SetChildIndex(this.rubro, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.registerLink, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btn_pub_cargarFechasHoras, 0);
            this.Controls.SetChildIndex(this.dataGridView_fechaHora, 0);
            this.Controls.SetChildIndex(this.dataGridViewUbicaciones, 0);
            this.Controls.SetChildIndex(this.btnCargarUbicaciones, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fechaHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUbicaciones)).EndInit();
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
        private System.Windows.Forms.ComboBox rubro;
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_pub_cargarFechasHoras;
        private System.Windows.Forms.DataGridView dataGridView_fechaHora;
        private System.Windows.Forms.DataGridView dataGridViewUbicaciones;
        private System.Windows.Forms.Button btnCargarUbicaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHora;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTipoUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinNumerar;
        private System.Windows.Forms.DataGridViewButtonColumn btnQuitar;
    }
}
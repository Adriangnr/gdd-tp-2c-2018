namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    partial class Compra_Detalle
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
            this.btn_seleccion = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dataGridEntradasNumeradas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_espectaculo = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.btn_quitar_seleccion = new System.Windows.Forms.Button();
            this.btn_confirmar_compra = new System.Windows.Forms.Button();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_apellido = new System.Windows.Forms.Label();
            this.label_tarjeta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridEntradasSinNumerar = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_seleccionSN = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntradasNumeradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntradasSinNumerar)).BeginInit();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(900, 534);
            // 
            // btn_seleccion
            // 
            this.btn_seleccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_seleccion.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_seleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seleccion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccion.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_seleccion.Location = new System.Drawing.Point(960, 92);
            this.btn_seleccion.Margin = new System.Windows.Forms.Padding(0);
            this.btn_seleccion.Name = "btn_seleccion";
            this.btn_seleccion.Size = new System.Drawing.Size(129, 45);
            this.btn_seleccion.TabIndex = 59;
            this.btn_seleccion.Text = "Seleccionar ubicacion";
            this.btn_seleccion.UseVisualStyleBackColor = false;
            this.btn_seleccion.Click += new System.EventHandler(this.btn_seleccion_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(60, 470);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(129, 45);
            this.btn_cancel.TabIndex = 60;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dataGridEntradasNumeradas
            // 
            this.dataGridEntradasNumeradas.AllowUserToAddRows = false;
            this.dataGridEntradasNumeradas.AllowUserToDeleteRows = false;
            this.dataGridEntradasNumeradas.AllowUserToOrderColumns = true;
            this.dataGridEntradasNumeradas.AllowUserToResizeRows = false;
            this.dataGridEntradasNumeradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEntradasNumeradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEntradasNumeradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEntradasNumeradas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridEntradasNumeradas.Location = new System.Drawing.Point(411, 55);
            this.dataGridEntradasNumeradas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridEntradasNumeradas.MultiSelect = false;
            this.dataGridEntradasNumeradas.Name = "dataGridEntradasNumeradas";
            this.dataGridEntradasNumeradas.ReadOnly = true;
            this.dataGridEntradasNumeradas.RowHeadersVisible = false;
            this.dataGridEntradasNumeradas.RowTemplate.Height = 28;
            this.dataGridEntradasNumeradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEntradasNumeradas.Size = new System.Drawing.Size(500, 222);
            this.dataGridEntradasNumeradas.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Total";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(115, 366);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(38, 24);
            this.label_total.TabIndex = 67;
            this.label_total.Text = "0.0";
            // 
            // label_espectaculo
            // 
            this.label_espectaculo.AutoSize = true;
            this.label_espectaculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_espectaculo.Location = new System.Drawing.Point(115, 286);
            this.label_espectaculo.Name = "label_espectaculo";
            this.label_espectaculo.Size = new System.Drawing.Size(117, 20);
            this.label_espectaculo.TabIndex = 68;
            this.label_espectaculo.Text = "[ Espectaculo  ]";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha.Location = new System.Drawing.Point(115, 328);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(74, 20);
            this.label_fecha.TabIndex = 69;
            this.label_fecha.Text = "[ Fecha  ]";
            // 
            // btn_quitar_seleccion
            // 
            this.btn_quitar_seleccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_quitar_seleccion.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_quitar_seleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitar_seleccion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar_seleccion.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_quitar_seleccion.Location = new System.Drawing.Point(958, 470);
            this.btn_quitar_seleccion.Margin = new System.Windows.Forms.Padding(0);
            this.btn_quitar_seleccion.Name = "btn_quitar_seleccion";
            this.btn_quitar_seleccion.Size = new System.Drawing.Size(129, 45);
            this.btn_quitar_seleccion.TabIndex = 70;
            this.btn_quitar_seleccion.Text = "Quitar Ubicación";
            this.btn_quitar_seleccion.UseVisualStyleBackColor = false;
            this.btn_quitar_seleccion.Click += new System.EventHandler(this.btn_quitar_seleccion_Click);
            // 
            // btn_confirmar_compra
            // 
            this.btn_confirmar_compra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_confirmar_compra.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_confirmar_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar_compra.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar_compra.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_confirmar_compra.Location = new System.Drawing.Point(242, 470);
            this.btn_confirmar_compra.Margin = new System.Windows.Forms.Padding(0);
            this.btn_confirmar_compra.Name = "btn_confirmar_compra";
            this.btn_confirmar_compra.Size = new System.Drawing.Size(129, 45);
            this.btn_confirmar_compra.TabIndex = 71;
            this.btn_confirmar_compra.Text = "Confirmar compra";
            this.btn_confirmar_compra.UseVisualStyleBackColor = false;
            this.btn_confirmar_compra.Click += new System.EventHandler(this.btn_confirmar_compra_Click);
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(115, 133);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(81, 20);
            this.label_nombre.TabIndex = 72;
            this.label_nombre.Text = "[ Nombre ]";
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_apellido.Location = new System.Drawing.Point(115, 169);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(81, 20);
            this.label_apellido.TabIndex = 73;
            this.label_apellido.Text = "[ Apellido ]";
            // 
            // label_tarjeta
            // 
            this.label_tarjeta.AutoSize = true;
            this.label_tarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tarjeta.Location = new System.Drawing.Point(115, 245);
            this.label_tarjeta.Name = "label_tarjeta";
            this.label_tarjeta.Size = new System.Drawing.Size(74, 20);
            this.label_tarjeta.TabIndex = 74;
            this.label_tarjeta.Text = "[ Tarjeta ]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 78;
            this.label5.Text = "Tarjeta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 80;
            this.label6.Text = "Email";
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mail.Location = new System.Drawing.Point(115, 209);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(64, 20);
            this.label_mail.TabIndex = 79;
            this.label_mail.Text = "[ Email ]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 81;
            this.label7.Text = "Espectaculo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 82;
            this.label8.Text = "Fecha";
            // 
            // dataGridEntradasSinNumerar
            // 
            this.dataGridEntradasSinNumerar.AllowUserToAddRows = false;
            this.dataGridEntradasSinNumerar.AllowUserToDeleteRows = false;
            this.dataGridEntradasSinNumerar.AllowUserToOrderColumns = true;
            this.dataGridEntradasSinNumerar.AllowUserToResizeRows = false;
            this.dataGridEntradasSinNumerar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEntradasSinNumerar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEntradasSinNumerar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEntradasSinNumerar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridEntradasSinNumerar.Location = new System.Drawing.Point(411, 293);
            this.dataGridEntradasSinNumerar.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridEntradasSinNumerar.MultiSelect = false;
            this.dataGridEntradasSinNumerar.Name = "dataGridEntradasSinNumerar";
            this.dataGridEntradasSinNumerar.ReadOnly = true;
            this.dataGridEntradasSinNumerar.RowHeadersVisible = false;
            this.dataGridEntradasSinNumerar.RowTemplate.Height = 28;
            this.dataGridEntradasSinNumerar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEntradasSinNumerar.Size = new System.Drawing.Size(500, 222);
            this.dataGridEntradasSinNumerar.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(407, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 84;
            this.label9.Text = "Ubicaciones";
            // 
            // btn_seleccionSN
            // 
            this.btn_seleccionSN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_seleccionSN.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_seleccionSN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seleccionSN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionSN.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_seleccionSN.Location = new System.Drawing.Point(958, 328);
            this.btn_seleccionSN.Margin = new System.Windows.Forms.Padding(0);
            this.btn_seleccionSN.Name = "btn_seleccionSN";
            this.btn_seleccionSN.Size = new System.Drawing.Size(129, 45);
            this.btn_seleccionSN.TabIndex = 85;
            this.btn_seleccionSN.Text = "Seleccionar ubicacion";
            this.btn_seleccionSN.UseVisualStyleBackColor = false;
            this.btn_seleccionSN.Click += new System.EventHandler(this.btn_seleccionSN_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(941, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 20);
            this.label10.TabIndex = 86;
            this.label10.Text = "Ubicaciones sin numerar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(941, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 20);
            this.label11.TabIndex = 87;
            this.label11.Text = "Ubicaciones numeradas";
            // 
            // Compra_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 565);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_seleccionSN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridEntradasSinNumerar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_tarjeta);
            this.Controls.Add(this.label_apellido);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.btn_confirmar_compra);
            this.Controls.Add(this.btn_quitar_seleccion);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.label_espectaculo);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridEntradasNumeradas);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_seleccion);
            this.Name = "Compra_Detalle";
            this.Text = "Detalle de compra";
            this.Load += new System.EventHandler(this.Compra_Detalle_Load);
            this.Controls.SetChildIndex(this.btn_seleccion, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.dataGridEntradasNumeradas, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label_total, 0);
            this.Controls.SetChildIndex(this.label_espectaculo, 0);
            this.Controls.SetChildIndex(this.label_fecha, 0);
            this.Controls.SetChildIndex(this.btn_quitar_seleccion, 0);
            this.Controls.SetChildIndex(this.btn_confirmar_compra, 0);
            this.Controls.SetChildIndex(this.label_nombre, 0);
            this.Controls.SetChildIndex(this.label_apellido, 0);
            this.Controls.SetChildIndex(this.label_tarjeta, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label_mail, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.dataGridEntradasSinNumerar, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.btn_seleccionSN, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntradasNumeradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntradasSinNumerar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_seleccion;
        protected System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_fecha;
        protected System.Windows.Forms.Label label_espectaculo;
        public System.Windows.Forms.DataGridView dataGridEntradasNumeradas;
        public System.Windows.Forms.Button btn_quitar_seleccion;
        public System.Windows.Forms.Button btn_confirmar_compra;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.Label label_tarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView dataGridEntradasSinNumerar;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btn_seleccionSN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;

    }
}
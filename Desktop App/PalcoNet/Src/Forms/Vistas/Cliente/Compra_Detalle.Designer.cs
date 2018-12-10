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
            this.dataGridEntradasCompradas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_espectaculo = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.btn_quitar_seleccion = new System.Windows.Forms.Button();
            this.btn_confirmar_compra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntradasCompradas)).BeginInit();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(855, 424);
            // 
            // btn_seleccion
            // 
            this.btn_seleccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_seleccion.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_seleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seleccion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccion.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_seleccion.Location = new System.Drawing.Point(935, 83);
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
            this.btn_cancel.Location = new System.Drawing.Point(933, 345);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(129, 45);
            this.btn_cancel.TabIndex = 60;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dataGridEntradasCompradas
            // 
            this.dataGridEntradasCompradas.AllowUserToAddRows = false;
            this.dataGridEntradasCompradas.AllowUserToDeleteRows = false;
            this.dataGridEntradasCompradas.AllowUserToOrderColumns = true;
            this.dataGridEntradasCompradas.AllowUserToResizeRows = false;
            this.dataGridEntradasCompradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEntradasCompradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEntradasCompradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEntradasCompradas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridEntradasCompradas.Location = new System.Drawing.Point(198, 83);
            this.dataGridEntradasCompradas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridEntradasCompradas.MultiSelect = false;
            this.dataGridEntradasCompradas.Name = "dataGridEntradasCompradas";
            this.dataGridEntradasCompradas.ReadOnly = true;
            this.dataGridEntradasCompradas.RowHeadersVisible = false;
            this.dataGridEntradasCompradas.RowTemplate.Height = 28;
            this.dataGridEntradasCompradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEntradasCompradas.Size = new System.Drawing.Size(694, 307);
            this.dataGridEntradasCompradas.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Total";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(62, 342);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(38, 24);
            this.label_total.TabIndex = 67;
            this.label_total.Text = "0.0";
            // 
            // label_espectaculo
            // 
            this.label_espectaculo.AutoSize = true;
            this.label_espectaculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_espectaculo.Location = new System.Drawing.Point(211, 49);
            this.label_espectaculo.Name = "label_espectaculo";
            this.label_espectaculo.Size = new System.Drawing.Size(117, 20);
            this.label_espectaculo.TabIndex = 68;
            this.label_espectaculo.Text = "[ Espectaculo  ]";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha.Location = new System.Drawing.Point(752, 49);
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
            this.btn_quitar_seleccion.Location = new System.Drawing.Point(933, 144);
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
            this.btn_confirmar_compra.Location = new System.Drawing.Point(935, 286);
            this.btn_confirmar_compra.Margin = new System.Windows.Forms.Padding(0);
            this.btn_confirmar_compra.Name = "btn_confirmar_compra";
            this.btn_confirmar_compra.Size = new System.Drawing.Size(129, 45);
            this.btn_confirmar_compra.TabIndex = 71;
            this.btn_confirmar_compra.Text = "Confirmar compra";
            this.btn_confirmar_compra.UseVisualStyleBackColor = false;
            // 
            // Compra_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 462);
            this.Controls.Add(this.btn_confirmar_compra);
            this.Controls.Add(this.btn_quitar_seleccion);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.label_espectaculo);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridEntradasCompradas);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_seleccion);
            this.Name = "Compra_Detalle";
            this.Text = "Detalle de compra";
            this.Load += new System.EventHandler(this.Compra_Detalle_Load);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.btn_seleccion, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.dataGridEntradasCompradas, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label_total, 0);
            this.Controls.SetChildIndex(this.label_espectaculo, 0);
            this.Controls.SetChildIndex(this.label_fecha, 0);
            this.Controls.SetChildIndex(this.btn_quitar_seleccion, 0);
            this.Controls.SetChildIndex(this.btn_confirmar_compra, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntradasCompradas)).EndInit();
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
        public System.Windows.Forms.DataGridView dataGridEntradasCompradas;
        public System.Windows.Forms.Button btn_quitar_seleccion;
        public System.Windows.Forms.Button btn_confirmar_compra;

    }
}
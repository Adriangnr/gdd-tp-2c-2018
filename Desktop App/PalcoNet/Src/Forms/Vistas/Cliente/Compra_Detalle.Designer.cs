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
            this.dataGridEmpresas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_espectaculo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpresas)).BeginInit();
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
            // dataGridEmpresas
            // 
            this.dataGridEmpresas.AllowUserToAddRows = false;
            this.dataGridEmpresas.AllowUserToDeleteRows = false;
            this.dataGridEmpresas.AllowUserToOrderColumns = true;
            this.dataGridEmpresas.AllowUserToResizeRows = false;
            this.dataGridEmpresas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmpresas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridEmpresas.Location = new System.Drawing.Point(198, 83);
            this.dataGridEmpresas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridEmpresas.MultiSelect = false;
            this.dataGridEmpresas.Name = "dataGridEmpresas";
            this.dataGridEmpresas.ReadOnly = true;
            this.dataGridEmpresas.RowHeadersVisible = false;
            this.dataGridEmpresas.RowTemplate.Height = 28;
            this.dataGridEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmpresas.Size = new System.Drawing.Size(694, 307);
            this.dataGridEmpresas.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 294);
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
            this.label_total.Size = new System.Drawing.Size(80, 24);
            this.label_total.TabIndex = 67;
            this.label_total.Text = "[ Total ]";
            // 
            // label_espectaculo
            // 
            this.label_espectaculo.AutoSize = true;
            this.label_espectaculo.Location = new System.Drawing.Point(211, 49);
            this.label_espectaculo.Name = "label_espectaculo";
            this.label_espectaculo.Size = new System.Drawing.Size(117, 13);
            this.label_espectaculo.TabIndex = 68;
            this.label_espectaculo.Text = "[ Espectaculo + fecha ]";
            // 
            // Compra_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 462);
            this.Controls.Add(this.label_espectaculo);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridEmpresas);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_seleccion);
            this.Name = "Compra_Detalle";
            this.Text = "Detalle de compra";
            this.Load += new System.EventHandler(this.Compra_Detalle_Load);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.btn_seleccion, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.dataGridEmpresas, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label_total, 0);
            this.Controls.SetChildIndex(this.label_espectaculo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_seleccion;
        protected System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView dataGridEmpresas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_espectaculo;

    }
}
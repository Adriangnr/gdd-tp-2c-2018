namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    partial class Factura_Detalle
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.formaPago = new System.Windows.Forms.Label();
            this.totalComision = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(775, 442);
            this.footer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCerrar.Location = new System.Drawing.Point(881, 394);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(103, 36);
            this.btnCerrar.TabIndex = 61;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Total de Comisiones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Fecha: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Forma de pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Total: ";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.AllowUserToOrderColumns = true;
            this.dataGridViewItems.AllowUserToResizeRows = false;
            this.dataGridViewItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewItems.Location = new System.Drawing.Point(8, 170);
            this.dataGridViewItems.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewItems.MultiSelect = false;
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.RowHeadersVisible = false;
            this.dataGridViewItems.RowTemplate.Height = 28;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.ShowCellErrors = false;
            this.dataGridViewItems.ShowCellToolTips = false;
            this.dataGridViewItems.ShowEditingIcon = false;
            this.dataGridViewItems.ShowRowErrors = false;
            this.dataGridViewItems.Size = new System.Drawing.Size(1018, 219);
            this.dataGridViewItems.TabIndex = 67;
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(218, 69);
            this.codigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(74, 20);
            this.codigo.TabIndex = 69;
            this.codigo.Text = "<codigo>";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(218, 98);
            this.fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(67, 20);
            this.fecha.TabIndex = 70;
            this.fecha.Text = "<fecha>";
            // 
            // formaPago
            // 
            this.formaPago.AutoSize = true;
            this.formaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formaPago.Location = new System.Drawing.Point(562, 69);
            this.formaPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.formaPago.Name = "formaPago";
            this.formaPago.Size = new System.Drawing.Size(105, 20);
            this.formaPago.TabIndex = 71;
            this.formaPago.Text = "<formaPago>";
            // 
            // totalComision
            // 
            this.totalComision.AutoSize = true;
            this.totalComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalComision.Location = new System.Drawing.Point(218, 128);
            this.totalComision.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalComision.Name = "totalComision";
            this.totalComision.Size = new System.Drawing.Size(123, 20);
            this.totalComision.TabIndex = 72;
            this.totalComision.Text = "<totalComision>";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(562, 98);
            this.total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(58, 20);
            this.total.TabIndex = 73;
            this.total.Text = "<total>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "Código: ";
            // 
            // Factura_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1037, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.totalComision);
            this.Controls.Add(this.formaPago);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Factura_Detalle";
            this.Text = "Facturas";
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dataGridViewItems, 0);
            this.Controls.SetChildIndex(this.codigo, 0);
            this.Controls.SetChildIndex(this.fecha, 0);
            this.Controls.SetChildIndex(this.formaPago, 0);
            this.Controls.SetChildIndex(this.totalComision, 0);
            this.Controls.SetChildIndex(this.total, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label formaPago;
        private System.Windows.Forms.Label totalComision;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label1;
    }
}
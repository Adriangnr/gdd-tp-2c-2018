namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    partial class Compra
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
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.btn_buy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridPublicaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.descripcion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Controls.Add(this.categoria);
            this.groupBox1.Controls.Add(this.dateFrom);
            this.groupBox1.Controls.SetChildIndex(this.dateFrom, 0);
            this.groupBox1.Controls.SetChildIndex(this.categoria, 0);
            this.groupBox1.Controls.SetChildIndex(this.dateTo, 0);
            this.groupBox1.Controls.SetChildIndex(this.label5, 0);
            this.groupBox1.Controls.SetChildIndex(this.btn_search, 0);
            this.groupBox1.Controls.SetChildIndex(this.descripcion, 0);
            this.groupBox1.Controls.SetChildIndex(this.label6, 0);
            this.groupBox1.Controls.SetChildIndex(this.label7, 0);
            this.groupBox1.Controls.SetChildIndex(this.label8, 0);
            // 
            // Entidad
            // 
            this.Entidad.Size = new System.Drawing.Size(67, 18);
            this.Entidad.Text = "Comprar";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(964, 349);
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(19, 151);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(145, 22);
            this.dateFrom.TabIndex = 15;
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(19, 205);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(145, 22);
            this.dateTo.TabIndex = 16;
            // 
            // btn_buy
            // 
            this.btn_buy.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_buy.Location = new System.Drawing.Point(964, 78);
            this.btn_buy.Margin = new System.Windows.Forms.Padding(0);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(129, 45);
            this.btn_buy.TabIndex = 58;
            this.btn_buy.Text = "Comprar";
            this.btn_buy.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 60;
            this.label5.Text = "Categorías";
            // 
            // categoria
            // 
            this.categoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.ForeColor = System.Drawing.SystemColors.GrayText;
            this.categoria.Location = new System.Drawing.Point(19, 45);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(145, 24);
            this.categoria.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 62;
            this.label6.Text = "Descripción";
            // 
            // descripcion
            // 
            this.descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.descripcion.Location = new System.Drawing.Point(19, 98);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(145, 24);
            this.descripcion.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 60;
            this.label7.Text = "Fecha Desde";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 60;
            this.label8.Text = "Fecha Hasta";
            // 
            // dataGridPublicaciones
            // 
            this.dataGridPublicaciones.AllowUserToAddRows = false;
            this.dataGridPublicaciones.AllowUserToDeleteRows = false;
            this.dataGridPublicaciones.AllowUserToOrderColumns = true;
            this.dataGridPublicaciones.AllowUserToResizeRows = false;
            this.dataGridPublicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPublicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPublicaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridPublicaciones.Location = new System.Drawing.Point(239, 83);
            this.dataGridPublicaciones.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridPublicaciones.MultiSelect = false;
            this.dataGridPublicaciones.Name = "dataGridPublicaciones";
            this.dataGridPublicaciones.ReadOnly = true;
            this.dataGridPublicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPublicaciones.Size = new System.Drawing.Size(694, 307);
            this.dataGridPublicaciones.TabIndex = 59;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 462);
            this.Controls.Add(this.dataGridPublicaciones);
            this.Controls.Add(this.btn_buy);
            this.Name = "Compra";
            this.Text = "Palco.NET - Comprar";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.Controls.SetChildIndex(this.btn_buy, 0);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.Entidad, 0);
            this.Controls.SetChildIndex(this.dataGridPublicaciones, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        public System.Windows.Forms.Button btn_buy;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox descripcion;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox categoria;
        private System.Windows.Forms.DataGridView dataGridPublicaciones;
    }
}
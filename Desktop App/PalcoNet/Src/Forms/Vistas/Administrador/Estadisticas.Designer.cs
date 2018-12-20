namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    partial class Estadisticas
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
            this.btn_search = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label_anio = new System.Windows.Forms.Label();
            this.label_estadisticas = new System.Windows.Forms.Label();
            this.label_trimestre = new System.Windows.Forms.Label();
            this.cb_grado = new System.Windows.Forms.ComboBox();
            this.cb_estadistica = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.Entidad = new System.Windows.Forms.Label();
            this.dataGridEstadisticas = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_search.Location = new System.Drawing.Point(19, 267);
            this.btn_search.Margin = new System.Windows.Forms.Padding(0);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(145, 45);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Obtener";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel1.Location = new System.Drawing.Point(49, 241);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 16);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Limpiar filtros";
            // 
            // label_anio
            // 
            this.label_anio.AutoSize = true;
            this.label_anio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_anio.Location = new System.Drawing.Point(15, 80);
            this.label_anio.Name = "label_anio";
            this.label_anio.Size = new System.Drawing.Size(28, 15);
            this.label_anio.TabIndex = 84;
            this.label_anio.Text = "Año";
            // 
            // label_estadisticas
            // 
            this.label_estadisticas.AutoSize = true;
            this.label_estadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estadisticas.Location = new System.Drawing.Point(15, 27);
            this.label_estadisticas.Name = "label_estadisticas";
            this.label_estadisticas.Size = new System.Drawing.Size(66, 15);
            this.label_estadisticas.TabIndex = 82;
            this.label_estadisticas.Text = "Estadística";
            // 
            // label_trimestre
            // 
            this.label_trimestre.AutoSize = true;
            this.label_trimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_trimestre.Location = new System.Drawing.Point(15, 134);
            this.label_trimestre.Name = "label_trimestre";
            this.label_trimestre.Size = new System.Drawing.Size(59, 15);
            this.label_trimestre.TabIndex = 81;
            this.label_trimestre.Text = "Trimestre";
            // 
            // cb_grado
            // 
            this.cb_grado.FormattingEnabled = true;
            this.cb_grado.Location = new System.Drawing.Point(16, 205);
            this.cb_grado.Name = "cb_grado";
            this.cb_grado.Size = new System.Drawing.Size(145, 24);
            this.cb_grado.TabIndex = 6;
            // 
            // cb_estadistica
            // 
            this.cb_estadistica.FormattingEnabled = true;
            this.cb_estadistica.Items.AddRange(new object[] {
            "Empresas con mayor cantidad de localidades no vendidas",
            "Clientes con mayores puntos vencidos",
            "Clientes con mayor cantidad de compras"});
            this.cb_estadistica.Location = new System.Drawing.Point(16, 47);
            this.cb_estadistica.Name = "cb_estadistica";
            this.cb_estadistica.Size = new System.Drawing.Size(145, 24);
            this.cb_estadistica.TabIndex = 87;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cb_estadistica);
            this.groupBox1.Controls.Add(this.cb_grado);
            this.groupBox1.Controls.Add(this.label_trimestre);
            this.groupBox1.Controls.Add(this.label_estadisticas);
            this.groupBox1.Controls.Add(this.label_anio);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(32, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 328);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 89;
            this.label1.Text = "Grado";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 22);
            this.textBox2.TabIndex = 88;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(632, 354);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(129, 45);
            this.btn_cancel.TabIndex = 59;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Entidad
            // 
            this.Entidad.AutoSize = true;
            this.Entidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entidad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Entidad.Location = new System.Drawing.Point(242, 40);
            this.Entidad.Name = "Entidad";
            this.Entidad.Size = new System.Drawing.Size(88, 18);
            this.Entidad.TabIndex = 58;
            this.Entidad.Text = "Estadísticas";
            // 
            // dataGridEstadisticas
            // 
            this.dataGridEstadisticas.AllowUserToAddRows = false;
            this.dataGridEstadisticas.AllowUserToDeleteRows = false;
            this.dataGridEstadisticas.AllowUserToOrderColumns = true;
            this.dataGridEstadisticas.AllowUserToResizeRows = false;
            this.dataGridEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEstadisticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstadisticas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridEstadisticas.Location = new System.Drawing.Point(245, 78);
            this.dataGridEstadisticas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridEstadisticas.MultiSelect = false;
            this.dataGridEstadisticas.Name = "dataGridEstadisticas";
            this.dataGridEstadisticas.ReadOnly = true;
            this.dataGridEstadisticas.RowHeadersVisible = false;
            this.dataGridEstadisticas.RowTemplate.Height = 28;
            this.dataGridEstadisticas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEstadisticas.Size = new System.Drawing.Size(500, 257);
            this.dataGridEstadisticas.TabIndex = 66;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 67;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.dataGridEstadisticas);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.Entidad);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.Entidad, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.dataGridEstadisticas, 0);
            this.Controls.SetChildIndex(this.footer, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstadisticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Label label_anio;
        public System.Windows.Forms.Label label_estadisticas;
        public System.Windows.Forms.Label label_trimestre;
        private System.Windows.Forms.ComboBox cb_grado;
        private System.Windows.Forms.ComboBox cb_estadistica;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Label Entidad;
        public System.Windows.Forms.DataGridView dataGridEstadisticas;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;

    }
}
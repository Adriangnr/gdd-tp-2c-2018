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
            this.label_anio = new System.Windows.Forms.Label();
            this.label_estadisticas = new System.Windows.Forms.Label();
            this.label_trimestre = new System.Windows.Forms.Label();
            this.cb_grado = new System.Windows.Forms.ComboBox();
            this.cb_estadistica = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_grado = new System.Windows.Forms.Label();
            this.textBox_anio = new System.Windows.Forms.TextBox();
            this.textBox_trimestre = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dataGridEstadisticas = new System.Windows.Forms.DataGridView();
            this.label_fecha_actual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(777, 428);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_search.Location = new System.Drawing.Point(97, 359);
            this.btn_search.Margin = new System.Windows.Forms.Padding(0);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(145, 45);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Obtener";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label_anio
            // 
            this.label_anio.AutoSize = true;
            this.label_anio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_anio.Location = new System.Drawing.Point(416, 27);
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
            this.label_trimestre.Location = new System.Drawing.Point(542, 27);
            this.label_trimestre.Name = "label_trimestre";
            this.label_trimestre.Size = new System.Drawing.Size(59, 15);
            this.label_trimestre.TabIndex = 81;
            this.label_trimestre.Text = "Trimestre";
            // 
            // cb_grado
            // 
            this.cb_grado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_grado.FormattingEnabled = true;
            this.cb_grado.Location = new System.Drawing.Point(668, 45);
            this.cb_grado.Name = "cb_grado";
            this.cb_grado.Size = new System.Drawing.Size(119, 24);
            this.cb_grado.TabIndex = 3;
            // 
            // cb_estadistica
            // 
            this.cb_estadistica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estadistica.FormattingEnabled = true;
            this.cb_estadistica.Location = new System.Drawing.Point(16, 47);
            this.cb_estadistica.Name = "cb_estadistica";
            this.cb_estadistica.Size = new System.Drawing.Size(395, 24);
            this.cb_estadistica.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_grado);
            this.groupBox1.Controls.Add(this.textBox_anio);
            this.groupBox1.Controls.Add(this.textBox_trimestre);
            this.groupBox1.Controls.Add(this.cb_estadistica);
            this.groupBox1.Controls.Add(this.cb_grado);
            this.groupBox1.Controls.Add(this.label_trimestre);
            this.groupBox1.Controls.Add(this.label_estadisticas);
            this.groupBox1.Controls.Add(this.label_anio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(97, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label_grado
            // 
            this.label_grado.AutoSize = true;
            this.label_grado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_grado.Location = new System.Drawing.Point(668, 24);
            this.label_grado.Name = "label_grado";
            this.label_grado.Size = new System.Drawing.Size(41, 15);
            this.label_grado.TabIndex = 89;
            this.label_grado.Text = "Grado";
            // 
            // textBox_anio
            // 
            this.textBox_anio.Location = new System.Drawing.Point(417, 47);
            this.textBox_anio.MaxLength = 4;
            this.textBox_anio.Name = "textBox_anio";
            this.textBox_anio.Size = new System.Drawing.Size(119, 22);
            this.textBox_anio.TabIndex = 1;
            // 
            // textBox_trimestre
            // 
            this.textBox_trimestre.Location = new System.Drawing.Point(543, 47);
            this.textBox_trimestre.MaxLength = 1;
            this.textBox_trimestre.Name = "textBox_trimestre";
            this.textBox_trimestre.Size = new System.Drawing.Size(119, 22);
            this.textBox_trimestre.TabIndex = 2;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(808, 359);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(129, 45);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Volver";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dataGridEstadisticas
            // 
            this.dataGridEstadisticas.AllowUserToAddRows = false;
            this.dataGridEstadisticas.AllowUserToDeleteRows = false;
            this.dataGridEstadisticas.AllowUserToOrderColumns = true;
            this.dataGridEstadisticas.AllowUserToResizeRows = false;
            this.dataGridEstadisticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstadisticas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridEstadisticas.Location = new System.Drawing.Point(97, 180);
            this.dataGridEstadisticas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridEstadisticas.MultiSelect = false;
            this.dataGridEstadisticas.Name = "dataGridEstadisticas";
            this.dataGridEstadisticas.ReadOnly = true;
            this.dataGridEstadisticas.RowHeadersVisible = false;
            this.dataGridEstadisticas.RowTemplate.Height = 28;
            this.dataGridEstadisticas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEstadisticas.Size = new System.Drawing.Size(840, 163);
            this.dataGridEstadisticas.TabIndex = 66;
            // 
            // label_fecha_actual
            // 
            this.label_fecha_actual.AutoSize = true;
            this.label_fecha_actual.ForeColor = System.Drawing.Color.DimGray;
            this.label_fecha_actual.Location = new System.Drawing.Point(805, 63);
            this.label_fecha_actual.Name = "label_fecha_actual";
            this.label_fecha_actual.Size = new System.Drawing.Size(76, 13);
            this.label_fecha_actual.TabIndex = 68;
            this.label_fecha_actual.Text = "[Fecha Actual]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(724, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Fecha actual: ";
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_fecha_actual);
            this.Controls.Add(this.dataGridEstadisticas);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_search);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.Controls.SetChildIndex(this.btn_search, 0);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.dataGridEstadisticas, 0);
            this.Controls.SetChildIndex(this.label_fecha_actual, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstadisticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_search;
        public System.Windows.Forms.Label label_anio;
        public System.Windows.Forms.Label label_estadisticas;
        public System.Windows.Forms.Label label_trimestre;
        private System.Windows.Forms.ComboBox cb_grado;
        private System.Windows.Forms.ComboBox cb_estadistica;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.DataGridView dataGridEstadisticas;
        private System.Windows.Forms.TextBox textBox_trimestre;
        public System.Windows.Forms.Label label_grado;
        private System.Windows.Forms.TextBox textBox_anio;
        private System.Windows.Forms.Label label_fecha_actual;
        private System.Windows.Forms.Label label1;

    }
}
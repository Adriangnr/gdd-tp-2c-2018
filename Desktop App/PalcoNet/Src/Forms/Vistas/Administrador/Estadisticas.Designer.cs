namespace PalcoNet.Vistas.Administrador
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
            this.label_cuit = new System.Windows.Forms.Label();
            this.label_razon_social = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.cb_anio = new System.Windows.Forms.ComboBox();
            this.cb_trimestre = new System.Windows.Forms.ComboBox();
            this.cb_estadistica = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.Entidad = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
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
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = false;
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
            // label_cuit
            // 
            this.label_cuit.AutoSize = true;
            this.label_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cuit.Location = new System.Drawing.Point(16, 82);
            this.label_cuit.Name = "label_cuit";
            this.label_cuit.Size = new System.Drawing.Size(59, 15);
            this.label_cuit.TabIndex = 84;
            this.label_cuit.Text = "Trimestre";
            // 
            // label_razon_social
            // 
            this.label_razon_social.AutoSize = true;
            this.label_razon_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_razon_social.Location = new System.Drawing.Point(16, 29);
            this.label_razon_social.Name = "label_razon_social";
            this.label_razon_social.Size = new System.Drawing.Size(28, 15);
            this.label_razon_social.TabIndex = 82;
            this.label_razon_social.Text = "Año";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(16, 136);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(66, 15);
            this.label_email.TabIndex = 81;
            this.label_email.Text = "Estadística";
            // 
            // cb_anio
            // 
            this.cb_anio.FormattingEnabled = true;
            this.cb_anio.Location = new System.Drawing.Point(16, 48);
            this.cb_anio.Name = "cb_anio";
            this.cb_anio.Size = new System.Drawing.Size(145, 24);
            this.cb_anio.TabIndex = 6;
            // 
            // cb_trimestre
            // 
            this.cb_trimestre.FormattingEnabled = true;
            this.cb_trimestre.Location = new System.Drawing.Point(16, 102);
            this.cb_trimestre.Name = "cb_trimestre";
            this.cb_trimestre.Size = new System.Drawing.Size(145, 24);
            this.cb_trimestre.TabIndex = 86;
            // 
            // cb_estadistica
            // 
            this.cb_estadistica.FormattingEnabled = true;
            this.cb_estadistica.Items.AddRange(new object[] {
            "Empresas con mayor cantidad de localidades no vendidas",
            "Clientes con mayores puntos vencidos",
            "Clientes con mayor cantidad de compras"});
            this.cb_estadistica.Location = new System.Drawing.Point(16, 155);
            this.cb_estadistica.Name = "cb_estadistica";
            this.cb_estadistica.Size = new System.Drawing.Size(145, 24);
            this.cb_estadistica.TabIndex = 87;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_estadistica);
            this.groupBox1.Controls.Add(this.cb_trimestre);
            this.groupBox1.Controls.Add(this.cb_anio);
            this.groupBox1.Controls.Add(this.label_email);
            this.groupBox1.Controls.Add(this.label_razon_social);
            this.groupBox1.Controls.Add(this.label_cuit);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(32, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 328);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(245, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(366, 316);
            this.listBox1.TabIndex = 57;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.Entidad);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.Entidad, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Label label_cuit;
        public System.Windows.Forms.Label label_razon_social;
        public System.Windows.Forms.Label label_email;
        private System.Windows.Forms.ComboBox cb_anio;
        private System.Windows.Forms.ComboBox cb_trimestre;
        private System.Windows.Forms.ComboBox cb_estadistica;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Label Entidad;
        public System.Windows.Forms.ListBox listBox1;

    }
}
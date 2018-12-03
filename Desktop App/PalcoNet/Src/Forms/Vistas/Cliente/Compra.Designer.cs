﻿namespace PalcoNet.Src.Forms.Vistas.Cliente
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
            this.fechaInicioVista = new System.Windows.Forms.DateTimePicker();
            this.fechaFinVista = new System.Windows.Forms.DateTimePicker();
            this.btn_buy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.categoriasVista = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridPublicaciones = new System.Windows.Forms.DataGridView();
            this.categoriasComboBox = new System.Windows.Forms.ComboBox();
            this.agregarCategoria = new System.Windows.Forms.Button();
            this.fechaInicioCheckBox = new System.Windows.Forms.CheckBox();
            this.fechaFinCheckBox = new System.Windows.Forms.CheckBox();
            this.quitarCategoria = new System.Windows.Forms.Button();
            this.panelPaginatorControls = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quitarCategoria);
            this.groupBox1.Controls.Add(this.fechaFinCheckBox);
            this.groupBox1.Controls.Add(this.fechaInicioCheckBox);
            this.groupBox1.Controls.Add(this.agregarCategoria);
            this.groupBox1.Controls.Add(this.categoriasComboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.descripcion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.fechaFinVista);
            this.groupBox1.Controls.Add(this.categoriasVista);
            this.groupBox1.Controls.Add(this.fechaInicioVista);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Size = new System.Drawing.Size(284, 552);
            this.groupBox1.Controls.SetChildIndex(this.linkLabel1, 0);
            this.groupBox1.Controls.SetChildIndex(this.fechaInicioVista, 0);
            this.groupBox1.Controls.SetChildIndex(this.categoriasVista, 0);
            this.groupBox1.Controls.SetChildIndex(this.fechaFinVista, 0);
            this.groupBox1.Controls.SetChildIndex(this.label5, 0);
            this.groupBox1.Controls.SetChildIndex(this.descripcion, 0);
            this.groupBox1.Controls.SetChildIndex(this.label6, 0);
            this.groupBox1.Controls.SetChildIndex(this.label7, 0);
            this.groupBox1.Controls.SetChildIndex(this.label8, 0);
            this.groupBox1.Controls.SetChildIndex(this.categoriasComboBox, 0);
            this.groupBox1.Controls.SetChildIndex(this.agregarCategoria, 0);
            this.groupBox1.Controls.SetChildIndex(this.btn_search, 0);
            this.groupBox1.Controls.SetChildIndex(this.fechaInicioCheckBox, 0);
            this.groupBox1.Controls.SetChildIndex(this.fechaFinCheckBox, 0);
            this.groupBox1.Controls.SetChildIndex(this.quitarCategoria, 0);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(28, 452);
            // 
            // Entidad
            // 
            this.Entidad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Entidad.Size = new System.Drawing.Size(107, 29);
            this.Entidad.Text = "Comprar";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(1446, 537);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(84, 417);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // fechaInicioVista
            // 
            this.fechaInicioVista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicioVista.Location = new System.Drawing.Point(28, 292);
            this.fechaInicioVista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaInicioVista.Name = "fechaInicioVista";
            this.fechaInicioVista.Size = new System.Drawing.Size(184, 30);
            this.fechaInicioVista.TabIndex = 15;
            // 
            // fechaFinVista
            // 
            this.fechaFinVista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFinVista.Location = new System.Drawing.Point(28, 375);
            this.fechaFinVista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaFinVista.Name = "fechaFinVista";
            this.fechaFinVista.Size = new System.Drawing.Size(182, 30);
            this.fechaFinVista.TabIndex = 16;
            // 
            // btn_buy
            // 
            this.btn_buy.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_buy.Location = new System.Drawing.Point(1446, 128);
            this.btn_buy.Margin = new System.Windows.Forms.Padding(0);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(194, 69);
            this.btn_buy.TabIndex = 58;
            this.btn_buy.Text = "Comprar";
            this.btn_buy.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 60;
            this.label5.Text = "Categorías";
            // 
            // categoriasVista
            // 
            this.categoriasVista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoriasVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriasVista.ForeColor = System.Drawing.SystemColors.GrayText;
            this.categoriasVista.Location = new System.Drawing.Point(28, 63);
            this.categoriasVista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoriasVista.Name = "categoriasVista";
            this.categoriasVista.ReadOnly = true;
            this.categoriasVista.Size = new System.Drawing.Size(228, 33);
            this.categoriasVista.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 62;
            this.label6.Text = "Descripción";
            // 
            // descripcion
            // 
            this.descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.descripcion.Location = new System.Drawing.Point(28, 211);
            this.descripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(228, 33);
            this.descripcion.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 265);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 22);
            this.label7.TabIndex = 60;
            this.label7.Text = "Fecha Desde";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 348);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 22);
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
            this.dataGridPublicaciones.Location = new System.Drawing.Point(358, 131);
            this.dataGridPublicaciones.MultiSelect = false;
            this.dataGridPublicaciones.Name = "dataGridPublicaciones";
            this.dataGridPublicaciones.ReadOnly = true;
            this.dataGridPublicaciones.RowHeadersVisible = false;
            this.dataGridPublicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPublicaciones.Size = new System.Drawing.Size(1041, 472);
            this.dataGridPublicaciones.TabIndex = 59;
            // 
            // categoriasComboBox
            // 
            this.categoriasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriasComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriasComboBox.FormattingEnabled = true;
            this.categoriasComboBox.Location = new System.Drawing.Point(28, 126);
            this.categoriasComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoriasComboBox.Name = "categoriasComboBox";
            this.categoriasComboBox.Size = new System.Drawing.Size(144, 33);
            this.categoriasComboBox.TabIndex = 63;
            // 
            // agregarCategoria
            // 
            this.agregarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarCategoria.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarCategoria.ForeColor = System.Drawing.Color.Black;
            this.agregarCategoria.Location = new System.Drawing.Point(182, 126);
            this.agregarCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.agregarCategoria.Name = "agregarCategoria";
            this.agregarCategoria.Size = new System.Drawing.Size(36, 37);
            this.agregarCategoria.TabIndex = 60;
            this.agregarCategoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.agregarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.agregarCategoria.UseVisualStyleBackColor = true;
            this.agregarCategoria.Click += new System.EventHandler(this.agregarCategoria_Click);
            // 
            // fechaInicioCheckBox
            // 
            this.fechaInicioCheckBox.AutoSize = true;
            this.fechaInicioCheckBox.Location = new System.Drawing.Point(224, 300);
            this.fechaInicioCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaInicioCheckBox.Name = "fechaInicioCheckBox";
            this.fechaInicioCheckBox.Size = new System.Drawing.Size(22, 21);
            this.fechaInicioCheckBox.TabIndex = 60;
            this.fechaInicioCheckBox.UseVisualStyleBackColor = true;
            // 
            // fechaFinCheckBox
            // 
            this.fechaFinCheckBox.AutoSize = true;
            this.fechaFinCheckBox.Location = new System.Drawing.Point(222, 383);
            this.fechaFinCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaFinCheckBox.Name = "fechaFinCheckBox";
            this.fechaFinCheckBox.Size = new System.Drawing.Size(22, 21);
            this.fechaFinCheckBox.TabIndex = 64;
            this.fechaFinCheckBox.UseVisualStyleBackColor = true;
            // 
            // quitarCategoria
            // 
            this.quitarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quitarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitarCategoria.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitarCategoria.ForeColor = System.Drawing.Color.Black;
            this.quitarCategoria.Location = new System.Drawing.Point(222, 126);
            this.quitarCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quitarCategoria.Name = "quitarCategoria";
            this.quitarCategoria.Size = new System.Drawing.Size(36, 37);
            this.quitarCategoria.TabIndex = 65;
            this.quitarCategoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.quitarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.quitarCategoria.UseVisualStyleBackColor = true;
            this.quitarCategoria.Click += new System.EventHandler(this.quitarCategoria_Click);
            // 
            // panelPaginatorControls
            // 
            this.panelPaginatorControls.Location = new System.Drawing.Point(538, 609);
            this.panelPaginatorControls.Name = "panelPaginatorControls";
            this.panelPaginatorControls.Size = new System.Drawing.Size(704, 63);
            this.panelPaginatorControls.TabIndex = 60;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 711);
            this.Controls.Add(this.panelPaginatorControls);
            this.Controls.Add(this.dataGridPublicaciones);
            this.Controls.Add(this.btn_buy);
            this.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.Name = "Compra";
            this.Text = "Palco.NET - Comprar";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.Controls.SetChildIndex(this.btn_buy, 0);
            this.Controls.SetChildIndex(this.dataGridPublicaciones, 0);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.Entidad, 0);
            this.Controls.SetChildIndex(this.panelPaginatorControls, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaFinVista;
        private System.Windows.Forms.DateTimePicker fechaInicioVista;
        public System.Windows.Forms.Button btn_buy;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox descripcion;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox categoriasVista;
        private System.Windows.Forms.DataGridView dataGridPublicaciones;
        private System.Windows.Forms.ComboBox categoriasComboBox;
        private System.Windows.Forms.Button agregarCategoria;
        private System.Windows.Forms.CheckBox fechaFinCheckBox;
        private System.Windows.Forms.CheckBox fechaInicioCheckBox;
        private System.Windows.Forms.Button quitarCategoria;
        private System.Windows.Forms.Panel panelPaginatorControls;
    }
}
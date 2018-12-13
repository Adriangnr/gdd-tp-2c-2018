namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    partial class Grado_Publicacion
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
            this.dataGridGrados = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAgregarGrado = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrados)).BeginInit();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(493, 638);
            // 
            // dataGridGrados
            // 
            this.dataGridGrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGrados.Location = new System.Drawing.Point(48, 133);
            this.dataGridGrados.MultiSelect = false;
            this.dataGridGrados.Name = "dataGridGrados";
            this.dataGridGrados.ReadOnly = true;
            this.dataGridGrados.RowTemplate.Height = 28;
            this.dataGridGrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridGrados.Size = new System.Drawing.Size(535, 474);
            this.dataGridGrados.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.Location = new System.Drawing.Point(638, 374);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(194, 69);
            this.btnEliminar.TabIndex = 77;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancel.Location = new System.Drawing.Point(634, 550);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 69);
            this.btnCancel.TabIndex = 76;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAgregarGrado
            // 
            this.btnAgregarGrado.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarGrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarGrado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarGrado.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregarGrado.Location = new System.Drawing.Point(638, 145);
            this.btnAgregarGrado.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarGrado.Name = "btnAgregarGrado";
            this.btnAgregarGrado.Size = new System.Drawing.Size(194, 69);
            this.btnAgregarGrado.TabIndex = 75;
            this.btnAgregarGrado.Text = "Nuevo grado";
            this.btnAgregarGrado.UseVisualStyleBackColor = false;
            this.btnAgregarGrado.Click += new System.EventHandler(this.btnAgregarGrado_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditar.Location = new System.Drawing.Point(638, 263);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(194, 69);
            this.btnEditar.TabIndex = 78;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Grado_Publicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 666);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAgregarGrado);
            this.Controls.Add(this.dataGridGrados);
            this.Name = "Grado_Publicacion";
            this.Text = "Grado_Publicacion";
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.dataGridGrados, 0);
            this.Controls.SetChildIndex(this.btnAgregarGrado, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridGrados;
        public System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnAgregarGrado;
        public System.Windows.Forms.Button btnEditar;
    }
}
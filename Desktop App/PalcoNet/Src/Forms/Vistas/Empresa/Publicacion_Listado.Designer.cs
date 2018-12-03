namespace PalcoNet.Src.Forms.Vistas.Empresa
{
    partial class Publicacion_Listado
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.Entidad = new System.Windows.Forms.Label();
            this.dataGridPublicaciones = new System.Windows.Forms.DataGridView();
            this.btn_previousPage = new System.Windows.Forms.Button();
            this.btn_nextPage = new System.Windows.Forms.Button();
            this.btn_firstPage = new System.Windows.Forms.Button();
            this.btn_lastPage = new System.Windows.Forms.Button();
            this.paginaActual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPaginas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_edit.Location = new System.Drawing.Point(632, 83);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(129, 45);
            this.btn_edit.TabIndex = 57;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_create.Location = new System.Drawing.Point(632, 290);
            this.btn_create.Margin = new System.Windows.Forms.Padding(0);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(129, 45);
            this.btn_create.TabIndex = 58;
            this.btn_create.Text = "Crear Nueva";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(632, 354);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(129, 45);
            this.btn_cancel.TabIndex = 60;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Entidad
            // 
            this.Entidad.AutoSize = true;
            this.Entidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entidad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Entidad.Location = new System.Drawing.Point(215, 40);
            this.Entidad.Name = "Entidad";
            this.Entidad.Size = new System.Drawing.Size(100, 18);
            this.Entidad.TabIndex = 61;
            this.Entidad.Text = "Publicaciones";
            // 
            // dataGridPublicaciones
            // 
            this.dataGridPublicaciones.AllowUserToAddRows = false;
            this.dataGridPublicaciones.AllowUserToDeleteRows = false;
            this.dataGridPublicaciones.AllowUserToResizeRows = false;
            this.dataGridPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPublicaciones.Location = new System.Drawing.Point(32, 83);
            this.dataGridPublicaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridPublicaciones.Name = "dataGridPublicaciones";
            this.dataGridPublicaciones.ReadOnly = true;
            this.dataGridPublicaciones.RowHeadersVisible = false;
            this.dataGridPublicaciones.RowTemplate.Height = 28;
            this.dataGridPublicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPublicaciones.Size = new System.Drawing.Size(584, 252);
            this.dataGridPublicaciones.TabIndex = 62;
            // 
            // btn_previousPage
            // 
            this.btn_previousPage.Location = new System.Drawing.Point(239, 354);
            this.btn_previousPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_previousPage.Name = "btn_previousPage";
            this.btn_previousPage.Size = new System.Drawing.Size(50, 21);
            this.btn_previousPage.TabIndex = 63;
            this.btn_previousPage.Text = "<";
            this.btn_previousPage.UseVisualStyleBackColor = true;
            this.btn_previousPage.Click += new System.EventHandler(this.btn_previousPage_Click);
            // 
            // btn_nextPage
            // 
            this.btn_nextPage.Location = new System.Drawing.Point(408, 354);
            this.btn_nextPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_nextPage.Name = "btn_nextPage";
            this.btn_nextPage.Size = new System.Drawing.Size(50, 21);
            this.btn_nextPage.TabIndex = 64;
            this.btn_nextPage.Text = ">";
            this.btn_nextPage.UseVisualStyleBackColor = true;
            this.btn_nextPage.Click += new System.EventHandler(this.btn_nextPage_Click);
            // 
            // btn_firstPage
            // 
            this.btn_firstPage.Location = new System.Drawing.Point(185, 354);
            this.btn_firstPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_firstPage.Name = "btn_firstPage";
            this.btn_firstPage.Size = new System.Drawing.Size(50, 21);
            this.btn_firstPage.TabIndex = 65;
            this.btn_firstPage.Text = "<<";
            this.btn_firstPage.UseVisualStyleBackColor = true;
            this.btn_firstPage.Click += new System.EventHandler(this.btn_firstPage_Click);
            // 
            // btn_lastPage
            // 
            this.btn_lastPage.Location = new System.Drawing.Point(462, 354);
            this.btn_lastPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_lastPage.Name = "btn_lastPage";
            this.btn_lastPage.Size = new System.Drawing.Size(50, 21);
            this.btn_lastPage.TabIndex = 66;
            this.btn_lastPage.Text = ">>";
            this.btn_lastPage.UseVisualStyleBackColor = true;
            this.btn_lastPage.Click += new System.EventHandler(this.btn_lastPage_Click);
            // 
            // paginaActual
            // 
            this.paginaActual.AutoSize = true;
            this.paginaActual.Location = new System.Drawing.Point(305, 362);
            this.paginaActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paginaActual.Name = "paginaActual";
            this.paginaActual.Size = new System.Drawing.Size(13, 13);
            this.paginaActual.TabIndex = 67;
            this.paginaActual.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 361);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "de";
            // 
            // totalPaginas
            // 
            this.totalPaginas.AutoSize = true;
            this.totalPaginas.Location = new System.Drawing.Point(371, 361);
            this.totalPaginas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPaginas.Name = "totalPaginas";
            this.totalPaginas.Size = new System.Drawing.Size(13, 13);
            this.totalPaginas.TabIndex = 69;
            this.totalPaginas.Text = "0";
            // 
            // Publicacion_Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.totalPaginas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paginaActual);
            this.Controls.Add(this.btn_lastPage);
            this.Controls.Add(this.btn_firstPage);
            this.Controls.Add(this.btn_nextPage);
            this.Controls.Add(this.btn_previousPage);
            this.Controls.Add(this.dataGridPublicaciones);
            this.Controls.Add(this.Entidad);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_edit);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Publicacion_Listado";
            this.Text = "Palco.NET - Publicaciones";
            this.Load += new System.EventHandler(this.Pulicacion_Listado_Load);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.btn_edit, 0);
            this.Controls.SetChildIndex(this.btn_create, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.Entidad, 0);
            this.Controls.SetChildIndex(this.dataGridPublicaciones, 0);
            this.Controls.SetChildIndex(this.btn_previousPage, 0);
            this.Controls.SetChildIndex(this.btn_nextPage, 0);
            this.Controls.SetChildIndex(this.btn_firstPage, 0);
            this.Controls.SetChildIndex(this.btn_lastPage, 0);
            this.Controls.SetChildIndex(this.paginaActual, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.totalPaginas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_edit;
        public System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Label Entidad;
        private System.Windows.Forms.DataGridView dataGridPublicaciones;
        private System.Windows.Forms.Button btn_previousPage;
        private System.Windows.Forms.Button btn_nextPage;
        private System.Windows.Forms.Button btn_firstPage;
        private System.Windows.Forms.Button btn_lastPage;
        private System.Windows.Forms.Label paginaActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPaginas;
    }
}
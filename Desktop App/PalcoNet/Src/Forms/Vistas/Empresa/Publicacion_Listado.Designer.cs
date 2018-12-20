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
            this.panelPaginatorControls = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnPublicar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(1086, 645);
            this.footer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_edit.Location = new System.Drawing.Point(1233, 128);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(194, 69);
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
            this.btn_create.Location = new System.Drawing.Point(1233, 446);
            this.btn_create.Margin = new System.Windows.Forms.Padding(0);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(194, 69);
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
            this.btn_cancel.Location = new System.Drawing.Point(1233, 545);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(194, 69);
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
            this.Entidad.Location = new System.Drawing.Point(322, 62);
            this.Entidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Entidad.Name = "Entidad";
            this.Entidad.Size = new System.Drawing.Size(164, 29);
            this.Entidad.TabIndex = 61;
            this.Entidad.Text = "Publicaciones";
            // 
            // dataGridPublicaciones
            // 
            this.dataGridPublicaciones.AllowUserToAddRows = false;
            this.dataGridPublicaciones.AllowUserToDeleteRows = false;
            this.dataGridPublicaciones.AllowUserToResizeRows = false;
            this.dataGridPublicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPublicaciones.Location = new System.Drawing.Point(48, 128);
            this.dataGridPublicaciones.MultiSelect = false;
            this.dataGridPublicaciones.Name = "dataGridPublicaciones";
            this.dataGridPublicaciones.ReadOnly = true;
            this.dataGridPublicaciones.RowHeadersVisible = false;
            this.dataGridPublicaciones.RowTemplate.Height = 28;
            this.dataGridPublicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPublicaciones.Size = new System.Drawing.Size(1154, 388);
            this.dataGridPublicaciones.TabIndex = 62;
            this.dataGridPublicaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPublicaciones_CellContentClick);
            // 
            // panelPaginatorControls
            // 
            this.panelPaginatorControls.Location = new System.Drawing.Point(369, 545);
            this.panelPaginatorControls.Name = "panelPaginatorControls";
            this.panelPaginatorControls.Size = new System.Drawing.Size(530, 69);
            this.panelPaginatorControls.TabIndex = 63;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFinalizar.Location = new System.Drawing.Point(1233, 287);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(194, 69);
            this.btnFinalizar.TabIndex = 64;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Visible = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnPublicar
            // 
            this.btnPublicar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPublicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublicar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPublicar.Location = new System.Drawing.Point(1233, 207);
            this.btnPublicar.Margin = new System.Windows.Forms.Padding(0);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(194, 69);
            this.btnPublicar.TabIndex = 65;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = false;
            this.btnPublicar.Visible = false;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // Publicacion_Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 678);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.panelPaginatorControls);
            this.Controls.Add(this.dataGridPublicaciones);
            this.Controls.Add(this.Entidad);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_edit);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Publicacion_Listado";
            this.Text = "Palco.NET - Publicaciones";
            this.Load += new System.EventHandler(this.Pulicacion_Listado_Load);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.btn_edit, 0);
            this.Controls.SetChildIndex(this.btn_create, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.Entidad, 0);
            this.Controls.SetChildIndex(this.dataGridPublicaciones, 0);
            this.Controls.SetChildIndex(this.panelPaginatorControls, 0);
            this.Controls.SetChildIndex(this.btnFinalizar, 0);
            this.Controls.SetChildIndex(this.btnPublicar, 0);
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
        private System.Windows.Forms.Panel panelPaginatorControls;
        public System.Windows.Forms.Button btnFinalizar;
        public System.Windows.Forms.Button btnPublicar;
    }
}
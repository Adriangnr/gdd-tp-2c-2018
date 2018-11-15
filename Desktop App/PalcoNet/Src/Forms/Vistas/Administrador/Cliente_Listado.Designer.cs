namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    partial class Cliente_Listado
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_apellido = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.btn_habilitar = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.dni);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label_apellido);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.apellido);
            this.groupBox1.Controls.Add(this.label_nombre);
            this.groupBox1.Controls.SetChildIndex(this.label_nombre, 0);
            this.groupBox1.Controls.SetChildIndex(this.apellido, 0);
            this.groupBox1.Controls.SetChildIndex(this.nombre, 0);
            this.groupBox1.Controls.SetChildIndex(this.label_apellido, 0);
            this.groupBox1.Controls.SetChildIndex(this.btn_search, 0);
            this.groupBox1.Controls.SetChildIndex(this.label7, 0);
            this.groupBox1.Controls.SetChildIndex(this.label8, 0);
            this.groupBox1.Controls.SetChildIndex(this.dni, 0);
            this.groupBox1.Controls.SetChildIndex(this.email, 0);
            // 
            // btn_search
            // 
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Entidad
            // 
            this.Entidad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Entidad.Size = new System.Drawing.Size(101, 29);
            this.Entidad.Text = "Clientes";
            // 
            // listBox1
            // 
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(358, 128);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.listBox1.Size = new System.Drawing.Size(26, 24);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 285);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 22);
            this.label8.TabIndex = 66;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 22);
            this.label7.TabIndex = 67;
            this.label7.Text = "DNI";
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_apellido.Location = new System.Drawing.Point(28, 118);
            this.label_apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(74, 22);
            this.label_apellido.TabIndex = 70;
            this.label_apellido.Text = "Apellido";
            // 
            // apellido
            // 
            this.apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.ForeColor = System.Drawing.SystemColors.GrayText;
            this.apellido.Location = new System.Drawing.Point(28, 148);
            this.apellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(216, 33);
            this.apellido.TabIndex = 69;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(28, 37);
            this.label_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(73, 22);
            this.label_nombre.TabIndex = 68;
            this.label_nombre.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.nombre.Location = new System.Drawing.Point(28, 66);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(216, 33);
            this.nombre.TabIndex = 65;
            // 
            // dni
            // 
            this.dni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dni.Location = new System.Drawing.Point(28, 229);
            this.dni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(216, 33);
            this.dni.TabIndex = 71;
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.GrayText;
            this.email.Location = new System.Drawing.Point(28, 312);
            this.email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(216, 33);
            this.email.TabIndex = 72;
            // 
            // btn_habilitar
            // 
            this.btn_habilitar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_habilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_habilitar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_habilitar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_habilitar.Location = new System.Drawing.Point(948, 128);
            this.btn_habilitar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_habilitar.Name = "btn_habilitar";
            this.btn_habilitar.Size = new System.Drawing.Size(194, 69);
            this.btn_habilitar.TabIndex = 59;
            this.btn_habilitar.Text = "Deshabilitar";
            this.btn_habilitar.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_edit.Location = new System.Drawing.Point(948, 217);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(194, 69);
            this.btn_edit.TabIndex = 60;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_crear
            // 
            this.btn_crear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_crear.Location = new System.Drawing.Point(948, 446);
            this.btn_crear.Margin = new System.Windows.Forms.Padding(0);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(194, 69);
            this.btn_crear.TabIndex = 61;
            this.btn_crear.Text = "Cargar Nuevo";
            this.btn_crear.UseVisualStyleBackColor = false;
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(358, 128);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.RowTemplate.Height = 28;
            this.dataGridClientes.Size = new System.Drawing.Size(547, 472);
            this.dataGridClientes.TabIndex = 62;
            // 
            // Cliente_Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 678);
            this.Controls.Add(this.dataGridClientes);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_habilitar);
            this.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.Name = "Cliente_Listado";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Cliente_Listado_Load);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.Entidad, 0);
            this.Controls.SetChildIndex(this.btn_habilitar, 0);
            this.Controls.SetChildIndex(this.btn_edit, 0);
            this.Controls.SetChildIndex(this.btn_crear, 0);
            this.Controls.SetChildIndex(this.dataGridClientes, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label_apellido;
        public System.Windows.Forms.TextBox nombre;
        public System.Windows.Forms.TextBox apellido;
        public System.Windows.Forms.Label label_nombre;
        public System.Windows.Forms.TextBox email;
        public System.Windows.Forms.TextBox dni;
        public System.Windows.Forms.Button btn_habilitar;
        public System.Windows.Forms.Button btn_edit;
        public System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.DataGridView dataGridClientes;
    }
}
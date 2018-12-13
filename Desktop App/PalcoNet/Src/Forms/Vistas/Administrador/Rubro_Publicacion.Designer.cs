namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    partial class Rubro_Publicacion
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
            this.list_rubros = new System.Windows.Forms.ListBox();
            this.btnAgregarRubro = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNuevoRubro = new System.Windows.Forms.TextBox();
            this.btnNuevoRubro = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(376, 645);
            // 
            // list_rubros
            // 
            this.list_rubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.list_rubros.FormattingEnabled = true;
            this.list_rubros.ItemHeight = 29;
            this.list_rubros.Location = new System.Drawing.Point(48, 112);
            this.list_rubros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list_rubros.Name = "list_rubros";
            this.list_rubros.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.list_rubros.Size = new System.Drawing.Size(434, 468);
            this.list_rubros.TabIndex = 69;
            // 
            // btnAgregarRubro
            // 
            this.btnAgregarRubro.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRubro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRubro.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregarRubro.Location = new System.Drawing.Point(539, 195);
            this.btnAgregarRubro.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarRubro.Name = "btnAgregarRubro";
            this.btnAgregarRubro.Size = new System.Drawing.Size(194, 69);
            this.btnAgregarRubro.TabIndex = 70;
            this.btnAgregarRubro.Text = "Agregar";
            this.btnAgregarRubro.UseVisualStyleBackColor = false;
            this.btnAgregarRubro.Click += new System.EventHandler(this.btnAgregarRubro_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancel.Location = new System.Drawing.Point(535, 511);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 69);
            this.btnCancel.TabIndex = 71;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNuevoRubro
            // 
            this.txtNuevoRubro.Location = new System.Drawing.Point(539, 142);
            this.txtNuevoRubro.Name = "txtNuevoRubro";
            this.txtNuevoRubro.Size = new System.Drawing.Size(194, 26);
            this.txtNuevoRubro.TabIndex = 72;
            // 
            // btnNuevoRubro
            // 
            this.btnNuevoRubro.AutoSize = true;
            this.btnNuevoRubro.Location = new System.Drawing.Point(539, 112);
            this.btnNuevoRubro.Name = "btnNuevoRubro";
            this.btnNuevoRubro.Size = new System.Drawing.Size(102, 20);
            this.btnNuevoRubro.TabIndex = 73;
            this.btnNuevoRubro.Text = "Nuevo Rubro";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.Location = new System.Drawing.Point(539, 309);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(194, 69);
            this.btnEliminar.TabIndex = 74;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Rubro_Publicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 674);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevoRubro);
            this.Controls.Add(this.txtNuevoRubro);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAgregarRubro);
            this.Controls.Add(this.list_rubros);
            this.Name = "Rubro_Publicacion";
            this.Text = "Rubros";
            this.Controls.SetChildIndex(this.list_rubros, 0);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.btnAgregarRubro, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtNuevoRubro, 0);
            this.Controls.SetChildIndex(this.btnNuevoRubro, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_rubros;
        public System.Windows.Forms.Button btnAgregarRubro;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNuevoRubro;
        private System.Windows.Forms.Label btnNuevoRubro;
        public System.Windows.Forms.Button btnEliminar;
    }
}
namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    partial class Rol_Creacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.list_funcionalidades = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.label_limpiar_seleccion = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list_funcionalidades);
            this.groupBox1.Location = new System.Drawing.Point(477, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(645, 375);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionalidades";
            // 
            // list_funcionalidades
            // 
            this.list_funcionalidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_funcionalidades.FormattingEnabled = true;
            this.list_funcionalidades.HorizontalScrollbar = true;
            this.list_funcionalidades.Location = new System.Drawing.Point(28, 35);
            this.list_funcionalidades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list_funcionalidades.Name = "list_funcionalidades";
            this.list_funcionalidades.Size = new System.Drawing.Size(579, 294);
            this.list_funcionalidades.Sorted = true;
            this.list_funcionalidades.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(57, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(172, 149);
            this.textBox_nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(204, 26);
            this.textBox_nombre.TabIndex = 31;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(726, 542);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(194, 69);
            this.btn_cancel.TabIndex = 30;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_crear
            // 
            this.btn_crear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_crear.Location = new System.Drawing.Point(928, 542);
            this.btn_crear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(194, 69);
            this.btn_crear.TabIndex = 29;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = false;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // label_limpiar_seleccion
            // 
            this.label_limpiar_seleccion.AutoSize = true;
            this.label_limpiar_seleccion.Location = new System.Drawing.Point(477, 505);
            this.label_limpiar_seleccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_limpiar_seleccion.Name = "label_limpiar_seleccion";
            this.label_limpiar_seleccion.Size = new System.Drawing.Size(225, 20);
            this.label_limpiar_seleccion.TabIndex = 34;
            this.label_limpiar_seleccion.TabStop = true;
            this.label_limpiar_seleccion.Text = "Quitar todos los seleccionados";
            this.label_limpiar_seleccion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_limpiar_seleccion_LinkClicked);
            // 
            // Rol_Creacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 678);
            this.Controls.Add(this.label_limpiar_seleccion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_crear);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Rol_Creacion";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Rol_Creacion_Load);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.btn_crear, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.textBox_nombre, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label_limpiar_seleccion, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox list_funcionalidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.LinkLabel label_limpiar_seleccion;
    }
}
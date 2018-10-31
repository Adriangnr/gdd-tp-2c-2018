namespace PalcoNet.Vistas.Administrador
{
    partial class Rol_Listado
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.list_Roles = new System.Windows.Forms.ListView();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.Entidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(632, 354);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(129, 45);
            this.btn_cancel.TabIndex = 64;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // list_Roles
            // 
            this.list_Roles.Location = new System.Drawing.Point(32, 83);
            this.list_Roles.Name = "list_Roles";
            this.list_Roles.Size = new System.Drawing.Size(580, 316);
            this.list_Roles.TabIndex = 63;
            this.list_Roles.UseCompatibleStateImageBehavior = false;
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
            this.btn_create.TabIndex = 62;
            this.btn_create.Text = "Crear Nuevo";
            this.btn_create.UseVisualStyleBackColor = false;
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
            this.btn_edit.TabIndex = 61;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // Entidad
            // 
            this.Entidad.AutoSize = true;
            this.Entidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entidad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Entidad.Location = new System.Drawing.Point(215, 39);
            this.Entidad.Name = "Entidad";
            this.Entidad.Size = new System.Drawing.Size(47, 18);
            this.Entidad.TabIndex = 65;
            this.Entidad.Text = "Roles";
            // 
            // Rol_Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.Entidad);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.list_Roles);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_edit);
            this.Name = "Rol_Listado";
            this.Text = "Palco.NET - Roles";
            this.Load += new System.EventHandler(this.Rol_Listado_Load);
            this.Controls.SetChildIndex(this.btn_edit, 0);
            this.Controls.SetChildIndex(this.btn_create, 0);
            this.Controls.SetChildIndex(this.list_Roles, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.Entidad, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ListView list_Roles;
        public System.Windows.Forms.Button btn_create;
        public System.Windows.Forms.Button btn_edit;
        public System.Windows.Forms.Label Entidad;
    }
}
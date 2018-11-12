namespace PalcoNet.Src.Forms.Vistas.Administrador
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
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.list_Roles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_create.Location = new System.Drawing.Point(632, 286);
            this.btn_create.Margin = new System.Windows.Forms.Padding(0);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(129, 45);
            this.btn_create.TabIndex = 65;
            this.btn_create.Text = "Crear Nuevo";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_edit.Location = new System.Drawing.Point(632, 79);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(129, 45);
            this.btn_edit.TabIndex = 64;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(632, 350);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(129, 45);
            this.btn_cancel.TabIndex = 67;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // list_Roles
            // 
            this.list_Roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.list_Roles.FormattingEnabled = true;
            this.list_Roles.ItemHeight = 20;
            this.list_Roles.Location = new System.Drawing.Point(32, 79);
            this.list_Roles.Name = "list_Roles";
            this.list_Roles.Size = new System.Drawing.Size(580, 304);
            this.list_Roles.TabIndex = 68;
            // 
            // Rol_Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.list_Roles);
            this.Name = "Rol_Listado";
            this.Text = "Rol_Listado";
            this.Load += new System.EventHandler(this.Rol_Listado_Load);
            this.Controls.SetChildIndex(this.list_Roles, 0);
            this.Controls.SetChildIndex(this.btn_edit, 0);
            this.Controls.SetChildIndex(this.btn_create, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_create;
        public System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ListBox list_Roles;

    }
}
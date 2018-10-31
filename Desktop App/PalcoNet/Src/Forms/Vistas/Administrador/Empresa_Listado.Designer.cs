namespace PalcoNet.Abm_Empresa_Espectaculo
{
    partial class Form1
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
            this.email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label_cuit = new System.Windows.Forms.Label();
            this.razon_social = new System.Windows.Forms.TextBox();
            this.cuit = new System.Windows.Forms.TextBox();
            this.label_razon_social = new System.Windows.Forms.Label();
            this.btn_habilitar = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_comisionar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.razon_social);
            this.groupBox1.Controls.Add(this.label_email);
            this.groupBox1.Controls.Add(this.label_razon_social);
            this.groupBox1.Controls.Add(this.label_cuit);
            this.groupBox1.Controls.Add(this.cuit);
            this.groupBox1.Controls.SetChildIndex(this.cuit, 0);
            this.groupBox1.Controls.SetChildIndex(this.label_cuit, 0);
            this.groupBox1.Controls.SetChildIndex(this.label_razon_social, 0);
            this.groupBox1.Controls.SetChildIndex(this.label_email, 0);
            this.groupBox1.Controls.SetChildIndex(this.razon_social, 0);
            this.groupBox1.Controls.SetChildIndex(this.btn_search, 0);
            this.groupBox1.Controls.SetChildIndex(this.email, 0);
            // 
            // Entidad
            // 
            this.Entidad.Size = new System.Drawing.Size(76, 18);
            this.Entidad.Text = "Empresas";
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.GrayText;
            this.email.Location = new System.Drawing.Point(19, 150);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(145, 24);
            this.email.TabIndex = 79;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(19, 132);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(39, 15);
            this.label_email.TabIndex = 75;
            this.label_email.Text = "Email";
            // 
            // label_cuit
            // 
            this.label_cuit.AutoSize = true;
            this.label_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cuit.Location = new System.Drawing.Point(19, 78);
            this.label_cuit.Name = "label_cuit";
            this.label_cuit.Size = new System.Drawing.Size(34, 15);
            this.label_cuit.TabIndex = 78;
            this.label_cuit.Text = "CUIT";
            // 
            // razon_social
            // 
            this.razon_social.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.razon_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razon_social.ForeColor = System.Drawing.SystemColors.GrayText;
            this.razon_social.Location = new System.Drawing.Point(19, 44);
            this.razon_social.Name = "razon_social";
            this.razon_social.Size = new System.Drawing.Size(145, 24);
            this.razon_social.TabIndex = 73;
            // 
            // cuit
            // 
            this.cuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cuit.Location = new System.Drawing.Point(19, 97);
            this.cuit.Name = "cuit";
            this.cuit.Size = new System.Drawing.Size(145, 24);
            this.cuit.TabIndex = 77;
            // 
            // label_razon_social
            // 
            this.label_razon_social.AutoSize = true;
            this.label_razon_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_razon_social.Location = new System.Drawing.Point(19, 25);
            this.label_razon_social.Name = "label_razon_social";
            this.label_razon_social.Size = new System.Drawing.Size(80, 15);
            this.label_razon_social.TabIndex = 76;
            this.label_razon_social.Text = "Razon Social";
            // 
            // btn_habilitar
            // 
            this.btn_habilitar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_habilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_habilitar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_habilitar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_habilitar.Location = new System.Drawing.Point(632, 83);
            this.btn_habilitar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_habilitar.Name = "btn_habilitar";
            this.btn_habilitar.Size = new System.Drawing.Size(129, 45);
            this.btn_habilitar.TabIndex = 60;
            this.btn_habilitar.Text = "Deshabilitar";
            this.btn_habilitar.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_edit.Location = new System.Drawing.Point(632, 142);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(129, 45);
            this.btn_edit.TabIndex = 61;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_crear
            // 
            this.btn_crear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_crear.Location = new System.Drawing.Point(632, 290);
            this.btn_crear.Margin = new System.Windows.Forms.Padding(0);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(129, 45);
            this.btn_crear.TabIndex = 62;
            this.btn_crear.Text = "Cargar Nuevo";
            this.btn_crear.UseVisualStyleBackColor = false;
            // 
            // btn_comisionar
            // 
            this.btn_comisionar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_comisionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comisionar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comisionar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_comisionar.Location = new System.Drawing.Point(632, 200);
            this.btn_comisionar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_comisionar.Name = "btn_comisionar";
            this.btn_comisionar.Size = new System.Drawing.Size(129, 45);
            this.btn_comisionar.TabIndex = 63;
            this.btn_comisionar.Text = "Rendir comisiones";
            this.btn_comisionar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.btn_comisionar);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_habilitar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.Entidad, 0);
            this.Controls.SetChildIndex(this.btn_habilitar, 0);
            this.Controls.SetChildIndex(this.btn_edit, 0);
            this.Controls.SetChildIndex(this.btn_crear, 0);
            this.Controls.SetChildIndex(this.btn_comisionar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox email;
        public System.Windows.Forms.TextBox razon_social;
        public System.Windows.Forms.Label label_email;
        public System.Windows.Forms.Label label_razon_social;
        public System.Windows.Forms.Label label_cuit;
        public System.Windows.Forms.TextBox cuit;
        public System.Windows.Forms.Button btn_habilitar;
        public System.Windows.Forms.Button btn_edit;
        public System.Windows.Forms.Button btn_crear;
        public System.Windows.Forms.Button btn_comisionar;
    }
}
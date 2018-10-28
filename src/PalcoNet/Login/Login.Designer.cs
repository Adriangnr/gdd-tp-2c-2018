namespace PalcoNet.Login
{
    partial class Login
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
            this.login_btn_entrar = new System.Windows.Forms.Button();
            this.login_btn_salir = new System.Windows.Forms.Button();
            this.login_label_titulo = new System.Windows.Forms.Label();
            this.login_label_usuario = new System.Windows.Forms.Label();
            this.login_label_password = new System.Windows.Forms.Label();
            this.login_btn_registrar = new System.Windows.Forms.Button();
            this.login_tbox_usuario = new System.Windows.Forms.TextBox();
            this.login_tbox_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_btn_entrar
            // 
            this.login_btn_entrar.Location = new System.Drawing.Point(86, 232);
            this.login_btn_entrar.Name = "login_btn_entrar";
            this.login_btn_entrar.Size = new System.Drawing.Size(86, 34);
            this.login_btn_entrar.TabIndex = 0;
            this.login_btn_entrar.Text = "Entrar";
            this.login_btn_entrar.UseVisualStyleBackColor = true;
            this.login_btn_entrar.Click += new System.EventHandler(this.login_btn_entrar_Click);
            // 
            // login_btn_salir
            // 
            this.login_btn_salir.Location = new System.Drawing.Point(191, 232);
            this.login_btn_salir.Name = "login_btn_salir";
            this.login_btn_salir.Size = new System.Drawing.Size(86, 34);
            this.login_btn_salir.TabIndex = 1;
            this.login_btn_salir.Text = "Salir";
            this.login_btn_salir.UseVisualStyleBackColor = true;
            this.login_btn_salir.Click += new System.EventHandler(this.login_btn_salir_Click);
            // 
            // login_label_titulo
            // 
            this.login_label_titulo.AutoSize = true;
            this.login_label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label_titulo.Location = new System.Drawing.Point(82, 33);
            this.login_label_titulo.Name = "login_label_titulo";
            this.login_label_titulo.Size = new System.Drawing.Size(201, 24);
            this.login_label_titulo.TabIndex = 2;
            this.login_label_titulo.Text = "Bienvenido a PalcoNet";
            // 
            // login_label_usuario
            // 
            this.login_label_usuario.AutoSize = true;
            this.login_label_usuario.Location = new System.Drawing.Point(54, 110);
            this.login_label_usuario.Name = "login_label_usuario";
            this.login_label_usuario.Size = new System.Drawing.Size(43, 13);
            this.login_label_usuario.TabIndex = 3;
            this.login_label_usuario.Text = "Usuario";
            // 
            // login_label_password
            // 
            this.login_label_password.AutoSize = true;
            this.login_label_password.Location = new System.Drawing.Point(54, 143);
            this.login_label_password.Name = "login_label_password";
            this.login_label_password.Size = new System.Drawing.Size(61, 13);
            this.login_label_password.TabIndex = 4;
            this.login_label_password.Text = "Contraseña";
            // 
            // login_btn_registrar
            // 
            this.login_btn_registrar.Location = new System.Drawing.Point(223, 180);
            this.login_btn_registrar.Name = "login_btn_registrar";
            this.login_btn_registrar.Size = new System.Drawing.Size(75, 23);
            this.login_btn_registrar.TabIndex = 5;
            this.login_btn_registrar.Text = "Registrarse";
            this.login_btn_registrar.UseVisualStyleBackColor = true;
            // 
            // login_tbox_usuario
            // 
            this.login_tbox_usuario.Location = new System.Drawing.Point(126, 107);
            this.login_tbox_usuario.Name = "login_tbox_usuario";
            this.login_tbox_usuario.Size = new System.Drawing.Size(172, 20);
            this.login_tbox_usuario.TabIndex = 6;
            // 
            // login_tbox_password
            // 
            this.login_tbox_password.Location = new System.Drawing.Point(126, 140);
            this.login_tbox_password.Name = "login_tbox_password";
            this.login_tbox_password.PasswordChar = '*';
            this.login_tbox_password.Size = new System.Drawing.Size(172, 20);
            this.login_tbox_password.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Si no tiene una cuenta";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_tbox_password);
            this.Controls.Add(this.login_tbox_usuario);
            this.Controls.Add(this.login_btn_registrar);
            this.Controls.Add(this.login_label_password);
            this.Controls.Add(this.login_label_usuario);
            this.Controls.Add(this.login_label_titulo);
            this.Controls.Add(this.login_btn_salir);
            this.Controls.Add(this.login_btn_entrar);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn_entrar;
        private System.Windows.Forms.Button login_btn_salir;
        private System.Windows.Forms.Label login_label_titulo;
        private System.Windows.Forms.Label login_label_usuario;
        private System.Windows.Forms.Label login_label_password;
        private System.Windows.Forms.Button login_btn_registrar;
        private System.Windows.Forms.TextBox login_tbox_usuario;
        private System.Windows.Forms.TextBox login_tbox_password;
        private System.Windows.Forms.Label label1;
    }
}
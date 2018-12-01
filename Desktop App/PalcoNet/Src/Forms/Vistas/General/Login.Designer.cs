namespace PalcoNet.Src.Forms.Vistas.General
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
            this.login_tbox_usuario = new System.Windows.Forms.TextBox();
            this.login_tbox_password = new System.Windows.Forms.TextBox();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.login_label = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.TabIndex = 4;
            // 
            // login_btn_entrar
            // 
            this.login_btn_entrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.login_btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn_entrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn_entrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_btn_entrar.Location = new System.Drawing.Point(240, 284);
            this.login_btn_entrar.Name = "login_btn_entrar";
            this.login_btn_entrar.Size = new System.Drawing.Size(129, 45);
            this.login_btn_entrar.TabIndex = 3;
            this.login_btn_entrar.Text = "Entrar";
            this.login_btn_entrar.UseVisualStyleBackColor = false;
            this.login_btn_entrar.Click += new System.EventHandler(this.login_btn_entrar_Click);
            // 
            // login_btn_salir
            // 
            this.login_btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn_salir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn_salir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.login_btn_salir.Location = new System.Drawing.Point(387, 284);
            this.login_btn_salir.Name = "login_btn_salir";
            this.login_btn_salir.Size = new System.Drawing.Size(129, 45);
            this.login_btn_salir.TabIndex = 5;
            this.login_btn_salir.Text = "Salir";
            this.login_btn_salir.UseVisualStyleBackColor = true;
            this.login_btn_salir.Click += new System.EventHandler(this.login_btn_salir_Click);
            // 
            // login_tbox_usuario
            // 
            this.login_tbox_usuario.BackColor = System.Drawing.SystemColors.Menu;
            this.login_tbox_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_tbox_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_tbox_usuario.ForeColor = System.Drawing.Color.DarkGray;
            this.login_tbox_usuario.Location = new System.Drawing.Point(251, 143);
            this.login_tbox_usuario.Name = "login_tbox_usuario";
            this.login_tbox_usuario.Size = new System.Drawing.Size(253, 17);
            this.login_tbox_usuario.TabIndex = 1;
            this.login_tbox_usuario.Text = "Usuario";
            this.login_tbox_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_tbox_usuario.Click += new System.EventHandler(this.login_tbox_usuario_Click);
            // 
            // login_tbox_password
            // 
            this.login_tbox_password.BackColor = System.Drawing.SystemColors.Control;
            this.login_tbox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_tbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_tbox_password.ForeColor = System.Drawing.Color.DarkGray;
            this.login_tbox_password.Location = new System.Drawing.Point(251, 219);
            this.login_tbox_password.Name = "login_tbox_password";
            this.login_tbox_password.PasswordChar = '*';
            this.login_tbox_password.Size = new System.Drawing.Size(253, 17);
            this.login_tbox_password.TabIndex = 2;
            this.login_tbox_password.Text = "password";
            this.login_tbox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_tbox_password.Click += new System.EventHandler(this.login_tbox_password_Click);
            // 
            // registerLink
            // 
            this.registerLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.registerLink.AutoSize = true;
            this.registerLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.registerLink.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerLink.Location = new System.Drawing.Point(397, 344);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(73, 16);
            this.registerLink.TabIndex = 4;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "Registrate!";
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.login_label.Location = new System.Drawing.Point(281, 344);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(119, 16);
            this.login_label.TabIndex = 19;
            this.login_label.Text = "¿No tenes cuenta?";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.titulo.Location = new System.Drawing.Point(299, 69);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(174, 29);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Iniciar Sesión";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.registerLink);
            this.Controls.Add(this.login_tbox_password);
            this.Controls.Add(this.login_tbox_usuario);
            this.Controls.Add(this.login_btn_salir);
            this.Controls.Add(this.login_btn_entrar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Controls.SetChildIndex(this.login_btn_entrar, 0);
            this.Controls.SetChildIndex(this.login_btn_salir, 0);
            this.Controls.SetChildIndex(this.login_tbox_usuario, 0);
            this.Controls.SetChildIndex(this.login_tbox_password, 0);
            this.Controls.SetChildIndex(this.registerLink, 0);
            this.Controls.SetChildIndex(this.login_label, 0);
            this.Controls.SetChildIndex(this.titulo, 0);
            this.Controls.SetChildIndex(this.footer, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn_entrar;
        private System.Windows.Forms.Button login_btn_salir;
        private System.Windows.Forms.TextBox login_tbox_usuario;
        private System.Windows.Forms.TextBox login_tbox_password;
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label titulo;
    }
}
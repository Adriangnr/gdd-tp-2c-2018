namespace PalcoNet.Src.Forms.Vistas.General
{
    partial class Cambio_Password
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
            this.textBox_contrasena = new System.Windows.Forms.TextBox();
            this.repeticionPassword = new System.Windows.Forms.TextBox();
            this.btn_cambiarPass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.login_btn_salir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(250, 337);
            // 
            // textBox_contrasena
            // 
            this.textBox_contrasena.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_contrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_contrasena.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox_contrasena.Location = new System.Drawing.Point(202, 143);
            this.textBox_contrasena.MaxLength = 15;
            this.textBox_contrasena.Name = "textBox_contrasena";
            this.textBox_contrasena.PasswordChar = '*';
            this.textBox_contrasena.Size = new System.Drawing.Size(250, 15);
            this.textBox_contrasena.TabIndex = 2;
            // 
            // repeticionPassword
            // 
            this.repeticionPassword.BackColor = System.Drawing.SystemColors.Control;
            this.repeticionPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repeticionPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeticionPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.repeticionPassword.Location = new System.Drawing.Point(201, 196);
            this.repeticionPassword.MaxLength = 15;
            this.repeticionPassword.Name = "repeticionPassword";
            this.repeticionPassword.PasswordChar = '*';
            this.repeticionPassword.Size = new System.Drawing.Size(250, 15);
            this.repeticionPassword.TabIndex = 3;
            // 
            // btn_cambiarPass
            // 
            this.btn_cambiarPass.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cambiarPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cambiarPass.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cambiarPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cambiarPass.Location = new System.Drawing.Point(332, 254);
            this.btn_cambiarPass.Name = "btn_cambiarPass";
            this.btn_cambiarPass.Size = new System.Drawing.Size(129, 45);
            this.btn_cambiarPass.TabIndex = 6;
            this.btn_cambiarPass.Text = "Confirmar";
            this.btn_cambiarPass.UseVisualStyleBackColor = false;
            this.btn_cambiarPass.Click += new System.EventHandler(this.btn_cambiarPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(35, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese su nueva contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(35, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Repita la nueva contraseña:";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.titulo.Location = new System.Drawing.Point(186, 81);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(284, 29);
            this.titulo.TabIndex = 10;
            this.titulo.Text = "Cambio de Contraseña";
            this.titulo.Click += new System.EventHandler(this.titulo_Click);
            // 
            // login_btn_salir
            // 
            this.login_btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn_salir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn_salir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.login_btn_salir.Location = new System.Drawing.Point(182, 254);
            this.login_btn_salir.Name = "login_btn_salir";
            this.login_btn_salir.Size = new System.Drawing.Size(129, 45);
            this.login_btn_salir.TabIndex = 11;
            this.login_btn_salir.Text = "Cancelar";
            this.login_btn_salir.UseVisualStyleBackColor = true;
            this.login_btn_salir.Click += new System.EventHandler(this.login_btn_salir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(194, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(194, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 39);
            this.button2.TabIndex = 22;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Cambio_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 379);
            this.Controls.Add(this.login_btn_salir);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cambiarPass);
            this.Controls.Add(this.repeticionPassword);
            this.Controls.Add(this.textBox_contrasena);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "Cambio_Password";
            this.Text = "PalcoNet - Cambio de password";
            this.Load += new System.EventHandler(this.Cambio_Password_Load);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.textBox_contrasena, 0);
            this.Controls.SetChildIndex(this.repeticionPassword, 0);
            this.Controls.SetChildIndex(this.btn_cambiarPass, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.titulo, 0);
            this.Controls.SetChildIndex(this.login_btn_salir, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_contrasena;
        private System.Windows.Forms.TextBox repeticionPassword;
        private System.Windows.Forms.Button btn_cambiarPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button login_btn_salir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
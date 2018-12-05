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
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(334, 330);
            // 
            // textBox_contrasena
            // 
            this.textBox_contrasena.Location = new System.Drawing.Point(197, 145);
            this.textBox_contrasena.MaxLength = 15;
            this.textBox_contrasena.Name = "textBox_contrasena";
            this.textBox_contrasena.PasswordChar = '*';
            this.textBox_contrasena.Size = new System.Drawing.Size(250, 20);
            this.textBox_contrasena.TabIndex = 2;
            // 
            // repeticionPassword
            // 
            this.repeticionPassword.Location = new System.Drawing.Point(197, 186);
            this.repeticionPassword.MaxLength = 15;
            this.repeticionPassword.Name = "repeticionPassword";
            this.repeticionPassword.PasswordChar = '*';
            this.repeticionPassword.Size = new System.Drawing.Size(250, 20);
            this.repeticionPassword.TabIndex = 3;
            // 
            // btn_cambiarPass
            // 
            this.btn_cambiarPass.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cambiarPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cambiarPass.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cambiarPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cambiarPass.Location = new System.Drawing.Point(257, 225);
            this.btn_cambiarPass.Name = "btn_cambiarPass";
            this.btn_cambiarPass.Size = new System.Drawing.Size(104, 45);
            this.btn_cambiarPass.TabIndex = 6;
            this.btn_cambiarPass.Text = "Confirmar";
            this.btn_cambiarPass.UseVisualStyleBackColor = false;
            this.btn_cambiarPass.Click += new System.EventHandler(this.btn_cambiarPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese su nueva contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Repita la nueva contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(229, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cambio de contraseña";
            // 
            // Cambio_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cambiarPass);
            this.Controls.Add(this.repeticionPassword);
            this.Controls.Add(this.textBox_contrasena);
            this.Name = "Cambio_Password";
            this.Text = "PalcoNet - Cambio de password";
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.textBox_contrasena, 0);
            this.Controls.SetChildIndex(this.repeticionPassword, 0);
            this.Controls.SetChildIndex(this.btn_cambiarPass, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_contrasena;
        private System.Windows.Forms.TextBox repeticionPassword;
        private System.Windows.Forms.Button btn_cambiarPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
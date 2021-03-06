﻿namespace PalcoNet.Src.Forms.Vistas.General
{
    partial class Registro
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
            System.Windows.Forms.GroupBox groupBoxDireccion;
            this.textBox_cp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_depto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_piso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_localidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_calle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_roldata = new System.Windows.Forms.Panel();
            this.link_limpiar = new System.Windows.Forms.LinkLabel();
            this.register_btn_cancel = new System.Windows.Forms.Button();
            this.register_btn_registrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_contrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.groupBoxTipoUsuario = new System.Windows.Forms.GroupBox();
            this.rolSelector = new System.Windows.Forms.ComboBox();
            groupBoxDireccion = new System.Windows.Forms.GroupBox();
            groupBoxDireccion.SuspendLayout();
            this.groupBoxTipoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDireccion
            // 
            groupBoxDireccion.Controls.Add(this.textBox_cp);
            groupBoxDireccion.Controls.Add(this.label10);
            groupBoxDireccion.Controls.Add(this.textBox_depto);
            groupBoxDireccion.Controls.Add(this.label9);
            groupBoxDireccion.Controls.Add(this.textBox_piso);
            groupBoxDireccion.Controls.Add(this.label8);
            groupBoxDireccion.Controls.Add(this.textBox_localidad);
            groupBoxDireccion.Controls.Add(this.label7);
            groupBoxDireccion.Controls.Add(this.textBox_calle);
            groupBoxDireccion.Controls.Add(this.label6);
            groupBoxDireccion.Location = new System.Drawing.Point(37, 253);
            groupBoxDireccion.Name = "groupBoxDireccion";
            groupBoxDireccion.Size = new System.Drawing.Size(396, 93);
            groupBoxDireccion.TabIndex = 4;
            groupBoxDireccion.TabStop = false;
            groupBoxDireccion.Text = "Dirección";
            groupBoxDireccion.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_cp
            // 
            this.textBox_cp.Location = new System.Drawing.Point(327, 53);
            this.textBox_cp.Name = "textBox_cp";
            this.textBox_cp.Size = new System.Drawing.Size(53, 20);
            this.textBox_cp.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(282, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "CP:";
            // 
            // textBox_depto
            // 
            this.textBox_depto.Location = new System.Drawing.Point(327, 19);
            this.textBox_depto.Name = "textBox_depto";
            this.textBox_depto.Size = new System.Drawing.Size(53, 20);
            this.textBox_depto.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(282, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Depto:";
            // 
            // textBox_piso
            // 
            this.textBox_piso.Location = new System.Drawing.Point(218, 19);
            this.textBox_piso.Name = "textBox_piso";
            this.textBox_piso.Size = new System.Drawing.Size(53, 20);
            this.textBox_piso.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(182, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Piso:";
            // 
            // textBox_localidad
            // 
            this.textBox_localidad.Location = new System.Drawing.Point(85, 53);
            this.textBox_localidad.Name = "textBox_localidad";
            this.textBox_localidad.Size = new System.Drawing.Size(186, 20);
            this.textBox_localidad.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(8, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Localidad:";
            // 
            // textBox_calle
            // 
            this.textBox_calle.Location = new System.Drawing.Point(85, 19);
            this.textBox_calle.Name = "textBox_calle";
            this.textBox_calle.Size = new System.Drawing.Size(91, 20);
            this.textBox_calle.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Calle:";
            // 
            // panel_roldata
            // 
            this.panel_roldata.Location = new System.Drawing.Point(441, 65);
            this.panel_roldata.Name = "panel_roldata";
            this.panel_roldata.Size = new System.Drawing.Size(289, 281);
            this.panel_roldata.TabIndex = 11;
            // 
            // link_limpiar
            // 
            this.link_limpiar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.link_limpiar.AutoSize = true;
            this.link_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_limpiar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_limpiar.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.link_limpiar.Location = new System.Drawing.Point(34, 369);
            this.link_limpiar.Name = "link_limpiar";
            this.link_limpiar.Size = new System.Drawing.Size(119, 16);
            this.link_limpiar.TabIndex = 22;
            this.link_limpiar.TabStop = true;
            this.link_limpiar.Text = "Limpiar Formulario";
            this.link_limpiar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_limpiar_LinkClicked);
            // 
            // register_btn_cancel
            // 
            this.register_btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.register_btn_cancel.Location = new System.Drawing.Point(467, 355);
            this.register_btn_cancel.Name = "register_btn_cancel";
            this.register_btn_cancel.Size = new System.Drawing.Size(129, 45);
            this.register_btn_cancel.TabIndex = 21;
            this.register_btn_cancel.Text = "Cancelar";
            this.register_btn_cancel.UseVisualStyleBackColor = true;
            this.register_btn_cancel.Click += new System.EventHandler(this.register_btn_cancel_Click);
            // 
            // register_btn_registrar
            // 
            this.register_btn_registrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.register_btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn_registrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn_registrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.register_btn_registrar.Location = new System.Drawing.Point(602, 355);
            this.register_btn_registrar.Name = "register_btn_registrar";
            this.register_btn_registrar.Size = new System.Drawing.Size(129, 45);
            this.register_btn_registrar.TabIndex = 20;
            this.register_btn_registrar.Text = "Registrar";
            this.register_btn_registrar.UseVisualStyleBackColor = false;
            this.register_btn_registrar.Click += new System.EventHandler(this.register_btn_registrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(45, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Contraseña:";
            // 
            // textBox_contrasena
            // 
            this.textBox_contrasena.Location = new System.Drawing.Point(122, 143);
            this.textBox_contrasena.Name = "textBox_contrasena";
            this.textBox_contrasena.Size = new System.Drawing.Size(137, 20);
            this.textBox_contrasena.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(45, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Usuario:";
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Location = new System.Drawing.Point(122, 108);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(137, 20);
            this.textBox_usuario.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(45, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mail:";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(122, 183);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(137, 20);
            this.textBox_mail.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(45, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Teléfono:";
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Location = new System.Drawing.Point(122, 218);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(137, 20);
            this.textBox_telefono.TabIndex = 3;
            // 
            // groupBoxTipoUsuario
            // 
            this.groupBoxTipoUsuario.Controls.Add(this.rolSelector);
            this.groupBoxTipoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxTipoUsuario.Location = new System.Drawing.Point(274, 108);
            this.groupBoxTipoUsuario.Name = "groupBoxTipoUsuario";
            this.groupBoxTipoUsuario.Size = new System.Drawing.Size(159, 130);
            this.groupBoxTipoUsuario.TabIndex = 35;
            this.groupBoxTipoUsuario.TabStop = false;
            this.groupBoxTipoUsuario.Text = "Tipo de Usuario";
            // 
            // rolSelector
            // 
            this.rolSelector.FormattingEnabled = true;
            this.rolSelector.Location = new System.Drawing.Point(22, 34);
            this.rolSelector.Name = "rolSelector";
            this.rolSelector.Size = new System.Drawing.Size(121, 21);
            this.rolSelector.TabIndex = 10;
            this.rolSelector.SelectedIndexChanged += new System.EventHandler(this.rolSelector_SelectedIndexChanged);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.groupBoxTipoUsuario);
            this.Controls.Add(groupBoxDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_contrasena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.link_limpiar);
            this.Controls.Add(this.register_btn_cancel);
            this.Controls.Add(this.register_btn_registrar);
            this.Controls.Add(this.panel_roldata);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.panel_roldata, 0);
            this.Controls.SetChildIndex(this.register_btn_registrar, 0);
            this.Controls.SetChildIndex(this.register_btn_cancel, 0);
            this.Controls.SetChildIndex(this.link_limpiar, 0);
            this.Controls.SetChildIndex(this.textBox_usuario, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBox_contrasena, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBox_mail, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBox_telefono, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(groupBoxDireccion, 0);
            this.Controls.SetChildIndex(this.groupBoxTipoUsuario, 0);
            groupBoxDireccion.ResumeLayout(false);
            groupBoxDireccion.PerformLayout();
            this.groupBoxTipoUsuario.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_roldata;
        private System.Windows.Forms.LinkLabel link_limpiar;
        private System.Windows.Forms.Button register_btn_cancel;
        private System.Windows.Forms.Button register_btn_registrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_contrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_calle;
        private System.Windows.Forms.TextBox textBox_cp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_depto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_piso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_localidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxTipoUsuario;
        private System.Windows.Forms.ComboBox rolSelector;
    }
}
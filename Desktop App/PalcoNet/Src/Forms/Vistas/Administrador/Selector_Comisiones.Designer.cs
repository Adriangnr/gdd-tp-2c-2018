﻿namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    partial class Selector_Comisiones
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelCanCompras = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNombreEmpresa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantComisiones = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnComisiones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(136, 378);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Se realizaron";
            // 
            // labelCanCompras
            // 
            this.labelCanCompras.AutoSize = true;
            this.labelCanCompras.Location = new System.Drawing.Point(152, 137);
            this.labelCanCompras.Name = "labelCanCompras";
            this.labelCanCompras.Size = new System.Drawing.Size(122, 20);
            this.labelCanCompras.TabIndex = 3;
            this.labelCanCompras.Text = "<cantCompras>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "compras para la empresa ";
            // 
            // labelNombreEmpresa
            // 
            this.labelNombreEmpresa.AutoSize = true;
            this.labelNombreEmpresa.Location = new System.Drawing.Point(44, 172);
            this.labelNombreEmpresa.Name = "labelNombreEmpresa";
            this.labelNombreEmpresa.Size = new System.Drawing.Size(145, 20);
            this.labelNombreEmpresa.TabIndex = 5;
            this.labelNombreEmpresa.Text = "<nombreEmpresa>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(352, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Para cuantas compras desea rendir comisiones?";
            // 
            // txtCantComisiones
            // 
            this.txtCantComisiones.Location = new System.Drawing.Point(423, 213);
            this.txtCantComisiones.Name = "txtCantComisiones";
            this.txtCantComisiones.Size = new System.Drawing.Size(61, 26);
            this.txtCantComisiones.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancel.Location = new System.Drawing.Point(13, 301);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 58);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnComisiones
            // 
            this.btnComisiones.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnComisiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComisiones.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComisiones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComisiones.Location = new System.Drawing.Point(340, 301);
            this.btnComisiones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnComisiones.Name = "btnComisiones";
            this.btnComisiones.Size = new System.Drawing.Size(149, 58);
            this.btnComisiones.TabIndex = 24;
            this.btnComisiones.Text = "Rendir Comisiones";
            this.btnComisiones.UseVisualStyleBackColor = false;
            // 
            // Selector_Comisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 407);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnComisiones);
            this.Controls.Add(this.txtCantComisiones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelNombreEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCanCompras);
            this.Controls.Add(this.label1);
            this.Name = "Selector_Comisiones";
            this.Text = "Rendir Comisiones";
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.labelCanCompras, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.labelNombreEmpresa, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtCantComisiones, 0);
            this.Controls.SetChildIndex(this.btnComisiones, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCanCompras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNombreEmpresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantComisiones;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnComisiones;
    }
}
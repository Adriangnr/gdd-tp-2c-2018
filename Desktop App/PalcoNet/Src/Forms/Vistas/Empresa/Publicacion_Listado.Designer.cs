﻿namespace PalcoNet.Editar_Publicacion
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Visible = false;
            // 
            // button1
            // 
            this.btn_habilitar.Text = "Editar";
            // 
            // button3
            // 
            this.btn_edit.Location = new System.Drawing.Point(632, 290);
            this.btn_edit.Text = "Crear Nueva";
            // 
            // Entidad
            // 
            this.Entidad.Size = new System.Drawing.Size(100, 18);
            this.Entidad.Text = "Publicaciones";
            this.Entidad.Click += new System.EventHandler(this.Entidad_Click);
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(32, 83);
            this.listBox1.Size = new System.Drawing.Size(579, 316);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
﻿namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    partial class Compra_Ubicacion
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
            this.dataGridUbicaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUbicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.footer.Location = new System.Drawing.Point(855, 424);
            // 
            // dataGridUbicaciones
            // 
            this.dataGridUbicaciones.AllowUserToAddRows = false;
            this.dataGridUbicaciones.AllowUserToDeleteRows = false;
            this.dataGridUbicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridUbicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridUbicaciones.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridUbicaciones.Location = new System.Drawing.Point(51, 78);
            this.dataGridUbicaciones.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridUbicaciones.MultiSelect = false;
            this.dataGridUbicaciones.Name = "dataGridUbicaciones";
            this.dataGridUbicaciones.ReadOnly = true;
            this.dataGridUbicaciones.RowHeadersVisible = false;
            this.dataGridUbicaciones.RowTemplate.Height = 28;
            this.dataGridUbicaciones.RowTemplate.ReadOnly = true;
            this.dataGridUbicaciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUbicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUbicaciones.Size = new System.Drawing.Size(863, 307);
            this.dataGridUbicaciones.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Comprar ubicacion";
            // 
            // btn_comprar
            // 
            this.btn_comprar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_comprar.Location = new System.Drawing.Point(949, 78);
            this.btn_comprar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(129, 45);
            this.btn_comprar.TabIndex = 65;
            this.btn_comprar.Text = "Seleccionar";
            this.btn_comprar.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(949, 340);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(129, 45);
            this.btn_cancel.TabIndex = 66;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Compra_Ubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 462);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridUbicaciones);
            this.Name = "Compra_Ubicacion";
            this.Text = "Compra Ubicacion";
            this.Controls.SetChildIndex(this.dataGridUbicaciones, 0);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn_comprar, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUbicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUbicaciones;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_comprar;
        protected System.Windows.Forms.Button btn_cancel;
    }
}
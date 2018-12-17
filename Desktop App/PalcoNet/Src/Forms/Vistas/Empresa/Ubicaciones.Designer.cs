namespace PalcoNet.Src.Forms.Vistas.Empresa
{
    partial class Ubicaciones
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
            this.txt_filas = new System.Windows.Forms.TextBox();
            this.txt_asientos = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.comboBoxTipos = new System.Windows.Forms.ComboBox();
            this.chkSinNumerar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_filas
            // 
            this.txt_filas.Location = new System.Drawing.Point(52, 58);
            this.txt_filas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_filas.Name = "txt_filas";
            this.txt_filas.Size = new System.Drawing.Size(37, 20);
            this.txt_filas.TabIndex = 1;
            // 
            // txt_asientos
            // 
            this.txt_asientos.Location = new System.Drawing.Point(207, 58);
            this.txt_asientos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_asientos.Name = "txt_asientos";
            this.txt_asientos.Size = new System.Drawing.Size(37, 20);
            this.txt_asientos.TabIndex = 2;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(53, 87);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(59, 20);
            this.txt_precio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo de Ubicación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Asientos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_cargar
            // 
            this.btn_cargar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cargar.Location = new System.Drawing.Point(161, 154);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(82, 35);
            this.btn_cargar.TabIndex = 6;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.UseVisualStyleBackColor = false;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(6, 154);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(82, 35);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Cantidad";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(207, 91);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(37, 20);
            this.txt_cantidad.TabIndex = 4;
            // 
            // comboBoxTipos
            // 
            this.comboBoxTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipos.FormattingEnabled = true;
            this.comboBoxTipos.Location = new System.Drawing.Point(108, 19);
            this.comboBoxTipos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTipos.Name = "comboBoxTipos";
            this.comboBoxTipos.Size = new System.Drawing.Size(136, 21);
            this.comboBoxTipos.TabIndex = 0;
            this.comboBoxTipos.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipos_SelectedIndexChanged);
            // 
            // chkSinNumerar
            // 
            this.chkSinNumerar.AutoSize = true;
            this.chkSinNumerar.Location = new System.Drawing.Point(161, 123);
            this.chkSinNumerar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSinNumerar.Name = "chkSinNumerar";
            this.chkSinNumerar.Size = new System.Drawing.Size(84, 17);
            this.chkSinNumerar.TabIndex = 5;
            this.chkSinNumerar.Text = "Sin Numerar";
            this.chkSinNumerar.UseVisualStyleBackColor = true;
            this.chkSinNumerar.CheckedChanged += new System.EventHandler(this.chkSinNumerar_CheckedChanged);
            // 
            // Ubicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(251, 203);
            this.Controls.Add(this.chkSinNumerar);
            this.Controls.Add(this.comboBoxTipos);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_asientos);
            this.Controls.Add(this.txt_filas);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Ubicaciones";
            this.Text = "Entradas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_filas;
        private System.Windows.Forms.TextBox txt_asientos;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.ComboBox comboBoxTipos;
        private System.Windows.Forms.CheckBox chkSinNumerar;
    }
}
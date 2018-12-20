namespace PalcoNet.Src.Forms.Vistas.Empresa
{
    partial class Fecha_Hora
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
            this.pub_fecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_pubFecha = new System.Windows.Forms.DateTimePicker();
            this.text_inicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pub_fecha
            // 
            this.pub_fecha.AutoSize = true;
            this.pub_fecha.Location = new System.Drawing.Point(45, 50);
            this.pub_fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pub_fecha.Name = "pub_fecha";
            this.pub_fecha.Size = new System.Drawing.Size(37, 13);
            this.pub_fecha.TabIndex = 0;
            this.pub_fecha.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horario de inicio (hh:mm)";
            // 
            // dateTimePicker_pubFecha
            // 
            this.dateTimePicker_pubFecha.Location = new System.Drawing.Point(85, 46);
            this.dateTimePicker_pubFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker_pubFecha.Name = "dateTimePicker_pubFecha";
            this.dateTimePicker_pubFecha.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker_pubFecha.TabIndex = 3;
            this.dateTimePicker_pubFecha.ValueChanged += new System.EventHandler(this.dateTimePicker_pubFecha_ValueChanged);
            // 
            // text_inicio
            // 
            this.text_inicio.Location = new System.Drawing.Point(212, 75);
            this.text_inicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_inicio.Name = "text_inicio";
            this.text_inicio.Size = new System.Drawing.Size(68, 20);
            this.text_inicio.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cargar Funciones";
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(47, 148);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(82, 35);
            this.btn_cancel.TabIndex = 56;
            this.btn_cancel.Text = "Cerrar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_cargar
            // 
            this.btn_cargar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cargar.Location = new System.Drawing.Point(197, 148);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(82, 35);
            this.btn_cargar.TabIndex = 57;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.UseVisualStyleBackColor = false;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click_1);
            // 
            // Fecha_Hora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(326, 219);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_inicio);
            this.Controls.Add(this.dateTimePicker_pubFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pub_fecha);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Fecha_Hora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fecha y horario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pub_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_pubFecha;
        private System.Windows.Forms.TextBox text_inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_cargar;
    }
}
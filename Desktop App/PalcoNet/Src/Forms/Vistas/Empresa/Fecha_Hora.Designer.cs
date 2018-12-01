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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pub_fecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_pubFecha = new System.Windows.Forms.DateTimePicker();
            this.text_inicio = new System.Windows.Forms.TextBox();
            this.text_fin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.dataGridView_fechaHora = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fechaHora)).BeginInit();
            this.SuspendLayout();
            // 
            // pub_fecha
            // 
            this.pub_fecha.AutoSize = true;
            this.pub_fecha.Location = new System.Drawing.Point(67, 77);
            this.pub_fecha.Name = "pub_fecha";
            this.pub_fecha.Size = new System.Drawing.Size(54, 20);
            this.pub_fecha.TabIndex = 0;
            this.pub_fecha.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horario de inicio (hh:mm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora de fin (hh:mm)";
            // 
            // dateTimePicker_pubFecha
            // 
            this.dateTimePicker_pubFecha.Location = new System.Drawing.Point(127, 71);
            this.dateTimePicker_pubFecha.Name = "dateTimePicker_pubFecha";
            this.dateTimePicker_pubFecha.Size = new System.Drawing.Size(291, 26);
            this.dateTimePicker_pubFecha.TabIndex = 3;
            // 
            // text_inicio
            // 
            this.text_inicio.Location = new System.Drawing.Point(318, 116);
            this.text_inicio.Name = "text_inicio";
            this.text_inicio.Size = new System.Drawing.Size(100, 26);
            this.text_inicio.TabIndex = 4;
            // 
            // text_fin
            // 
            this.text_fin.Location = new System.Drawing.Point(318, 169);
            this.text_fin.Name = "text_fin";
            this.text_fin.Size = new System.Drawing.Size(100, 26);
            this.text_fin.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cargar Funciones";
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(710, 269);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(123, 54);
            this.btn_cancel.TabIndex = 56;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_guardar.Location = new System.Drawing.Point(841, 269);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(123, 54);
            this.btn_guardar.TabIndex = 55;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // btn_cargar
            // 
            this.btn_cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cargar.Location = new System.Drawing.Point(318, 216);
            this.btn_cargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(100, 50);
            this.btn_cargar.TabIndex = 57;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // dataGridView_fechaHora
            // 
            this.dataGridView_fechaHora.AllowUserToAddRows = false;
            this.dataGridView_fechaHora.AllowUserToResizeColumns = false;
            this.dataGridView_fechaHora.AllowUserToResizeRows = false;
            this.dataGridView_fechaHora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_fechaHora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_fechaHora.ColumnHeadersVisible = false;
            this.dataGridView_fechaHora.Cursor = System.Windows.Forms.Cursors.No;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_fechaHora.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_fechaHora.EnableHeadersVisualStyles = false;
            this.dataGridView_fechaHora.Location = new System.Drawing.Point(450, 71);
            this.dataGridView_fechaHora.MultiSelect = false;
            this.dataGridView_fechaHora.Name = "dataGridView_fechaHora";
            this.dataGridView_fechaHora.ReadOnly = true;
            this.dataGridView_fechaHora.RowHeadersVisible = false;
            this.dataGridView_fechaHora.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_fechaHora.RowTemplate.Height = 28;
            this.dataGridView_fechaHora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_fechaHora.Size = new System.Drawing.Size(515, 150);
            this.dataGridView_fechaHora.TabIndex = 58;
            this.dataGridView_fechaHora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_fechaHora_CellContentClick);
            // 
            // Fecha_Hora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 337);
            this.Controls.Add(this.dataGridView_fechaHora);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_fin);
            this.Controls.Add(this.text_inicio);
            this.Controls.Add(this.dateTimePicker_pubFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pub_fecha);
            this.Name = "Fecha_Hora";
            this.Text = "Fecha_Hora";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fechaHora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pub_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_pubFecha;
        private System.Windows.Forms.TextBox text_inicio;
        private System.Windows.Forms.TextBox text_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.DataGridView dataGridView_fechaHora;
    }
}
namespace PalcoNet.Vistas.Cliente
{
    partial class Compra
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
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Controls.Add(this.dateFrom);
            this.groupBox1.Controls.SetChildIndex(this.btn_search, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox3, 0);
            this.groupBox1.Controls.SetChildIndex(this.label3, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox4, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.Controls.SetChildIndex(this.dateFrom, 0);
            this.groupBox1.Controls.SetChildIndex(this.dateTo, 0);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.Text = "Categorías";
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.Text = "Fecha Desde:";
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.Text = "Fecha Hasta:";
            // 
            // button1
            // 
            this.btn_habilitar.Text = "Comprar";
            // 
            // button3
            // 
            this.btn_edit.Enabled = false;
            this.btn_edit.Text = "---";
            this.btn_edit.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Visible = false;
            // 
            // Entidad
            // 
            this.Entidad.Size = new System.Drawing.Size(67, 18);
            this.Entidad.Text = "Comprar";
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(19, 151);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(145, 22);
            this.dateFrom.TabIndex = 15;
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(19, 205);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(145, 22);
            this.dateTo.TabIndex = 16;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Name = "Compra";
            this.Text = "Comprar";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
    }
}
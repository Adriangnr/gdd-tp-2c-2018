namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    partial class Historial
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
            this.dataGridHistorial = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_detalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(675, 409);
            // 
            // dataGridHistorial
            // 
            this.dataGridHistorial.AllowUserToAddRows = false;
            this.dataGridHistorial.AllowUserToDeleteRows = false;
            this.dataGridHistorial.AllowUserToResizeRows = false;
            this.dataGridHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorial.Location = new System.Drawing.Point(32, 89);
            this.dataGridHistorial.MultiSelect = false;
            this.dataGridHistorial.Name = "dataGridHistorial";
            this.dataGridHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridHistorial.Size = new System.Drawing.Size(717, 291);
            this.dataGridHistorial.TabIndex = 2;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(784, 335);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(129, 45);
            this.btn_cancel.TabIndex = 21;
            this.btn_cancel.Text = "Volver";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_detalles
            // 
            this.btn_detalles.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_detalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detalles.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detalles.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_detalles.Location = new System.Drawing.Point(784, 89);
            this.btn_detalles.Margin = new System.Windows.Forms.Padding(0);
            this.btn_detalles.Name = "btn_detalles";
            this.btn_detalles.Size = new System.Drawing.Size(129, 45);
            this.btn_detalles.TabIndex = 66;
            this.btn_detalles.Text = "Ver detalles";
            this.btn_detalles.UseVisualStyleBackColor = false;
            this.btn_detalles.Click += new System.EventHandler(this.btn_detalles_Click);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 441);
            this.Controls.Add(this.btn_detalles);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.dataGridHistorial);
            this.Name = "Historial";
            this.Text = "Palco.NET - Historial de cliente";
            this.Load += new System.EventHandler(this.Historial_Load);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.dataGridHistorial, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.btn_detalles, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHistorial;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_detalles;
    }
}
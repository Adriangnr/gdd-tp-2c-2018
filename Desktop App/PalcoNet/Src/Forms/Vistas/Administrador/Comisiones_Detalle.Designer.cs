namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    partial class Comisiones_Detalle
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
            this.btn_comisionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dataGridViewEmpresas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_comisionar
            // 
            this.btn_comisionar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_comisionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comisionar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comisionar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_comisionar.Location = new System.Drawing.Point(933, 166);
            this.btn_comisionar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_comisionar.Name = "btn_comisionar";
            this.btn_comisionar.Size = new System.Drawing.Size(194, 69);
            this.btn_comisionar.TabIndex = 5;
            this.btn_comisionar.Text = "Comisionar";
            this.btn_comisionar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(42, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Comisionar Ventas";
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(933, 542);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(194, 69);
            this.btn_cancel.TabIndex = 57;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dataGridViewEmpresas
            // 
            this.dataGridViewEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpresas.Location = new System.Drawing.Point(47, 166);
            this.dataGridViewEmpresas.Name = "dataGridViewEmpresas";
            this.dataGridViewEmpresas.RowTemplate.Height = 28;
            this.dataGridViewEmpresas.Size = new System.Drawing.Size(836, 445);
            this.dataGridViewEmpresas.TabIndex = 58;
            // 
            // Comisiones_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1176, 678);
            this.Controls.Add(this.dataGridViewEmpresas);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_comisionar);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Comisiones_Detalle";
            this.Text = "Comisiones_Detalle";
            this.Load += new System.EventHandler(this.Comisiones_Detalle_Load);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.btn_comisionar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.dataGridViewEmpresas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btn_comisionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView dataGridViewEmpresas;
    }
}
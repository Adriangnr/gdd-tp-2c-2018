namespace PalcoNet.Src.Forms.Vistas.Cliente
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
            this.dataGridEntradas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.footer.Location = new System.Drawing.Point(356, 424);
            // 
            // dataGridEntradas
            // 
            this.dataGridEntradas.AllowUserToAddRows = false;
            this.dataGridEntradas.AllowUserToDeleteRows = false;
            this.dataGridEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridEntradas.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridEntradas.Location = new System.Drawing.Point(51, 78);
            this.dataGridEntradas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridEntradas.MultiSelect = false;
            this.dataGridEntradas.Name = "dataGridEntradas";
            this.dataGridEntradas.ReadOnly = true;
            this.dataGridEntradas.RowHeadersVisible = false;
            this.dataGridEntradas.RowTemplate.Height = 28;
            this.dataGridEntradas.RowTemplate.ReadOnly = true;
            this.dataGridEntradas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEntradas.Size = new System.Drawing.Size(401, 307);
            this.dataGridEntradas.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(220, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Comprar entrada";
            // 
            // btn_comprar
            // 
            this.btn_comprar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_comprar.Location = new System.Drawing.Point(470, 78);
            this.btn_comprar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(129, 45);
            this.btn_comprar.TabIndex = 65;
            this.btn_comprar.Text = "Seleccionar";
            this.btn_comprar.UseVisualStyleBackColor = false;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(470, 340);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(129, 45);
            this.btn_cancel.TabIndex = 66;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Compra_Ubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 462);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridEntradas);
            this.Name = "Compra_Ubicacion";
            this.Text = "Compra_Ubicacion";
            this.Controls.SetChildIndex(this.dataGridEntradas, 0);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn_comprar, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEntradas;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_comprar;
        protected System.Windows.Forms.Button btn_cancel;
    }
}
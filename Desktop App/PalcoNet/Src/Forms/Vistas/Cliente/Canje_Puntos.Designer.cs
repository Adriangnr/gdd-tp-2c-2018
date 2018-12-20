namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    partial class Canje_Puntos
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_canjear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.points = new System.Windows.Forms.Label();
            this.dataGridPremios = new System.Windows.Forms.DataGridView();
            this.Premios = new System.Windows.Forms.Label();
            this.btn_historial = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPremios)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(948, 545);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(194, 69);
            this.btn_cancel.TabIndex = 60;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_canjear
            // 
            this.btn_canjear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_canjear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_canjear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_canjear.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_canjear.Location = new System.Drawing.Point(948, 128);
            this.btn_canjear.Margin = new System.Windows.Forms.Padding(0);
            this.btn_canjear.Name = "btn_canjear";
            this.btn_canjear.Size = new System.Drawing.Size(194, 69);
            this.btn_canjear.TabIndex = 57;
            this.btn_canjear.Text = "Canjear";
            this.btn_canjear.UseVisualStyleBackColor = false;
            this.btn_canjear.Click += new System.EventHandler(this.btn_canjear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.points);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(48, 123);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(282, 154);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tus Puntos";
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.points.Location = new System.Drawing.Point(50, 52);
            this.points.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(201, 61);
            this.points.TabIndex = 0;
            this.points.Text = "999999";
            // 
            // dataGridPremios
            // 
            this.dataGridPremios.AllowUserToAddRows = false;
            this.dataGridPremios.AllowUserToDeleteRows = false;
            this.dataGridPremios.AllowUserToResizeRows = false;
            this.dataGridPremios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPremios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPremios.Location = new System.Drawing.Point(369, 123);
            this.dataGridPremios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridPremios.MultiSelect = false;
            this.dataGridPremios.Name = "dataGridPremios";
            this.dataGridPremios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPremios.Size = new System.Drawing.Size(546, 491);
            this.dataGridPremios.TabIndex = 62;
            // 
            // Premios
            // 
            this.Premios.AutoSize = true;
            this.Premios.Location = new System.Drawing.Point(369, 75);
            this.Premios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Premios.Name = "Premios";
            this.Premios.Size = new System.Drawing.Size(66, 20);
            this.Premios.TabIndex = 63;
            this.Premios.Text = "Premios";
            // 
            // btn_historial
            // 
            this.btn_historial.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_historial.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_historial.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_historial.Location = new System.Drawing.Point(948, 225);
            this.btn_historial.Margin = new System.Windows.Forms.Padding(0);
            this.btn_historial.Name = "btn_historial";
            this.btn_historial.Size = new System.Drawing.Size(194, 69);
            this.btn_historial.TabIndex = 64;
            this.btn_historial.Text = "Historial";
            this.btn_historial.UseVisualStyleBackColor = false;
            this.btn_historial.Click += new System.EventHandler(this.btn_historial_Click);
            // 
            // Canje_Puntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 678);
            this.Controls.Add(this.btn_historial);
            this.Controls.Add(this.Premios);
            this.Controls.Add(this.dataGridPremios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_canjear);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Canje_Puntos";
            this.Text = "Canje de puntos";
            this.Load += new System.EventHandler(this.Canje_Puntos_Load);
            this.Controls.SetChildIndex(this.btn_canjear, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.dataGridPremios, 0);
            this.Controls.SetChildIndex(this.Premios, 0);
            this.Controls.SetChildIndex(this.btn_historial, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPremios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_canjear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.DataGridView dataGridPremios;
        private System.Windows.Forms.Label Premios;
        public System.Windows.Forms.Button btn_historial;
    }
}
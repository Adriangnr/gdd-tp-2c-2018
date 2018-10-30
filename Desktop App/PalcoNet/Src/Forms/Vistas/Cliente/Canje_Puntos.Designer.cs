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
            this.premios = new System.Windows.Forms.ListBox();
            this.btn_canjear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(632, 354);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(129, 45);
            this.btn_cancel.TabIndex = 60;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // premios
            // 
            this.premios.FormattingEnabled = true;
            this.premios.Location = new System.Drawing.Point(245, 83);
            this.premios.Name = "premios";
            this.premios.Size = new System.Drawing.Size(366, 316);
            this.premios.TabIndex = 59;
            // 
            // btn_canjear
            // 
            this.btn_canjear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_canjear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_canjear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_canjear.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_canjear.Location = new System.Drawing.Point(632, 83);
            this.btn_canjear.Margin = new System.Windows.Forms.Padding(0);
            this.btn_canjear.Name = "btn_canjear";
            this.btn_canjear.Size = new System.Drawing.Size(129, 45);
            this.btn_canjear.TabIndex = 57;
            this.btn_canjear.Text = "Canjear";
            this.btn_canjear.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.points);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(32, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 100);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tus Puntos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "label1";
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.points.Location = new System.Drawing.Point(33, 34);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(131, 39);
            this.points.TabIndex = 0;
            this.points.Text = "999999";
            // 
            // Canje_Puntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.premios);
            this.Controls.Add(this.btn_canjear);
            this.Name = "Canje_Puntos";
            this.Text = "Canje_Puntos";
            this.Load += new System.EventHandler(this.Canje_Puntos_Load);
            this.Controls.SetChildIndex(this.btn_canjear, 0);
            this.Controls.SetChildIndex(this.premios, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.ListBox premios;
        public System.Windows.Forms.Button btn_canjear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label label1;
    }
}
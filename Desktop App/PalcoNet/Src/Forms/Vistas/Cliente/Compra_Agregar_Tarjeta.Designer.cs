namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    partial class Compra_Agregar_Tarjeta
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
            this.label1 = new System.Windows.Forms.Label();
            this.tarjetaNueva = new System.Windows.Forms.TextBox();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(255, 273);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de tarjeta";
            // 
            // tarjetaNueva
            // 
            this.tarjetaNueva.Location = new System.Drawing.Point(178, 124);
            this.tarjetaNueva.Name = "tarjetaNueva";
            this.tarjetaNueva.Size = new System.Drawing.Size(184, 20);
            this.tarjetaNueva.TabIndex = 3;
            // 
            // btn_comprar
            // 
            this.btn_comprar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_comprar.Location = new System.Drawing.Point(108, 203);
            this.btn_comprar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(129, 45);
            this.btn_comprar.TabIndex = 66;
            this.btn_comprar.Text = "Confirmar";
            this.btn_comprar.UseVisualStyleBackColor = false;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(286, 203);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(129, 45);
            this.btn_cancel.TabIndex = 67;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Compra_Agregar_Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 300);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.tarjetaNueva);
            this.Controls.Add(this.label1);
            this.Name = "Compra_Agregar_Tarjeta";
            this.Text = "Agregar Tarjeta";
            this.Load += new System.EventHandler(this.Compra_Agrega_Tarjeta_Load);
            this.Controls.SetChildIndex(this.footer, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tarjetaNueva, 0);
            this.Controls.SetChildIndex(this.btn_comprar, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tarjetaNueva;
        public System.Windows.Forms.Button btn_comprar;
        protected System.Windows.Forms.Button btn_cancel;
    }
}
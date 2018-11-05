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
            this.ventasComisionables = new System.Windows.Forms.CheckedListBox();
            this.btn_comisionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ventasComisionables
            // 
            this.ventasComisionables.FormattingEnabled = true;
            this.ventasComisionables.Location = new System.Drawing.Point(32, 108);
            this.ventasComisionables.Margin = new System.Windows.Forms.Padding(10);
            this.ventasComisionables.Name = "ventasComisionables";
            this.ventasComisionables.Size = new System.Drawing.Size(540, 289);
            this.ventasComisionables.TabIndex = 0;
            // 
            // btn_comisionar
            // 
            this.btn_comisionar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_comisionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comisionar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comisionar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_comisionar.Location = new System.Drawing.Point(622, 108);
            this.btn_comisionar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_comisionar.Name = "btn_comisionar";
            this.btn_comisionar.Size = new System.Drawing.Size(129, 45);
            this.btn_comisionar.TabIndex = 5;
            this.btn_comisionar.Text = "Comisionar";
            this.btn_comisionar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(28, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Comisionar Ventas";
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancel.Location = new System.Drawing.Point(622, 352);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(129, 45);
            this.btn_cancel.TabIndex = 57;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Comisiones_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_comisionar);
            this.Controls.Add(this.ventasComisionables);
            this.Name = "Comisiones_Detalle";
            this.Text = "Comisiones_Detalle";
            this.Load += new System.EventHandler(this.Comisiones_Detalle_Load);
            this.Controls.SetChildIndex(this.ventasComisionables, 0);
            this.Controls.SetChildIndex(this.btn_comisionar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ventasComisionables;
        public System.Windows.Forms.Button btn_comisionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
    }
}
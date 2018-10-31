namespace PalcoNet.Vistas.General
{
    partial class Selector_Rol
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
            this.combo_rol = new System.Windows.Forms.ComboBox();
            this.text = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combo_rol
            // 
            this.combo_rol.BackColor = System.Drawing.SystemColors.Control;
            this.combo_rol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_rol.FormattingEnabled = true;
            this.combo_rol.ItemHeight = 24;
            this.combo_rol.Location = new System.Drawing.Point(143, 106);
            this.combo_rol.Name = "combo_rol";
            this.combo_rol.Size = new System.Drawing.Size(172, 30);
            this.combo_rol.TabIndex = 0;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.SystemColors.GrayText;
            this.text.Location = new System.Drawing.Point(67, 66);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(317, 15);
            this.text.TabIndex = 1;
            this.text.Text = "Por favor, seleccione el perfil con el que desea continuar:";
            this.text.Click += new System.EventHandler(this.label1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.title.Location = new System.Drawing.Point(139, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(177, 23);
            this.title.TabIndex = 2;
            this.title.Text = "Usuario Multi-Rol";
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_confirm.Location = new System.Drawing.Point(159, 168);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(0);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(145, 45);
            this.btn_confirm.TabIndex = 5;
            this.btn_confirm.Text = "Continuar";
            this.btn_confirm.UseVisualStyleBackColor = false;
            // 
            // Selector_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(464, 241);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.title);
            this.Controls.Add(this.text);
            this.Controls.Add(this.combo_rol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Selector_Rol";
            this.Text = "Seleccione un rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_rol;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label title;
        public System.Windows.Forms.Button btn_confirm;
    }
}
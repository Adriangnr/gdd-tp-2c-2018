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
            this.text = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.combo_rol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.SystemColors.GrayText;
            this.text.Location = new System.Drawing.Point(100, 102);
            this.text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(467, 22);
            this.text.TabIndex = 1;
            this.text.Text = "Por favor, seleccione el perfil con el que desea continuar:";
            this.text.Click += new System.EventHandler(this.label1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.title.Location = new System.Drawing.Point(208, 35);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(265, 35);
            this.title.TabIndex = 2;
            this.title.Text = "Usuario Multi-Rol";
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_confirm.Location = new System.Drawing.Point(238, 258);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(0);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(218, 69);
            this.btn_confirm.TabIndex = 5;
            this.btn_confirm.Text = "Continuar";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // combo_rol
            // 
            this.combo_rol.AccessibleName = "combo_rol";
            this.combo_rol.FormattingEnabled = true;
            this.combo_rol.Location = new System.Drawing.Point(189, 161);
            this.combo_rol.Name = "combo_rol";
            this.combo_rol.Size = new System.Drawing.Size(293, 28);
            this.combo_rol.TabIndex = 6;
            this.combo_rol.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Selector_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(696, 371);
            this.Controls.Add(this.combo_rol);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.title);
            this.Controls.Add(this.text);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Selector_Rol";
            this.Text = "Seleccione un rol";
            this.Controls.SetChildIndex(this.text, 0);
            this.Controls.SetChildIndex(this.title, 0);
            this.Controls.SetChildIndex(this.btn_confirm, 0);
            this.Controls.SetChildIndex(this.combo_rol, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label title;
        public System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.ComboBox combo_rol;
    }
}
namespace PalcoNet.Src.Forms.Layouts
{
    partial class Master
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
            this.title = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.DimGray;
            this.title.Location = new System.Drawing.Point(25, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(171, 37);
            this.title.TabIndex = 0;
            this.title.Text = "Palco.NET";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // footer
            // 
            this.footer.AutoSize = true;
            this.footer.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.footer.Location = new System.Drawing.Point(534, 419);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(238, 13);
            this.footer.TabIndex = 1;
            this.footer.Text = "Desarrollado para la cátedra de GDD - UTN2018";
            this.footer.Click += new System.EventHandler(this.label2_Click);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Master_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        protected System.Windows.Forms.Label footer;
    }
}
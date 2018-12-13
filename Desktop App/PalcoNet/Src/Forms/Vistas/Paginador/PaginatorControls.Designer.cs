namespace PalcoNet.Src.Forms.Vistas.Paginador
{
    partial class PaginatorControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.totalPaginas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paginaActual = new System.Windows.Forms.Label();
            this.btn_lastPage = new System.Windows.Forms.Button();
            this.btn_firstPage = new System.Windows.Forms.Button();
            this.btn_nextPage = new System.Windows.Forms.Button();
            this.btn_previousPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalPaginas
            // 
            this.totalPaginas.AutoSize = true;
            this.totalPaginas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.totalPaginas.Location = new System.Drawing.Point(190, 11);
            this.totalPaginas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPaginas.Name = "totalPaginas";
            this.totalPaginas.Size = new System.Drawing.Size(13, 13);
            this.totalPaginas.TabIndex = 76;
            this.totalPaginas.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(157, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "de";
            // 
            // paginaActual
            // 
            this.paginaActual.AutoSize = true;
            this.paginaActual.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.paginaActual.Location = new System.Drawing.Point(125, 12);
            this.paginaActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paginaActual.Name = "paginaActual";
            this.paginaActual.Size = new System.Drawing.Size(13, 13);
            this.paginaActual.TabIndex = 74;
            this.paginaActual.Text = "0";
            // 
            // btn_lastPage
            // 
            this.btn_lastPage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_lastPage.Location = new System.Drawing.Point(281, 5);
            this.btn_lastPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_lastPage.Name = "btn_lastPage";
            this.btn_lastPage.Size = new System.Drawing.Size(50, 21);
            this.btn_lastPage.TabIndex = 73;
            this.btn_lastPage.Text = ">>";
            this.btn_lastPage.UseVisualStyleBackColor = true;
            this.btn_lastPage.Click += new System.EventHandler(this.btn_lastPage_Click);
            // 
            // btn_firstPage
            // 
            this.btn_firstPage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_firstPage.Location = new System.Drawing.Point(5, 5);
            this.btn_firstPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_firstPage.Name = "btn_firstPage";
            this.btn_firstPage.Size = new System.Drawing.Size(50, 21);
            this.btn_firstPage.TabIndex = 72;
            this.btn_firstPage.Text = "<<";
            this.btn_firstPage.UseVisualStyleBackColor = true;
            this.btn_firstPage.Click += new System.EventHandler(this.btn_firstPage_Click);
            // 
            // btn_nextPage
            // 
            this.btn_nextPage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_nextPage.Location = new System.Drawing.Point(227, 5);
            this.btn_nextPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_nextPage.Name = "btn_nextPage";
            this.btn_nextPage.Size = new System.Drawing.Size(50, 21);
            this.btn_nextPage.TabIndex = 71;
            this.btn_nextPage.Text = ">";
            this.btn_nextPage.UseVisualStyleBackColor = true;
            this.btn_nextPage.Click += new System.EventHandler(this.btn_nextPage_Click);
            // 
            // btn_previousPage
            // 
            this.btn_previousPage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_previousPage.Location = new System.Drawing.Point(58, 5);
            this.btn_previousPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_previousPage.Name = "btn_previousPage";
            this.btn_previousPage.Size = new System.Drawing.Size(50, 21);
            this.btn_previousPage.TabIndex = 70;
            this.btn_previousPage.Text = "<";
            this.btn_previousPage.UseVisualStyleBackColor = true;
            this.btn_previousPage.Click += new System.EventHandler(this.btn_previousPage_Click);
            // 
            // PaginatorControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.totalPaginas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paginaActual);
            this.Controls.Add(this.btn_lastPage);
            this.Controls.Add(this.btn_firstPage);
            this.Controls.Add(this.btn_nextPage);
            this.Controls.Add(this.btn_previousPage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PaginatorControls";
            this.Size = new System.Drawing.Size(337, 31);
            this.Load += new System.EventHandler(this.PaginatorControls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalPaginas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label paginaActual;
        private System.Windows.Forms.Button btn_lastPage;
        private System.Windows.Forms.Button btn_firstPage;
        private System.Windows.Forms.Button btn_nextPage;
        private System.Windows.Forms.Button btn_previousPage;
    }
}

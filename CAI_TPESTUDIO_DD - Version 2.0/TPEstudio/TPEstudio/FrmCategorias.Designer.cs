
namespace TPEstudio
{
    partial class FrmCategorias
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
            this.btnVolver = new System.Windows.Forms.Button();
            this._btnIngresarCategoria = new System.Windows.Forms.Button();
            this._btnConsultarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(632, 356);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(124, 34);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // _btnIngresarCategoria
            // 
            this._btnIngresarCategoria.Location = new System.Drawing.Point(177, 172);
            this._btnIngresarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnIngresarCategoria.Name = "_btnIngresarCategoria";
            this._btnIngresarCategoria.Size = new System.Drawing.Size(184, 80);
            this._btnIngresarCategoria.TabIndex = 1;
            this._btnIngresarCategoria.Text = "Ingresar Categoria";
            this._btnIngresarCategoria.UseVisualStyleBackColor = true;
            this._btnIngresarCategoria.Click += new System.EventHandler(this._btnIngresarCategoria_Click);
            // 
            // _btnConsultarCategoria
            // 
            this._btnConsultarCategoria.Location = new System.Drawing.Point(464, 172);
            this._btnConsultarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnConsultarCategoria.Name = "_btnConsultarCategoria";
            this._btnConsultarCategoria.Size = new System.Drawing.Size(184, 80);
            this._btnConsultarCategoria.TabIndex = 2;
            this._btnConsultarCategoria.Text = "Consultar Categoria";
            this._btnConsultarCategoria.UseVisualStyleBackColor = true;
            this._btnConsultarCategoria.Click += new System.EventHandler(this._btnConsultarCategoria_Click);
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnConsultarCategoria);
            this.Controls.Add(this._btnIngresarCategoria);
            this.Controls.Add(this.btnVolver);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCategorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button _btnIngresarCategoria;
        private System.Windows.Forms.Button _btnConsultarCategoria;
    }
}
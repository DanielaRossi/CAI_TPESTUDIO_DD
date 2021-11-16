
namespace TPEstudio
{
    partial class FrmEmpresas
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
            this._btnIngresarEmpresa = new System.Windows.Forms.Button();
            this._btnConsultarEmpresas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(473, 294);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(83, 38);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // _btnIngresarEmpresa
            // 
            this._btnIngresarEmpresa.Location = new System.Drawing.Point(127, 118);
            this._btnIngresarEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this._btnIngresarEmpresa.Name = "_btnIngresarEmpresa";
            this._btnIngresarEmpresa.Size = new System.Drawing.Size(141, 61);
            this._btnIngresarEmpresa.TabIndex = 1;
            this._btnIngresarEmpresa.Text = "Ingresar nueva empresa";
            this._btnIngresarEmpresa.UseVisualStyleBackColor = true;
            // 
            // _btnConsultarEmpresas
            // 
            this._btnConsultarEmpresas.Location = new System.Drawing.Point(348, 118);
            this._btnConsultarEmpresas.Margin = new System.Windows.Forms.Padding(2);
            this._btnConsultarEmpresas.Name = "_btnConsultarEmpresas";
            this._btnConsultarEmpresas.Size = new System.Drawing.Size(141, 61);
            this._btnConsultarEmpresas.TabIndex = 2;
            this._btnConsultarEmpresas.Text = "Consultar empresa";
            this._btnConsultarEmpresas.UseVisualStyleBackColor = true;
            // 
            // FrmEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this._btnConsultarEmpresas);
            this.Controls.Add(this._btnIngresarEmpresa);
            this.Controls.Add(this.btnVolver);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmEmpresas";
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.FrmEmpresas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button _btnIngresarEmpresa;
        private System.Windows.Forms.Button _btnConsultarEmpresas;
    }
}
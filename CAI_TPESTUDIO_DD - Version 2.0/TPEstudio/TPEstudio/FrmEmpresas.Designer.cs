
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
            this.btnVolver.Location = new System.Drawing.Point(631, 362);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(111, 47);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // _btnIngresarEmpresa
            // 
            this._btnIngresarEmpresa.Location = new System.Drawing.Point(169, 145);
            this._btnIngresarEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnIngresarEmpresa.Name = "_btnIngresarEmpresa";
            this._btnIngresarEmpresa.Size = new System.Drawing.Size(188, 75);
            this._btnIngresarEmpresa.TabIndex = 1;
            this._btnIngresarEmpresa.Text = "Ingresar nueva empresa";
            this._btnIngresarEmpresa.UseVisualStyleBackColor = true;
            this._btnIngresarEmpresa.Click += new System.EventHandler(this._btnIngresarEmpresa_Click);
            // 
            // _btnConsultarEmpresas
            // 
            this._btnConsultarEmpresas.Location = new System.Drawing.Point(464, 145);
            this._btnConsultarEmpresas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnConsultarEmpresas.Name = "_btnConsultarEmpresas";
            this._btnConsultarEmpresas.Size = new System.Drawing.Size(188, 75);
            this._btnConsultarEmpresas.TabIndex = 2;
            this._btnConsultarEmpresas.Text = "Consultar empresa";
            this._btnConsultarEmpresas.UseVisualStyleBackColor = true;
            this._btnConsultarEmpresas.Click += new System.EventHandler(this._btnConsultarEmpresas_Click);
            // 
            // FrmEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnConsultarEmpresas);
            this.Controls.Add(this._btnIngresarEmpresa);
            this.Controls.Add(this.btnVolver);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
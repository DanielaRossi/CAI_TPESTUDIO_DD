
namespace TPEstudio
{
    partial class FrmIngresarCategoria
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
            this._lblId = new System.Windows.Forms.Label();
            this._lblNombre = new System.Windows.Forms.Label();
            this._lblConvenio = new System.Windows.Forms.Label();
            this._lblSueldosBasico = new System.Windows.Forms.Label();
            this._cmbConvenio = new System.Windows.Forms.ComboBox();
            this._txtSueldosBasico = new System.Windows.Forms.TextBox();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._cmbIdCategoria = new System.Windows.Forms.ComboBox();
            this._btnAgregar = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblId
            // 
            this._lblId.AutoSize = true;
            this._lblId.Location = new System.Drawing.Point(83, 81);
            this._lblId.Name = "_lblId";
            this._lblId.Size = new System.Drawing.Size(64, 13);
            this._lblId.TabIndex = 0;
            this._lblId.Text = "Id Categoria";
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Location = new System.Drawing.Point(83, 131);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(44, 13);
            this._lblNombre.TabIndex = 1;
            this._lblNombre.Text = "Nombre";
            // 
            // _lblConvenio
            // 
            this._lblConvenio.AutoSize = true;
            this._lblConvenio.Location = new System.Drawing.Point(83, 177);
            this._lblConvenio.Name = "_lblConvenio";
            this._lblConvenio.Size = new System.Drawing.Size(52, 13);
            this._lblConvenio.TabIndex = 2;
            this._lblConvenio.Text = "Convenio";
            // 
            // _lblSueldosBasico
            // 
            this._lblSueldosBasico.AutoSize = true;
            this._lblSueldosBasico.Location = new System.Drawing.Point(83, 215);
            this._lblSueldosBasico.Name = "_lblSueldosBasico";
            this._lblSueldosBasico.Size = new System.Drawing.Size(75, 13);
            this._lblSueldosBasico.TabIndex = 3;
            this._lblSueldosBasico.Text = "Sueldo Basico";
            // 
            // _cmbConvenio
            // 
            this._cmbConvenio.FormattingEnabled = true;
            this._cmbConvenio.Location = new System.Drawing.Point(206, 177);
            this._cmbConvenio.Name = "_cmbConvenio";
            this._cmbConvenio.Size = new System.Drawing.Size(100, 21);
            this._cmbConvenio.TabIndex = 4;
            // 
            // _txtSueldosBasico
            // 
            this._txtSueldosBasico.Location = new System.Drawing.Point(206, 215);
            this._txtSueldosBasico.Name = "_txtSueldosBasico";
            this._txtSueldosBasico.Size = new System.Drawing.Size(100, 20);
            this._txtSueldosBasico.TabIndex = 5;
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(206, 128);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(100, 20);
            this._txtNombre.TabIndex = 6;
            // 
            // _cmbIdCategoria
            // 
            this._cmbIdCategoria.FormattingEnabled = true;
            this._cmbIdCategoria.Location = new System.Drawing.Point(206, 78);
            this._cmbIdCategoria.Name = "_cmbIdCategoria";
            this._cmbIdCategoria.Size = new System.Drawing.Size(100, 21);
            this._cmbIdCategoria.TabIndex = 7;
            // 
            // _btnAgregar
            // 
            this._btnAgregar.Location = new System.Drawing.Point(206, 266);
            this._btnAgregar.Name = "_btnAgregar";
            this._btnAgregar.Size = new System.Drawing.Size(75, 23);
            this._btnAgregar.TabIndex = 8;
            this._btnAgregar.Text = "Agregar";
            this._btnAgregar.UseVisualStyleBackColor = true;
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(350, 318);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(75, 23);
            this._btnVolver.TabIndex = 9;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // FrmIngresarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnAgregar);
            this.Controls.Add(this._cmbIdCategoria);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._txtSueldosBasico);
            this.Controls.Add(this._cmbConvenio);
            this.Controls.Add(this._lblSueldosBasico);
            this.Controls.Add(this._lblConvenio);
            this.Controls.Add(this._lblNombre);
            this.Controls.Add(this._lblId);
            this.Name = "FrmIngresarCategoria";
            this.Text = "FrmIngresarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblId;
        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Label _lblConvenio;
        private System.Windows.Forms.Label _lblSueldosBasico;
        private System.Windows.Forms.ComboBox _cmbConvenio;
        private System.Windows.Forms.TextBox _txtSueldosBasico;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.ComboBox _cmbIdCategoria;
        private System.Windows.Forms.Button _btnAgregar;
        private System.Windows.Forms.Button _btnVolver;
    }
}
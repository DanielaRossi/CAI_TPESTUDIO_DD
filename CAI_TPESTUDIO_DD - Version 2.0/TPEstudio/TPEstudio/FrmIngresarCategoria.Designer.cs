﻿
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
            this._lblNombre = new System.Windows.Forms.Label();
            this._lblConvenio = new System.Windows.Forms.Label();
            this._lblSueldosBasico = new System.Windows.Forms.Label();
            this._cmbConvenio = new System.Windows.Forms.ComboBox();
            this._txtSueldosBasico = new System.Windows.Forms.TextBox();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._btnAgregar = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.Button();
            this.txtConvenio = new System.Windows.Forms.TextBox();
            this.txtsueldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Location = new System.Drawing.Point(111, 161);
            this._lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(58, 17);
            this._lblNombre.TabIndex = 1;
            this._lblNombre.Text = "Nombre";
            // 
            // _lblConvenio
            // 
            this._lblConvenio.AutoSize = true;
            this._lblConvenio.Location = new System.Drawing.Point(111, 218);
            this._lblConvenio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblConvenio.Name = "_lblConvenio";
            this._lblConvenio.Size = new System.Drawing.Size(67, 17);
            this._lblConvenio.TabIndex = 2;
            this._lblConvenio.Text = "Convenio";
            // 
            // _lblSueldosBasico
            // 
            this._lblSueldosBasico.AutoSize = true;
            this._lblSueldosBasico.Location = new System.Drawing.Point(111, 265);
            this._lblSueldosBasico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblSueldosBasico.Name = "_lblSueldosBasico";
            this._lblSueldosBasico.Size = new System.Drawing.Size(98, 17);
            this._lblSueldosBasico.TabIndex = 3;
            this._lblSueldosBasico.Text = "Sueldo Basico";
            // 
            // _cmbConvenio
            // 
            this._cmbConvenio.FormattingEnabled = true;
            this._cmbConvenio.Location = new System.Drawing.Point(435, 215);
            this._cmbConvenio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._cmbConvenio.Name = "_cmbConvenio";
            this._cmbConvenio.Size = new System.Drawing.Size(132, 24);
            this._cmbConvenio.TabIndex = 4;
            // 
            // _txtSueldosBasico
            // 
            this._txtSueldosBasico.Enabled = false;
            this._txtSueldosBasico.Location = new System.Drawing.Point(420, 265);
            this._txtSueldosBasico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._txtSueldosBasico.Name = "_txtSueldosBasico";
            this._txtSueldosBasico.Size = new System.Drawing.Size(132, 22);
            this._txtSueldosBasico.TabIndex = 5;
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(275, 158);
            this._txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(132, 22);
            this._txtNombre.TabIndex = 6;
            // 
            // _btnAgregar
            // 
            this._btnAgregar.Location = new System.Drawing.Point(275, 327);
            this._btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._btnAgregar.Name = "_btnAgregar";
            this._btnAgregar.Size = new System.Drawing.Size(100, 28);
            this._btnAgregar.TabIndex = 8;
            this._btnAgregar.Text = "Agregar";
            this._btnAgregar.UseVisualStyleBackColor = true;
            this._btnAgregar.Click += new System.EventHandler(this._btnAgregar_Click);
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(467, 391);
            this._btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(100, 28);
            this._btnVolver.TabIndex = 9;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // txtConvenio
            // 
            this.txtConvenio.Location = new System.Drawing.Point(275, 212);
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.Size = new System.Drawing.Size(114, 22);
            this.txtConvenio.TabIndex = 10;
            // 
            // txtsueldo
            // 
            this.txtsueldo.Location = new System.Drawing.Point(266, 259);
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(100, 22);
            this.txtsueldo.TabIndex = 11;
            // 
            // FrmIngresarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 554);
            this.Controls.Add(this.txtsueldo);
            this.Controls.Add(this.txtConvenio);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnAgregar);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._txtSueldosBasico);
            this.Controls.Add(this._cmbConvenio);
            this.Controls.Add(this._lblSueldosBasico);
            this.Controls.Add(this._lblConvenio);
            this.Controls.Add(this._lblNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmIngresarCategoria";
            this.Text = "FrmIngresarCategoria";
            this.Load += new System.EventHandler(this.FrmIngresarCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Label _lblConvenio;
        private System.Windows.Forms.Label _lblSueldosBasico;
        private System.Windows.Forms.ComboBox _cmbConvenio;
        private System.Windows.Forms.TextBox _txtSueldosBasico;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.Button _btnAgregar;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.TextBox txtConvenio;
        private System.Windows.Forms.TextBox txtsueldo;
    }
}
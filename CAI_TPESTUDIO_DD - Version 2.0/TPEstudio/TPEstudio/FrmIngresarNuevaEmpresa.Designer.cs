
namespace TPEstudio
{
    partial class FrmIngresarNuevaEmpresa
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
            this._lblRazonSocial = new System.Windows.Forms.Label();
            this._lblCuit = new System.Windows.Forms.Label();
            this._txtRazonSocial = new System.Windows.Forms.TextBox();
            this._txtCuit = new System.Windows.Forms.TextBox();
            this._txtId = new System.Windows.Forms.TextBox();
            this._lblId = new System.Windows.Forms.Label();
            this._txtDomicilio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._btnAgregar = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblRazonSocial
            // 
            this._lblRazonSocial.AutoSize = true;
            this._lblRazonSocial.Location = new System.Drawing.Point(70, 93);
            this._lblRazonSocial.Name = "_lblRazonSocial";
            this._lblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this._lblRazonSocial.TabIndex = 0;
            this._lblRazonSocial.Text = "Razon Social";
            // 
            // _lblCuit
            // 
            this._lblCuit.AutoSize = true;
            this._lblCuit.Location = new System.Drawing.Point(70, 140);
            this._lblCuit.Name = "_lblCuit";
            this._lblCuit.Size = new System.Drawing.Size(32, 13);
            this._lblCuit.TabIndex = 1;
            this._lblCuit.Text = "CUIT";
            // 
            // _txtRazonSocial
            // 
            this._txtRazonSocial.Location = new System.Drawing.Point(151, 93);
            this._txtRazonSocial.Name = "_txtRazonSocial";
            this._txtRazonSocial.Size = new System.Drawing.Size(100, 20);
            this._txtRazonSocial.TabIndex = 2;
            // 
            // _txtCuit
            // 
            this._txtCuit.Location = new System.Drawing.Point(151, 140);
            this._txtCuit.Name = "_txtCuit";
            this._txtCuit.Size = new System.Drawing.Size(100, 20);
            this._txtCuit.TabIndex = 3;
            // 
            // _txtId
            // 
            this._txtId.Location = new System.Drawing.Point(151, 187);
            this._txtId.Name = "_txtId";
            this._txtId.Size = new System.Drawing.Size(100, 20);
            this._txtId.TabIndex = 5;
            // 
            // _lblId
            // 
            this._lblId.AutoSize = true;
            this._lblId.Location = new System.Drawing.Point(70, 187);
            this._lblId.Name = "_lblId";
            this._lblId.Size = new System.Drawing.Size(18, 13);
            this._lblId.TabIndex = 4;
            this._lblId.Text = "ID";
            // 
            // _txtDomicilio
            // 
            this._txtDomicilio.Location = new System.Drawing.Point(151, 229);
            this._txtDomicilio.Name = "_txtDomicilio";
            this._txtDomicilio.Size = new System.Drawing.Size(100, 20);
            this._txtDomicilio.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Domicilio";
            // 
            // _btnAgregar
            // 
            this._btnAgregar.Location = new System.Drawing.Point(262, 284);
            this._btnAgregar.Name = "_btnAgregar";
            this._btnAgregar.Size = new System.Drawing.Size(75, 23);
            this._btnAgregar.TabIndex = 8;
            this._btnAgregar.Text = "Agregar";
            this._btnAgregar.UseVisualStyleBackColor = true;
            this._btnAgregar.Click += new System.EventHandler(this._btnAgregar_Click);
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(262, 328);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(75, 23);
            this._btnVolver.TabIndex = 9;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // FrmIngresarNuevaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnAgregar);
            this.Controls.Add(this._txtDomicilio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtId);
            this.Controls.Add(this._lblId);
            this.Controls.Add(this._txtCuit);
            this.Controls.Add(this._txtRazonSocial);
            this.Controls.Add(this._lblCuit);
            this.Controls.Add(this._lblRazonSocial);
            this.Name = "FrmIngresarNuevaEmpresa";
            this.Text = "FrmIngresarNuevaEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblRazonSocial;
        private System.Windows.Forms.Label _lblCuit;
        private System.Windows.Forms.TextBox _txtRazonSocial;
        private System.Windows.Forms.TextBox _txtCuit;
        private System.Windows.Forms.TextBox _txtId;
        private System.Windows.Forms.Label _lblId;
        private System.Windows.Forms.TextBox _txtDomicilio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnAgregar;
        private System.Windows.Forms.Button _btnVolver;
    }
}
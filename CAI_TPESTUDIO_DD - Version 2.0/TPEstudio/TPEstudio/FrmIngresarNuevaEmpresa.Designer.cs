
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
            this._txtDomicilio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._btnAgregar = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblRazonSocial
            // 
            this._lblRazonSocial.AutoSize = true;
            this._lblRazonSocial.Location = new System.Drawing.Point(93, 114);
            this._lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblRazonSocial.Name = "_lblRazonSocial";
            this._lblRazonSocial.Size = new System.Drawing.Size(91, 17);
            this._lblRazonSocial.TabIndex = 0;
            this._lblRazonSocial.Text = "Razon Social";
            // 
            // _lblCuit
            // 
            this._lblCuit.AutoSize = true;
            this._lblCuit.Location = new System.Drawing.Point(93, 172);
            this._lblCuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblCuit.Name = "_lblCuit";
            this._lblCuit.Size = new System.Drawing.Size(39, 17);
            this._lblCuit.TabIndex = 1;
            this._lblCuit.Text = "CUIT";
            // 
            // _txtRazonSocial
            // 
            this._txtRazonSocial.Location = new System.Drawing.Point(201, 114);
            this._txtRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this._txtRazonSocial.Name = "_txtRazonSocial";
            this._txtRazonSocial.Size = new System.Drawing.Size(132, 22);
            this._txtRazonSocial.TabIndex = 2;
            // 
            // _txtCuit
            // 
            this._txtCuit.Location = new System.Drawing.Point(201, 172);
            this._txtCuit.Margin = new System.Windows.Forms.Padding(4);
            this._txtCuit.Name = "_txtCuit";
            this._txtCuit.Size = new System.Drawing.Size(132, 22);
            this._txtCuit.TabIndex = 3;
            // 
            // _txtDomicilio
            // 
            this._txtDomicilio.Location = new System.Drawing.Point(201, 239);
            this._txtDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this._txtDomicilio.Name = "_txtDomicilio";
            this._txtDomicilio.Size = new System.Drawing.Size(132, 22);
            this._txtDomicilio.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Domicilio";
            // 
            // _btnAgregar
            // 
            this._btnAgregar.Location = new System.Drawing.Point(349, 350);
            this._btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this._btnAgregar.Name = "_btnAgregar";
            this._btnAgregar.Size = new System.Drawing.Size(100, 28);
            this._btnAgregar.TabIndex = 8;
            this._btnAgregar.Text = "Agregar";
            this._btnAgregar.UseVisualStyleBackColor = true;
            this._btnAgregar.Click += new System.EventHandler(this._btnAgregar_Click);
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(349, 404);
            this._btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(100, 28);
            this._btnVolver.TabIndex = 9;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // FrmIngresarNuevaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 554);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnAgregar);
            this.Controls.Add(this._txtDomicilio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtCuit);
            this.Controls.Add(this._txtRazonSocial);
            this.Controls.Add(this._lblCuit);
            this.Controls.Add(this._lblRazonSocial);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmIngresarNuevaEmpresa";
            this.Text = "FrmIngresarNuevaEmpresa";
            this.Load += new System.EventHandler(this.FrmIngresarNuevaEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblRazonSocial;
        private System.Windows.Forms.Label _lblCuit;
        private System.Windows.Forms.TextBox _txtRazonSocial;
        private System.Windows.Forms.TextBox _txtCuit;
        private System.Windows.Forms.TextBox _txtDomicilio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnAgregar;
        private System.Windows.Forms.Button _btnVolver;
    }
}
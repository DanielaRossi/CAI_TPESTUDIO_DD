
namespace TPEstudio
{
    partial class FrmIngresarLiquidacion
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
            this._lblLegajo = new System.Windows.Forms.Label();
            this._lblCodigoTransferencia = new System.Windows.Forms.Label();
            this._lblPeriodo = new System.Windows.Forms.Label();
            this._lblBruto = new System.Windows.Forms.Label();
            this._lblDescuentos = new System.Windows.Forms.Label();
            this.txtIDLIQUIDACIÓN = new System.Windows.Forms.TextBox();
            this.txtbruto = new System.Windows.Forms.TextBox();
            this.txtDescuentos = new System.Windows.Forms.TextBox();
            this._btnAgregar = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.Button();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.txtCodigoTransferencia = new System.Windows.Forms.TextBox();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _lblId
            // 
            this._lblId.AutoSize = true;
            this._lblId.Location = new System.Drawing.Point(104, 147);
            this._lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblId.Name = "_lblId";
            this._lblId.Size = new System.Drawing.Size(71, 17);
            this._lblId.TabIndex = 0;
            this._lblId.Text = "Empleado";
            // 
            // _lblLegajo
            // 
            this._lblLegajo.AutoSize = true;
            this._lblLegajo.Location = new System.Drawing.Point(100, 80);
            this._lblLegajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblLegajo.Name = "_lblLegajo";
            this._lblLegajo.Size = new System.Drawing.Size(112, 17);
            this._lblLegajo.TabIndex = 1;
            this._lblLegajo.Text = "ID de liquidación";
            // 
            // _lblCodigoTransferencia
            // 
            this._lblCodigoTransferencia.AutoSize = true;
            this._lblCodigoTransferencia.Location = new System.Drawing.Point(100, 210);
            this._lblCodigoTransferencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblCodigoTransferencia.Name = "_lblCodigoTransferencia";
            this._lblCodigoTransferencia.Size = new System.Drawing.Size(144, 17);
            this._lblCodigoTransferencia.TabIndex = 2;
            this._lblCodigoTransferencia.Text = "Codigo Transferencia";
            // 
            // _lblPeriodo
            // 
            this._lblPeriodo.AutoSize = true;
            this._lblPeriodo.Location = new System.Drawing.Point(100, 266);
            this._lblPeriodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblPeriodo.Name = "_lblPeriodo";
            this._lblPeriodo.Size = new System.Drawing.Size(57, 17);
            this._lblPeriodo.TabIndex = 3;
            this._lblPeriodo.Text = "Periodo";
            // 
            // _lblBruto
            // 
            this._lblBruto.AutoSize = true;
            this._lblBruto.Location = new System.Drawing.Point(100, 321);
            this._lblBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblBruto.Name = "_lblBruto";
            this._lblBruto.Size = new System.Drawing.Size(42, 17);
            this._lblBruto.TabIndex = 4;
            this._lblBruto.Text = "Bruto";
            // 
            // _lblDescuentos
            // 
            this._lblDescuentos.AutoSize = true;
            this._lblDescuentos.Location = new System.Drawing.Point(100, 379);
            this._lblDescuentos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblDescuentos.Name = "_lblDescuentos";
            this._lblDescuentos.Size = new System.Drawing.Size(83, 17);
            this._lblDescuentos.TabIndex = 5;
            this._lblDescuentos.Text = "Descuentos";
            // 
            // txtIDLIQUIDACIÓN
            // 
            this.txtIDLIQUIDACIÓN.Enabled = false;
            this.txtIDLIQUIDACIÓN.Location = new System.Drawing.Point(497, 80);
            this.txtIDLIQUIDACIÓN.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDLIQUIDACIÓN.Name = "txtIDLIQUIDACIÓN";
            this.txtIDLIQUIDACIÓN.Size = new System.Drawing.Size(79, 22);
            this.txtIDLIQUIDACIÓN.TabIndex = 8;
            // 
            // txtbruto
            // 
            this.txtbruto.Location = new System.Drawing.Point(432, 321);
            this.txtbruto.Margin = new System.Windows.Forms.Padding(4);
            this.txtbruto.Name = "txtbruto";
            this.txtbruto.Size = new System.Drawing.Size(144, 22);
            this.txtbruto.TabIndex = 10;
            // 
            // txtDescuentos
            // 
            this.txtDescuentos.Location = new System.Drawing.Point(432, 375);
            this.txtDescuentos.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuentos.Name = "txtDescuentos";
            this.txtDescuentos.Size = new System.Drawing.Size(144, 22);
            this.txtDescuentos.TabIndex = 11;
            // 
            // _btnAgregar
            // 
            this._btnAgregar.Location = new System.Drawing.Point(299, 511);
            this._btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this._btnAgregar.Name = "_btnAgregar";
            this._btnAgregar.Size = new System.Drawing.Size(100, 28);
            this._btnAgregar.TabIndex = 14;
            this._btnAgregar.Text = "Agregar";
            this._btnAgregar.UseVisualStyleBackColor = true;
            this._btnAgregar.Click += new System.EventHandler(this._btnAgregar_Click);
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(511, 511);
            this._btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(100, 28);
            this._btnVolver.TabIndex = 15;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(204, 140);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(372, 24);
            this.cmbEmpleado.TabIndex = 16;
            // 
            // txtCodigoTransferencia
            // 
            this.txtCodigoTransferencia.Location = new System.Drawing.Point(311, 210);
            this.txtCodigoTransferencia.Name = "txtCodigoTransferencia";
            this.txtCodigoTransferencia.Size = new System.Drawing.Size(265, 22);
            this.txtCodigoTransferencia.TabIndex = 17;
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(432, 259);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(144, 24);
            this.cmbPeriodo.TabIndex = 18;
            // 
            // FrmIngresarLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 554);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.txtCodigoTransferencia);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnAgregar);
            this.Controls.Add(this.txtDescuentos);
            this.Controls.Add(this.txtbruto);
            this.Controls.Add(this.txtIDLIQUIDACIÓN);
            this.Controls.Add(this._lblDescuentos);
            this.Controls.Add(this._lblBruto);
            this.Controls.Add(this._lblPeriodo);
            this.Controls.Add(this._lblCodigoTransferencia);
            this.Controls.Add(this._lblLegajo);
            this.Controls.Add(this._lblId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmIngresarLiquidacion";
            this.Text = "FrmIngresarLiquidacion";
            this.Load += new System.EventHandler(this.FrmIngresarLiquidacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblId;
        private System.Windows.Forms.Label _lblLegajo;
        private System.Windows.Forms.Label _lblCodigoTransferencia;
        private System.Windows.Forms.Label _lblPeriodo;
        private System.Windows.Forms.Label _lblBruto;
        private System.Windows.Forms.Label _lblDescuentos;
        private System.Windows.Forms.TextBox txtIDLIQUIDACIÓN;
        private System.Windows.Forms.TextBox txtbruto;
        private System.Windows.Forms.TextBox txtDescuentos;
        private System.Windows.Forms.Button _btnAgregar;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.TextBox txtCodigoTransferencia;
        private System.Windows.Forms.ComboBox cmbPeriodo;
    }
}
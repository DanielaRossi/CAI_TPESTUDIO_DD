
namespace TPEstudio
{
    partial class FrmIngresarEmpleado
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
            this._lblApellido = new System.Windows.Forms.Label();
            this._FECHA = new System.Windows.Forms.Label();
            this._lblDni = new System.Windows.Forms.Label();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._txtApellido = new System.Windows.Forms.TextBox();
            this._txtLegajo = new System.Windows.Forms.TextBox();
            this._txtDni = new System.Windows.Forms.TextBox();
            this._btnAgregar = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Location = new System.Drawing.Point(91, 34);
            this._lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(58, 17);
            this._lblNombre.TabIndex = 0;
            this._lblNombre.Text = "Nombre";
            // 
            // _lblApellido
            // 
            this._lblApellido.AutoSize = true;
            this._lblApellido.Location = new System.Drawing.Point(91, 72);
            this._lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblApellido.Name = "_lblApellido";
            this._lblApellido.Size = new System.Drawing.Size(58, 17);
            this._lblApellido.TabIndex = 1;
            this._lblApellido.Text = "Apellido";
            // 
            // _FECHA
            // 
            this._FECHA.AutoSize = true;
            this._FECHA.Location = new System.Drawing.Point(91, 122);
            this._FECHA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._FECHA.Name = "_FECHA";
            this._FECHA.Size = new System.Drawing.Size(121, 17);
            this._FECHA.TabIndex = 2;
            this._FECHA.Text = "Fecha Nacimiento";
            // 
            // _lblDni
            // 
            this._lblDni.AutoSize = true;
            this._lblDni.Location = new System.Drawing.Point(91, 166);
            this._lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblDni.Name = "_lblDni";
            this._lblDni.Size = new System.Drawing.Size(38, 17);
            this._lblDni.TabIndex = 3;
            this._lblDni.Text = "CUIL";
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(206, 34);
            this._txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(132, 22);
            this._txtNombre.TabIndex = 4;
            // 
            // _txtApellido
            // 
            this._txtApellido.Location = new System.Drawing.Point(206, 72);
            this._txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._txtApellido.Name = "_txtApellido";
            this._txtApellido.Size = new System.Drawing.Size(132, 22);
            this._txtApellido.TabIndex = 5;
            // 
            // _txtLegajo
            // 
            this._txtLegajo.Location = new System.Drawing.Point(231, 122);
            this._txtLegajo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._txtLegajo.Name = "_txtLegajo";
            this._txtLegajo.Size = new System.Drawing.Size(132, 22);
            this._txtLegajo.TabIndex = 6;
            // 
            // _txtDni
            // 
            this._txtDni.Location = new System.Drawing.Point(231, 166);
            this._txtDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._txtDni.Name = "_txtDni";
            this._txtDni.Size = new System.Drawing.Size(132, 22);
            this._txtDni.TabIndex = 7;
            // 
            // _btnAgregar
            // 
            this._btnAgregar.Location = new System.Drawing.Point(184, 389);
            this._btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._btnAgregar.Name = "_btnAgregar";
            this._btnAgregar.Size = new System.Drawing.Size(100, 50);
            this._btnAgregar.TabIndex = 8;
            this._btnAgregar.Text = "Agregar";
            this._btnAgregar.UseVisualStyleBackColor = true;
            this._btnAgregar.Click += new System.EventHandler(this._btnAgregar_Click);
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(329, 389);
            this._btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(100, 50);
            this._btnVolver.TabIndex = 9;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "IdCategoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "IdEmpresa";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(242, 223);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoria.TabIndex = 12;
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(242, 296);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(121, 24);
            this.cmbEmpresa.TabIndex = 13;
            // 
            // FrmIngresarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 454);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnAgregar);
            this.Controls.Add(this._txtDni);
            this.Controls.Add(this._txtLegajo);
            this.Controls.Add(this._txtApellido);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._lblDni);
            this.Controls.Add(this._FECHA);
            this.Controls.Add(this._lblApellido);
            this.Controls.Add(this._lblNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmIngresarEmpleado";
            this.Text = "FrmIngresarEmpleado";
            this.Load += new System.EventHandler(this.FrmIngresarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Label _lblApellido;
        private System.Windows.Forms.Label _FECHA;
        private System.Windows.Forms.Label _lblDni;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.TextBox _txtApellido;
        private System.Windows.Forms.TextBox _txtLegajo;
        private System.Windows.Forms.TextBox _txtDni;
        private System.Windows.Forms.Button _btnAgregar;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbEmpresa;
    }
}
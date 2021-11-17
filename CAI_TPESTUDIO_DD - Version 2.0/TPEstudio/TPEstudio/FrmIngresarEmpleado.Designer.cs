
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
            this._lblLegajo = new System.Windows.Forms.Label();
            this._lblDni = new System.Windows.Forms.Label();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._txtApellido = new System.Windows.Forms.TextBox();
            this._txtLegajo = new System.Windows.Forms.TextBox();
            this._txtDni = new System.Windows.Forms.TextBox();
            this._btnAgregar = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Location = new System.Drawing.Point(73, 85);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(44, 13);
            this._lblNombre.TabIndex = 0;
            this._lblNombre.Text = "Nombre";
            // 
            // _lblApellido
            // 
            this._lblApellido.AutoSize = true;
            this._lblApellido.Location = new System.Drawing.Point(73, 119);
            this._lblApellido.Name = "_lblApellido";
            this._lblApellido.Size = new System.Drawing.Size(44, 13);
            this._lblApellido.TabIndex = 1;
            this._lblApellido.Text = "Apellido";
            // 
            // _lblLegajo
            // 
            this._lblLegajo.AutoSize = true;
            this._lblLegajo.Location = new System.Drawing.Point(73, 157);
            this._lblLegajo.Name = "_lblLegajo";
            this._lblLegajo.Size = new System.Drawing.Size(39, 13);
            this._lblLegajo.TabIndex = 2;
            this._lblLegajo.Text = "Legajo";
            // 
            // _lblDni
            // 
            this._lblDni.AutoSize = true;
            this._lblDni.Location = new System.Drawing.Point(73, 193);
            this._lblDni.Name = "_lblDni";
            this._lblDni.Size = new System.Drawing.Size(26, 13);
            this._lblDni.TabIndex = 3;
            this._lblDni.Text = "DNI";
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(163, 82);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(100, 20);
            this._txtNombre.TabIndex = 4;
            // 
            // _txtApellido
            // 
            this._txtApellido.Location = new System.Drawing.Point(163, 118);
            this._txtApellido.Name = "_txtApellido";
            this._txtApellido.Size = new System.Drawing.Size(100, 20);
            this._txtApellido.TabIndex = 5;
            // 
            // _txtLegajo
            // 
            this._txtLegajo.Location = new System.Drawing.Point(163, 154);
            this._txtLegajo.Name = "_txtLegajo";
            this._txtLegajo.Size = new System.Drawing.Size(100, 20);
            this._txtLegajo.TabIndex = 6;
            // 
            // _txtDni
            // 
            this._txtDni.Location = new System.Drawing.Point(163, 190);
            this._txtDni.Name = "_txtDni";
            this._txtDni.Size = new System.Drawing.Size(100, 20);
            this._txtDni.TabIndex = 7;
            // 
            // _btnAgregar
            // 
            this._btnAgregar.Location = new System.Drawing.Point(188, 237);
            this._btnAgregar.Name = "_btnAgregar";
            this._btnAgregar.Size = new System.Drawing.Size(75, 41);
            this._btnAgregar.TabIndex = 8;
            this._btnAgregar.Text = "Agregar";
            this._btnAgregar.UseVisualStyleBackColor = true;
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(247, 316);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(75, 41);
            this._btnVolver.TabIndex = 9;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // FrmIngresarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 369);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnAgregar);
            this.Controls.Add(this._txtDni);
            this.Controls.Add(this._txtLegajo);
            this.Controls.Add(this._txtApellido);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._lblDni);
            this.Controls.Add(this._lblLegajo);
            this.Controls.Add(this._lblApellido);
            this.Controls.Add(this._lblNombre);
            this.Name = "FrmIngresarEmpleado";
            this.Text = "FrmIngresarEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Label _lblApellido;
        private System.Windows.Forms.Label _lblLegajo;
        private System.Windows.Forms.Label _lblDni;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.TextBox _txtApellido;
        private System.Windows.Forms.TextBox _txtLegajo;
        private System.Windows.Forms.TextBox _txtDni;
        private System.Windows.Forms.Button _btnAgregar;
        private System.Windows.Forms.Button _btnVolver;
    }
}

namespace TPEstudio
{
    partial class FrmEmpleados
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
            this._btnIngresarNuevoEmpleado = new System.Windows.Forms.Button();
            this._btnConsultarEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(633, 352);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(103, 36);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // _btnIngresarNuevoEmpleado
            // 
            this._btnIngresarNuevoEmpleado.Location = new System.Drawing.Point(171, 176);
            this._btnIngresarNuevoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnIngresarNuevoEmpleado.Name = "_btnIngresarNuevoEmpleado";
            this._btnIngresarNuevoEmpleado.Size = new System.Drawing.Size(179, 76);
            this._btnIngresarNuevoEmpleado.TabIndex = 1;
            this._btnIngresarNuevoEmpleado.Text = "Ingresar nuevo empleado";
            this._btnIngresarNuevoEmpleado.UseVisualStyleBackColor = true;
            this._btnIngresarNuevoEmpleado.Click += new System.EventHandler(this._btnIngresarNuevoEmpleado_Click);
            // 
            // _btnConsultarEmpleado
            // 
            this._btnConsultarEmpleado.Location = new System.Drawing.Point(449, 176);
            this._btnConsultarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnConsultarEmpleado.Name = "_btnConsultarEmpleado";
            this._btnConsultarEmpleado.Size = new System.Drawing.Size(168, 76);
            this._btnConsultarEmpleado.TabIndex = 2;
            this._btnConsultarEmpleado.Text = "Consultar Empleado";
            this._btnConsultarEmpleado.UseVisualStyleBackColor = true;
            this._btnConsultarEmpleado.Click += new System.EventHandler(this._btnConsultarEmpleado_Click);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnConsultarEmpleado);
            this.Controls.Add(this._btnIngresarNuevoEmpleado);
            this.Controls.Add(this.btnVolver);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button _btnIngresarNuevoEmpleado;
        private System.Windows.Forms.Button _btnConsultarEmpleado;
    }
}
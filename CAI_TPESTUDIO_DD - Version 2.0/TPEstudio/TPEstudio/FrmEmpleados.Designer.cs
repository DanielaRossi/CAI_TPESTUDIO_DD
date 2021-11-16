
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
            this.btnVolver.Location = new System.Drawing.Point(475, 286);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(77, 29);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // _btnIngresarNuevoEmpleado
            // 
            this._btnIngresarNuevoEmpleado.Location = new System.Drawing.Point(128, 143);
            this._btnIngresarNuevoEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this._btnIngresarNuevoEmpleado.Name = "_btnIngresarNuevoEmpleado";
            this._btnIngresarNuevoEmpleado.Size = new System.Drawing.Size(134, 62);
            this._btnIngresarNuevoEmpleado.TabIndex = 1;
            this._btnIngresarNuevoEmpleado.Text = "Ingresar nuevo empleado";
            this._btnIngresarNuevoEmpleado.UseVisualStyleBackColor = true;
            // 
            // _btnConsultarEmpleado
            // 
            this._btnConsultarEmpleado.Location = new System.Drawing.Point(337, 143);
            this._btnConsultarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this._btnConsultarEmpleado.Name = "_btnConsultarEmpleado";
            this._btnConsultarEmpleado.Size = new System.Drawing.Size(126, 62);
            this._btnConsultarEmpleado.TabIndex = 2;
            this._btnConsultarEmpleado.Text = "Consultar Empleado";
            this._btnConsultarEmpleado.UseVisualStyleBackColor = true;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this._btnConsultarEmpleado);
            this.Controls.Add(this._btnIngresarNuevoEmpleado);
            this.Controls.Add(this.btnVolver);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
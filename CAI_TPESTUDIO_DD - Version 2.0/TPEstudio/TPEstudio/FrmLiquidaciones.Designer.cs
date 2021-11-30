
namespace TPEstudio
{
    partial class FrmLiquidaciones
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
            this._btnIngresarLiquidacion = new System.Windows.Forms.Button();
            this._btnConsultarLiquidacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(641, 354);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(87, 25);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // _btnIngresarLiquidacion
            // 
            this._btnIngresarLiquidacion.Location = new System.Drawing.Point(176, 182);
            this._btnIngresarLiquidacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnIngresarLiquidacion.Name = "_btnIngresarLiquidacion";
            this._btnIngresarLiquidacion.Size = new System.Drawing.Size(173, 71);
            this._btnIngresarLiquidacion.TabIndex = 1;
            this._btnIngresarLiquidacion.Text = "Ingresar liquidacion";
            this._btnIngresarLiquidacion.UseVisualStyleBackColor = true;
            this._btnIngresarLiquidacion.Click += new System.EventHandler(this._btnIngresarLiquidacion_Click);
            // 
            // _btnConsultarLiquidacion
            // 
            this._btnConsultarLiquidacion.Location = new System.Drawing.Point(460, 182);
            this._btnConsultarLiquidacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnConsultarLiquidacion.Name = "_btnConsultarLiquidacion";
            this._btnConsultarLiquidacion.Size = new System.Drawing.Size(173, 71);
            this._btnConsultarLiquidacion.TabIndex = 2;
            this._btnConsultarLiquidacion.Text = "Consultar Liquidacion";
            this._btnConsultarLiquidacion.UseVisualStyleBackColor = true;
            this._btnConsultarLiquidacion.Click += new System.EventHandler(this._btnConsultarLiquidacion_Click);
            // 
            // FrmLiquidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnConsultarLiquidacion);
            this.Controls.Add(this._btnIngresarLiquidacion);
            this.Controls.Add(this.btnVolver);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLiquidaciones";
            this.Text = "Liquidaciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button _btnIngresarLiquidacion;
        private System.Windows.Forms.Button _btnConsultarLiquidacion;
    }
}

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
            this.btnVolver.Location = new System.Drawing.Point(481, 288);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(65, 20);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // _btnIngresarLiquidacion
            // 
            this._btnIngresarLiquidacion.Location = new System.Drawing.Point(132, 148);
            this._btnIngresarLiquidacion.Margin = new System.Windows.Forms.Padding(2);
            this._btnIngresarLiquidacion.Name = "_btnIngresarLiquidacion";
            this._btnIngresarLiquidacion.Size = new System.Drawing.Size(130, 58);
            this._btnIngresarLiquidacion.TabIndex = 1;
            this._btnIngresarLiquidacion.Text = "Ingresar liquidacion";
            this._btnIngresarLiquidacion.UseVisualStyleBackColor = true;
            // 
            // _btnConsultarLiquidacion
            // 
            this._btnConsultarLiquidacion.Location = new System.Drawing.Point(345, 148);
            this._btnConsultarLiquidacion.Margin = new System.Windows.Forms.Padding(2);
            this._btnConsultarLiquidacion.Name = "_btnConsultarLiquidacion";
            this._btnConsultarLiquidacion.Size = new System.Drawing.Size(130, 58);
            this._btnConsultarLiquidacion.TabIndex = 2;
            this._btnConsultarLiquidacion.Text = "Consultar Liquidacion";
            this._btnConsultarLiquidacion.UseVisualStyleBackColor = true;
            // 
            // FrmLiquidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this._btnConsultarLiquidacion);
            this.Controls.Add(this._btnIngresarLiquidacion);
            this.Controls.Add(this.btnVolver);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
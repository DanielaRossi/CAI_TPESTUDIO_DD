﻿
namespace TPEstudio
{
    partial class FrmConsultarEmpresa
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
            this.button1 = new System.Windows.Forms.Button();
            this.lstEmpresas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadempresas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLiquidacion = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstEmpresas
            // 
            this.lstEmpresas.FormattingEnabled = true;
            this.lstEmpresas.ItemHeight = 16;
            this.lstEmpresas.Location = new System.Drawing.Point(55, 263);
            this.lstEmpresas.Name = "lstEmpresas";
            this.lstEmpresas.Size = new System.Drawing.Size(512, 148);
            this.lstEmpresas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad de empresas";
            // 
            // txtCantidadempresas
            // 
            this.txtCantidadempresas.Enabled = false;
            this.txtCantidadempresas.Location = new System.Drawing.Point(606, 130);
            this.txtCantidadempresas.Name = "txtCantidadempresas";
            this.txtCantidadempresas.Size = new System.Drawing.Size(120, 22);
            this.txtCantidadempresas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar empresa por id de liquidación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione un id de liquidación";
            // 
            // cmbLiquidacion
            // 
            this.cmbLiquidacion.FormattingEnabled = true;
            this.cmbLiquidacion.Location = new System.Drawing.Point(288, 93);
            this.cmbLiquidacion.Name = "cmbLiquidacion";
            this.cmbLiquidacion.Size = new System.Drawing.Size(121, 24);
            this.cmbLiquidacion.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Respuesta";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(288, 152);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(121, 22);
            this.txtRespuesta.TabIndex = 9;
            // 
            // FrmConsultarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbLiquidacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidadempresas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEmpresas);
            this.Controls.Add(this.button1);
            this.Name = "FrmConsultarEmpresa";
            this.Text = "FrmConsultarEmpresa";
            this.Load += new System.EventHandler(this.FrmConsultarEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstEmpresas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadempresas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLiquidacion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRespuesta;
    }
}
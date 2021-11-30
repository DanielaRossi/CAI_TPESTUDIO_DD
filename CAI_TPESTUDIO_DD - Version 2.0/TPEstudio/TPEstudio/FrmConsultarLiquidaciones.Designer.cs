
namespace TPEstudio
{
    partial class FrmConsultarLiquidaciones
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
            this.lstLiquidaciones = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLiquidacion = new System.Windows.Forms.ComboBox();
            this.lstLiquidacionporcategoria = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLiquidaciones
            // 
            this.lstLiquidaciones.FormattingEnabled = true;
            this.lstLiquidaciones.ItemHeight = 16;
            this.lstLiquidaciones.Location = new System.Drawing.Point(410, 69);
            this.lstLiquidaciones.Name = "lstLiquidaciones";
            this.lstLiquidaciones.Size = new System.Drawing.Size(366, 276);
            this.lstLiquidaciones.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultar Liquidación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el id de la liquidación";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(59, 145);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(299, 22);
            this.txtResultado.TabIndex = 4;
            this.txtResultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Todas las liquidaciones";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resultado de la consulta";
            // 
            // cmbLiquidacion
            // 
            this.cmbLiquidacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLiquidacion.FormattingEnabled = true;
            this.cmbLiquidacion.Location = new System.Drawing.Point(251, 55);
            this.cmbLiquidacion.Name = "cmbLiquidacion";
            this.cmbLiquidacion.Size = new System.Drawing.Size(121, 24);
            this.cmbLiquidacion.TabIndex = 9;
            // 
            // lstLiquidacionporcategoria
            // 
            this.lstLiquidacionporcategoria.FormattingEnabled = true;
            this.lstLiquidacionporcategoria.ItemHeight = 16;
            this.lstLiquidacionporcategoria.Location = new System.Drawing.Point(52, 322);
            this.lstLiquidacionporcategoria.Name = "lstLiquidacionporcategoria";
            this.lstLiquidacionporcategoria.Size = new System.Drawing.Size(320, 116);
            this.lstLiquidacionporcategoria.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seleccione una categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(251, 240);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoria.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmConsultarLiquidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstLiquidacionporcategoria);
            this.Controls.Add(this.cmbLiquidacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstLiquidaciones);
            this.Name = "FrmConsultarLiquidaciones";
            this.Text = "FrmConsultarLiquidaciones";
            this.Load += new System.EventHandler(this.FrmConsultarLiquidaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLiquidaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLiquidacion;
        private System.Windows.Forms.ListBox lstLiquidacionporcategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button button3;
    }
}
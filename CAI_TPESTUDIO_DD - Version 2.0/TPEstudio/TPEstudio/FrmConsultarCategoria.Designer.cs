
namespace TPEstudio
{
    partial class FrmConsultarCategoria
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
            this.lstCategoria = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLiquidación = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstCategoria
            // 
            this.lstCategoria.FormattingEnabled = true;
            this.lstCategoria.ItemHeight = 16;
            this.lstCategoria.Location = new System.Drawing.Point(54, 294);
            this.lstCategoria.Name = "lstCategoria";
            this.lstCategoria.Size = new System.Drawing.Size(456, 116);
            this.lstCategoria.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de todas las categorías";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consultar categoria por id de liquidación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seleccione el id de la liquidación";
            // 
            // cmbLiquidación
            // 
            this.cmbLiquidación.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLiquidación.FormattingEnabled = true;
            this.cmbLiquidación.Location = new System.Drawing.Point(322, 81);
            this.cmbLiquidación.Name = "cmbLiquidación";
            this.cmbLiquidación.Size = new System.Drawing.Size(121, 24);
            this.cmbLiquidación.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(184, 139);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(397, 22);
            this.txtResultado.TabIndex = 8;
            // 
            // FrmConsultarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbLiquidación);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstCategoria);
            this.Name = "FrmConsultarCategoria";
            this.Text = "FrmConsultarCategoria";
            this.Load += new System.EventHandler(this.FrmConsultarCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLiquidación;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
    }
}
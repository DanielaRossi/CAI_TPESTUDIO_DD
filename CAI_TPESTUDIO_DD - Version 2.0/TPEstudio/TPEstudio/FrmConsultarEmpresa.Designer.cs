
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
            // FrmConsultarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPEstudio
{
    public partial class FrmEmpresas : Form
    {

        private FrmIngresarNuevaEmpresa _frmIngresarNuevaEmpresa;
        public FrmEmpresas(Form propietario)
        {
            this.Owner= propietario;
            InitializeComponent();
            _frmIngresarNuevaEmpresa = new FrmIngresarNuevaEmpresa();
            _frmIngresarNuevaEmpresa.Owner = this;
        }

        private void FrmEmpresas_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
            
        }

        private void _btnIngresarEmpresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmIngresarNuevaEmpresa.Show();
        }
    }
}

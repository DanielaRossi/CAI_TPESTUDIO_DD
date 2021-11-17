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
    public partial class FrmLiquidaciones : Form
    {
        private FrmIngresarLiquidacion _frmIngresarLiquidacion;
        public FrmLiquidaciones(Form propietario)
        {
            this.Owner = propietario;
            InitializeComponent();
            _frmIngresarLiquidacion = new FrmIngresarLiquidacion();
            _frmIngresarLiquidacion.Owner = this;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void _btnIngresarLiquidacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmIngresarLiquidacion.Show();


        }
    }
}

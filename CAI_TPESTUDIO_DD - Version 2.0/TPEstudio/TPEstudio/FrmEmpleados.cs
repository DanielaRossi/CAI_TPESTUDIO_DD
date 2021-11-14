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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados(Form propietario)
        {
            InitializeComponent();
            this.Owner = propietario;
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }
    }
}

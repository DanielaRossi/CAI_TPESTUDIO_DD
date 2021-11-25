using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPEstudio.Entidades;
using TPEstudio.Negocio;

namespace TPEstudio
{
    public partial class FrmConsultarEmpresa : Form
    {
        private EmpresaNegocio _empresaNegocio;
        public FrmConsultarEmpresa(Form propietario)
        {
            InitializeComponent();
            this.Owner = propietario;
            _empresaNegocio = new EmpresaNegocio();
        }

        private void FrmConsultarEmpresa_Load(object sender, EventArgs e)
        {
            lstEmpresas.DataSource = null;
            lstEmpresas.DataSource = _empresaNegocio.TraerTodas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }
    }
}

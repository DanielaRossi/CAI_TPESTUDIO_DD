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
        //private OperadorEmpresas _operadorEmpresa;
        private LiquidacionesNegocio _liquidacionesNegocio;
        private List<Empresa> _empresas;
        public FrmConsultarEmpresa(Form propietario)
        {
            InitializeComponent();
            this.Owner = propietario;
            _empresaNegocio = new EmpresaNegocio();
            _liquidacionesNegocio = new LiquidacionesNegocio();
            
            //_operadorEmpresa = new OperadorEmpresas(_empresas);
        }

        private void FrmConsultarEmpresa_Load(object sender, EventArgs e)
        {
            _empresas = _empresaNegocio.TraerTodas();
            lstEmpresas.DataSource = null;
            lstEmpresas.DataSource = _empresas;
            
            CargarDatos();
            CargarCombo();

        }
        private void CargarCombo()
        {
            cmbLiquidacion.DataSource = null;
            cmbLiquidacion.DataSource = _liquidacionesNegocio.TraerTodas();
            //cmbLiquidacion.DisplayMember = "Mostrar";
            cmbLiquidacion.DisplayMember = "Detalledeliquidacionsinempresa";
            cmbLiquidacion.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Owner.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void CargarDatos()
        {
            OperadorEmpresas _operadorEmpresa = new OperadorEmpresas(_empresas);
            txtCantidadempresas.Text = _operadorEmpresa.Cantidad.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Liquidaciones l = (Liquidaciones)cmbLiquidacion.SelectedItem;
                
                List<Liquidaciones> lst = _liquidacionesNegocio.TraerTodas();


                foreach (Liquidaciones liq in lst)
                {
                    if (liq.Empleados.Empresas.Id.Equals(l.Empleados.Empresas.Id))
                    {

                        txtRespuesta.Text = liq.Empleados.Empresas.RazonSocial.ToString();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

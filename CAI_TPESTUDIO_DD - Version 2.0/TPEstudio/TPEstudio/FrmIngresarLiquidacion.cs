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
using TPEstudio.Entidades.Enums;
using TPEstudio.Negocio;
using ConsolaUtils;

namespace TPEstudio
{
    public partial class FrmIngresarLiquidacion : Form
    {
        private EmpleadoNegocio _empleadoNegocio;
        private LiquidacionesNegocio liquidacionesNegocio;
        private List<Empleado> _empleados;
        public FrmIngresarLiquidacion()
        {
            InitializeComponent();
            _empleadoNegocio = new EmpleadoNegocio();
            _empleados = new List<Empleado>();
            liquidacionesNegocio = new LiquidacionesNegocio();
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                this.Owner.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void FrmIngresarLiquidacion_Load(object sender, EventArgs e)
        {
            Cargarcombos();
        }
        private void Cargarcombos()
        {
            List<Empleado> Empleadolst = _empleadoNegocio.TraerTodos();
            Empleadolst.Insert(0, new Empleado(null,0, 0, 0, "--Seleccione--", "", DateTime.Now));
            
            cmbEmpleado.DataSource = null;
            cmbEmpleado.DataSource = Empleadolst;
            cmbEmpleado.DisplayMember = "ToString";
            
            cmbPeriodo.DataSource = Enum.GetValues(typeof(PeriodoEnum));
        }

        private void _btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigotransferencia = txtCodigoTransferencia.Text;
                Validaciones.ValidarVacio(codigotransferencia,"Codigo de transferencia");
                double bruto = 0;


                Validaciones.ValidarDouble(txtbruto.Text, ref bruto);
                double descuento = 0;
                Validaciones.ValidarDouble(txtDescuentos.Text, ref descuento);

                PeriodoEnum periodo = (PeriodoEnum)cmbPeriodo.SelectedIndex;
                
                Empleado empleado = (Empleado)cmbEmpleado.SelectedItem;

                liquidacionesNegocio.Alta(empleado, empleado.Id,(int)periodo,codigotransferencia, bruto,descuento);
                Limpiar();
                MessageBox.Show("La liquidación se agregó con exito");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Limpiar()
        {
            txtCodigoTransferencia.Clear();
            txtbruto.Clear();
            txtDescuentos.Clear();
            txtIDLIQUIDACIÓN.Clear();
            cmbPeriodo.SelectedIndex = 0;
            cmbEmpleado.SelectedIndex = 0;
            
            
        }
    }
}

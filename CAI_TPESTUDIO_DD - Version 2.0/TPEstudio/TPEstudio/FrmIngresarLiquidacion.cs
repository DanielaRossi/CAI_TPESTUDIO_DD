﻿using System;
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

namespace TPEstudio
{
    public partial class FrmIngresarLiquidacion : Form
    {
        private EmpleadoNegocio _empleadoNegocio;
        private LiquidacionesNegocio liquidacionesNegocio;
        public FrmIngresarLiquidacion()
        {
            InitializeComponent();
            _empleadoNegocio = new EmpleadoNegocio();
            liquidacionesNegocio = new LiquidacionesNegocio();
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            
        }

        private void FrmIngresarLiquidacion_Load(object sender, EventArgs e)
        {
            Cargarcombos();
        }
        private void Cargarcombos()
        {
            cmbEmpleado.DataSource = null;
            cmbEmpleado.DataSource = _empleadoNegocio.TraerTodos();
            cmbPeriodo.DataSource = Enum.GetValues(typeof(PeriodoEnum));
        }

        private void _btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigotransferencia = 0;
                Validaciones.ValidarInt(txtCodigoTransferencia.Text, ref codigotransferencia);
                double bruto = 0;


                Validaciones.ValidarDouble(txtbruto.Text, ref bruto);
                double descuento = 0;
                Validaciones.ValidarDouble(txtDescuentos.Text, ref descuento);

                PeriodoEnum periodo = (PeriodoEnum)cmbPeriodo.SelectedIndex;
                
                Empleado empleado = (Empleado)cmbEmpleado.SelectedItem;

                liquidacionesNegocio.Alta(empleado.Id,(int)periodo,codigotransferencia, bruto,descuento);
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
            
            
        }
    }
}

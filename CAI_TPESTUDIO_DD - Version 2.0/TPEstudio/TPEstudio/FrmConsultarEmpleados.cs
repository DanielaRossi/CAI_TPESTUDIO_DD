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
using TPEstudio.Negocio;

namespace TPEstudio
{
    public partial class FrmConsultarEmpleados : Form
    {
        private EmpleadoNegocio _empleadoNegocio;
        private LiquidacionesNegocio _liquidacionesNegocio;
        private List<Empleado> _empleados;
        private List<Liquidaciones> _listaliquidaciones;
        private EmpresaNegocio _empresaNegocio;
        private List<Empresa> _empresas;
        public FrmConsultarEmpleados(Form propietario)
        {
            InitializeComponent();
            _empleadoNegocio = new EmpleadoNegocio();
            this.Owner = propietario;
            _liquidacionesNegocio = new LiquidacionesNegocio();
            _empresaNegocio = new EmpresaNegocio();
        }

        private void FrmConsultarEmpleados_Load(object sender, EventArgs e)
        {
            CargarLista();
            CargarCombo();

        }
        private void CargarLista()
        {
            lstEmpleados.DataSource = null;
            lstEmpleados.DataSource = _empleadoNegocio.TraerTodos();
            cmbEmpresa.DataSource = null;
            cmbEmpresa.DataSource = _empresaNegocio.TraerTodas();
            cmbEmpresa.DisplayMember = "RazonSocial";
            cmbEmpresa.ValueMember = "Cuit";
        }
        private void CargarCombo()
        {
            cmbLiquidacion.DataSource = null;
            cmbLiquidacion.DataSource = _liquidacionesNegocio.TraerTodas();
            cmbLiquidacion.DisplayMember = "Id";
            cmbLiquidacion.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _listaliquidaciones = _liquidacionesNegocio.TraerTodas();
            //    _empleados = _empleadoNegocio.TraerTodos();
            //    foreach (Liquidaciones l in _listaliquidaciones)
            //    {
            //        if (l.IdEmpleado == cmbLiquidacion.SelectedIndex)
            //        {
            //            foreach (Empleado em in _empleados)
            //            {
            //                if (em.IdEmpleado == l.IdEmpleado)
            //                {
            //                    txtResultado.Text = em.ToString();
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            try
            {
                _listaliquidaciones = _liquidacionesNegocio.TraerTodas();
                _empleados = _empleadoNegocio.TraerTodos();
                foreach (Liquidaciones l in _listaliquidaciones)
                {
                    if (l.Id == cmbLiquidacion.SelectedIndex)
                    {
                        foreach (Empleado em in _empleados)
                        {
                            if (em.IdEmpleado == l.IdEmpleado)
                            {
                                txtResultado.Text = em.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                _listaliquidaciones = _liquidacionesNegocio.TraerTodas();
                _empresas = _empresaNegocio.TraerTodas();
                foreach (Liquidaciones l in _listaliquidaciones)
                {
                    if (l.Id == cmbLiquidacion.SelectedIndex)
                    {
                        foreach (Empleado em in _empleados)
                        {
                            if (em.IdEmpleado == l.IdEmpleado)
                            {
                                foreach(Empresa a in _empresas)
                                {
                                    if(a.Id == em.IdEmpresa)
                                    {
                                        
                                    }
                                }
                                
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

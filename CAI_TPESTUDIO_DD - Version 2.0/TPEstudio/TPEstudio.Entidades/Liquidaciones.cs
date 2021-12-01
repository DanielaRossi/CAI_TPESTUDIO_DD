﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEstudio.Entidades
{
    public class Liquidaciones
    {
        private int _id;
        private int _idEmpleado;
        private string _codigoTransferencia;
        private int _periodo;
        private double _bruto;
        private double _descuentos;
        private DateTime _fechaAlta;

        public Liquidaciones( int idEmpleado, string codigoTransferencia, int periodo, double bruto, double descuentos)
        {
            
            _idEmpleado = idEmpleado;
            _codigoTransferencia = codigoTransferencia;
            _periodo = periodo;
            _bruto = bruto;
            _descuentos = descuentos;
            
        }

        public int Id { get => _id; set => _id = value; }
        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public string CodigoTransferencia { get => _codigoTransferencia; set => _codigoTransferencia = value; }
        public int Periodo { get => _periodo; set => _periodo = value; }
        public double Bruto { get => _bruto; set => _bruto = value; }
        public double Descuentos { get => _descuentos; set => _descuentos = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }

        public override string ToString()
        {
            return $"{this.Id}) Id del empleado:{this.IdEmpleado}-Codigo Transferencia{this.CodigoTransferencia}";
        }
        public string Mostrar 
        { get
            {
                return $"{this.Id}) Id del empleado:{this.IdEmpleado}-Codigo Transferencia{this.CodigoTransferencia}";
            }
        } 
        }
    }


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Venta
    {
        public Cliente cliente { set; get; }
        public Administrativo administrativo { set; get; }
        public TipoComprobante tipoComprobante { set; get; }
        public TipoPago tipoPago { set; get; }
        public String fechaRegistro { set; get; }
        public Servicio servicio { set; get; }
        public double montoTotal { set; get; }

        public Venta(Cliente cliente, Administrativo administrativo, TipoComprobante tipoComprobante, TipoPago tipoPago, String fechaRegistro, Servicio servicio)
        {
            this.cliente = cliente;
            this.administrativo = administrativo;
            this.tipoComprobante = tipoComprobante;
            this.tipoPago = tipoPago;
            this.fechaRegistro = fechaRegistro;
            this.servicio = servicio;

        }

        public Venta()
        {

        }

    }
}

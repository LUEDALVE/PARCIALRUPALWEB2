﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun;
using System.Data;

namespace AccesoDato
{
    public class ClienteDao
    {
       public List<Venta> ListarVenta()
        {
            List<Venta> ventas = new List<Venta>();
            Data data = new Data();
            string vSql = @"
                SELECT 
                    Id, 
                    IdCliente, 
                FROM 
                    Factura";
            DataTable dt = data.CargarDt(vSql, CommandType.Text);
            foreach (DataRow dr in dt.Rows)
            {
                Venta venta = new Venta
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    IdCliente = Convert.ToInt32(dr["IdCliente"]),
                };
                ventas.Add(venta);
            }
            return ventas;
        }
    }
}

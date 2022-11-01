using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Facturas
    {
        public int ID_Factura { get; set; }
        public float importeTotal { get; set; }
        public string descripcionFactura { get; set; }
        public int ID_Cliente;
        public int ID_cobrosReparaciones;
        public int ID_Venta;
        

    }
}

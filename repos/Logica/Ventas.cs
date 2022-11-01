using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Ventas
    {
        public int ID_Venta { get; set; }
        public string descripcionVenta { get; set; }
        public string fechaVenta { get; set; }
        public int importeVenta { get; set; }

        public int idComprador { get; set; }

        public int ID_Reserva;

    }
}

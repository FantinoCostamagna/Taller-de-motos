using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Reservas
    {
        public int ID_Reserva { get; set;  }
        public string fechaReserva { get; set; }
        public int ID_Articulo;
        public int ID_Vendedor;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class informeReparaciones
    {
        public int ID_informeReparacion { get; set;  }
        public float importeReparacion { get; set; }
        public string detalleReparacion { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Moto;
        public int ID_Mecanico;

    }
}

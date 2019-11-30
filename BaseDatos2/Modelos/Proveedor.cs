using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos2.Modelos
{
    public class Proveedor
    {
        public int IDProveedor { get; set; }
        public String RFC { get; set; }
        public String NombreProveedor { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}

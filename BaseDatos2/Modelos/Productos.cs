using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos2.Modelos
{
    public class Productos
    {
        public int IDProducto { get; set; }
        public String NombreProducto { get; set; }
        public bool Activo { get; set; }
        public int Existencia { get; set; }
        public double Precio { get; set; }
    }
}

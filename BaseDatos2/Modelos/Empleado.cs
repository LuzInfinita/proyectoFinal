using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos2.Modelos
{
    public class Empleado
    {
        public int IDEmpleado { get; set; } // Propiedades
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public bool Activo { get; set; }
        public double Salario { get; set; }
        public DateTime FechaIngreso { get; set; }

    }
}

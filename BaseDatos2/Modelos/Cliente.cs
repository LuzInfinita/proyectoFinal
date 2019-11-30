using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos2.Modelos
{
    public class Cliente
    {
        public int IDCliente { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public bool Activo { get; set; }
        public double Salario { get; set; }
        public int NumeroHijos { get; set; }
    }
}

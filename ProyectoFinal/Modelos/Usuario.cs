using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelos
{
    public class Usuario
    {
        public int IDUsuario { get; set; }

        public String Correo { get; set; } //varchar(100)

        public String Contrasena { get; set; } //varchar(16)

        public bool Activo { get; set; }

        public bool Premium { get; set; }

        public DateTime FechaHoraRegistro { get; set; }
    }
}

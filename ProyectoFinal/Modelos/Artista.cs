using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelos
{
    public class Artista
    {
       public int IDArtista { get; set; } 

       public String NombreArtista { get; set; } //varchar(50)

       public bool Activo { get; set; }
    }
}

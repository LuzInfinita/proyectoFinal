using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelos
{
    public class Album
    {
       public int IDAlbum { get; set; }

       public String NombreAlbum { get; set; }

       public DateTime FechaLanzamiento { get; set; }

       public int NumeroCanciones { get; set; }
    }
}

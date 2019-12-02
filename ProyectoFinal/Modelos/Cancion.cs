using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelos
{
    public class Cancion
    {
        public int IDCancion { get; set; }

        public int IDGenero { get; set; } 

        public int IDAlbum { get; set; }

        public int IDArtista { get; set; } //Creo que esta variable no debería estar declarada en esta clase, sino traerla de "Artista". Lo mismo pasa con "Genero". PEROOO, quizás sea mejor dejarlo asi y relacionarlo en algun método.

        public String NombreCancion { get; set; } //varchar(100)

        public int DuracionSegundos { get; set; }

        public DateTime FechaCreacion { get; set; } 
    }
}

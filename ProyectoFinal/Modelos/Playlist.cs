using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelos
{
    public class Playlist
    {
        public int IDPlaylist { get; set; }

        public int IDUsuario { get; set; }

        public String NombrePlaylist { get; set; } //varchar(50)

    }
}

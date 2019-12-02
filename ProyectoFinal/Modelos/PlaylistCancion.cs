using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelos
{
    public class PlaylistCancion
    {
        public int IDPlaylistCancion { get; set; }

        public int IDPlaylist { get; set; }

        public int IDCancion { get; set; }

        public DateTime FechaHoraCreacion { get; set; }
    }
}

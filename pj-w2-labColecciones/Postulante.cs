using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj_w2_labColecciones
{
    internal class Postulante
    {
        // Dni , apellidos, nombres, email y la edad
        public string dni { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public string email { get; set; }
        public DateTime fechaNac { get; set; }
    }
}

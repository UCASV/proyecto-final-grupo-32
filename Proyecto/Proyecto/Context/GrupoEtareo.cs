using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Context
{
    public partial class GrupoEtareo
    {
        public GrupoEtareo()
        {
            Ciudadanos = new HashSet<Ciudadano>();
        }

        public int IdEtareo { get; set; }
        public string Descripcion { get; set; }
        public int? EdadMinima { get; set; }
        public DateTime? Vigencia { get; set; }

        public virtual ICollection<Ciudadano> Ciudadanos { get; set; }
    }
}

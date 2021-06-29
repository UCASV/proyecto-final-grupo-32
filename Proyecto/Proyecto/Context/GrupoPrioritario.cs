using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Context
{
    public partial class GrupoPrioritario
    {
        public GrupoPrioritario()
        {
            Ciudadanos = new HashSet<Ciudadano>();
        }

        public int IdPrioritario { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Ciudadano> Ciudadanos { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Context
{
    public partial class InstitucionEsencial
    {
        public InstitucionEsencial()
        {
            Ciudadanos = new HashSet<Ciudadano>();
        }

        public int IdInstitucional { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Ciudadano> Ciudadanos { get; set; }
    }
}

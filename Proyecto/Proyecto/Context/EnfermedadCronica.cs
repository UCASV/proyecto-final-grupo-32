using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Context
{
    public partial class EnfermedadCronica
    {
        public EnfermedadCronica()
        {
            Ciudadanos = new HashSet<Ciudadano>();
        }

        public int IdEnfermedadCronica { get; set; }
        public string Enfermedad { get; set; }

        public virtual ICollection<Ciudadano> Ciudadanos { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Context
{
    public partial class EfectoSecundario
    {
        public EfectoSecundario()
        {
            Citaxefectos = new HashSet<Citaxefecto>();
        }

        public int IdEfecto { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Citaxefecto> Citaxefectos { get; set; }
    }
}

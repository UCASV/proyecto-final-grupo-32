using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Context
{
    public partial class Citaxefecto
    {
        public int IdCitaxefecto { get; set; }
        public int? IdCita { get; set; }
        public int? IdEfecto { get; set; }
        public TimeSpan? Tiempo { get; set; }

        public virtual Citum IdCitaNavigation { get; set; }
        public virtual EfectoSecundario IdEfectoNavigation { get; set; }
    }
}

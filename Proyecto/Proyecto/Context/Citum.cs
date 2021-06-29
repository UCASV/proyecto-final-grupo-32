using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Context
{
    public partial class Citum
    {
        public Citum()
        {
            Citaxcabinas = new HashSet<Citaxcabina>();
            Citaxefectos = new HashSet<Citaxefecto>();
        }

        public int IdCita { get; set; }
        public string Estado { get; set; }
        public DateTime? Fecha { get; set; }
        public string Lugar { get; set; }
        public string TipoVacuna { get; set; }
        public string Dosis { get; set; }
        public string Consentimiento { get; set; }
        public int? IdCiudadano { get; set; }

        public virtual Ciudadano IdCiudadanoNavigation { get; set; }
        public virtual ICollection<Citaxcabina> Citaxcabinas { get; set; }
        public virtual ICollection<Citaxefecto> Citaxefectos { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Context
{
    public partial class Telefono
    {
        public int IdTelefono { get; set; }
        public int? Telefono1 { get; set; }
        public int? IdCiudadano { get; set; }

        public virtual Ciudadano IdCiudadanoNavigation { get; set; }
    }
}

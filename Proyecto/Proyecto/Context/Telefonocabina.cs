using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Context
{
    public partial class Telefonocabina
    {
        public int IdTelefonocabina { get; set; }
        public string Telefono { get; set; }
        public int? IdCabina { get; set; }

        public virtual Cabina IdCabinaNavigation { get; set; }
    }
}

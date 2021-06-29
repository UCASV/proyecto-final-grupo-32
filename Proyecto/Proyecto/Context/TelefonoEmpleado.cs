using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Context
{
    public partial class TelefonoEmpleado
    {
        public int IdTelefonoempleado { get; set; }
        public string Telefono { get; set; }
        public int? IdEmpleado { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; }
    }
}

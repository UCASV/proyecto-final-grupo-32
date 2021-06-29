using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Context
{
    public partial class Cabina
    {
        public Cabina()
        {
            Citaxcabinas = new HashSet<Citaxcabina>();
            Telefonocabinas = new HashSet<Telefonocabina>();
        }

        public int IdCabina { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Encargado { get; set; }
        public int? IdEmpleado { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual ICollection<Citaxcabina> Citaxcabinas { get; set; }
        public virtual ICollection<Telefonocabina> Telefonocabinas { get; set; }
    }
}

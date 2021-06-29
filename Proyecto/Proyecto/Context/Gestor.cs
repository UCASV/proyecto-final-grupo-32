using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Context
{
    public partial class Gestor
    {
        public Gestor()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int IdGestor { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public int? IdRol { get; set; }

        public virtual Rol IdRolNavigation { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}

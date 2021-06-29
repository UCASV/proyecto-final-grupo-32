using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Context
{
    public partial class Empleado
    {
        public Empleado()
        {
            Cabinas = new HashSet<Cabina>();
            TelefonoEmpleados = new HashSet<TelefonoEmpleado>();
        }

        public int IdEmpleado { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public int? IdGestor { get; set; }

        public virtual Gestor IdGestorNavigation { get; set; }
        public virtual ICollection<Cabina> Cabinas { get; set; }
        public virtual ICollection<TelefonoEmpleado> TelefonoEmpleados { get; set; }
    }
}

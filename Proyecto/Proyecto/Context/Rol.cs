using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Context
{
    public partial class Rol
    {
        public Rol()
        {
            Gestors = new HashSet<Gestor>();
        }

        public int IdRol { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Gestor> Gestors { get; set; }
    }
}

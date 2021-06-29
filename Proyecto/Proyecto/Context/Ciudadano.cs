using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Context
{
    public partial class Ciudadano
    {
        public Ciudadano()
        {
            Cita = new HashSet<Citum>();
        }

        public int IdCiudadano { get; set; }
        public string Dui { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public int? Edad { get; set; }
        public string Telefono { get; set; }
        public string Enfermedad { get; set; }
        public bool? Etario { get; set; }
        public string Institucion { get; set; }

        public virtual ICollection<Citum> Cita { get; set; }
    }
}

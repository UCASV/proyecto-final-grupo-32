using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto.Context
{
    public partial class HistorialLogin
    {
        public int IdHistorial { get; set; }
        public DateTime? FechaHora { get; set; }
        public string Usuario { get; set; }
        public string Descripcion { get; set; }
        public string Evento { get; set; }
        public string Modulo { get; set; }
        public string Tabla { get; set; }
    }
}

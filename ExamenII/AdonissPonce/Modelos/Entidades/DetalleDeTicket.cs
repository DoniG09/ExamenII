using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Modelos.Entidades
{
    class DetalleDeTicket
    {
        public int Id { get; set; }
        public string SoporteRequeridoElegido { get; set; }
        public string NombreDueñoDelTicket { get; set; }
        public int NumeroDelTicket { get; set; }
        public string EstadoDelTicket { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Modelos.Entidades
{
    public class Ticket
    {
        public int Id { get; set; }
        public string NombreDueño { get; set; }
        public string EstadoTicket{ get; set; }
        public int NumeroTicket { get; set; }
}
}

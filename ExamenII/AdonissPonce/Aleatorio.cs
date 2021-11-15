using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Aleatorio
    {
        static void EstadoTicket()
        {
#pragma warning disable SecurityIntelliSenseCS // MS Security rules violation
            Random ran = new Random();
#pragma warning restore SecurityIntelliSenseCS // MS Security rules violation

            int numero = ran.Next(1, 5);
        }
    }
}

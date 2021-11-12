using System;
using System.Collections.Generic;
using System.Data.SqlClient;//Biblioteca que permite conectarse a SQL
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; //Para aceeder al archivo de configuración

namespace POO.Modelos.DAO
{
    public class Conexion
    {
        //Para acceder a la conexión
        protected SqlConnection MiConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ExamenIIAdoniss"].ConnectionString);
    }
}

using POO.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Modelos.DAO
{
    public class TicketDAO:Conexion
    {
        //Se crea un comando global para no instanciar diversos comandos en cada método
        SqlCommand comando = new SqlCommand();
        public bool NuevoTicket(Ticket creacionTicket)
        {

            //Método para validar el usuario
            try
            {
                StringBuilder sql = new StringBuilder(); //Permite agregar una consulta SQL
                sql.Append(" INSERT INTO Ticket (Numero) VALUES (@NumeroTicket)");

                comando.Connection = MiConexion; //Comando declarado en la clase conexión
                MiConexion.Open(); //Se abre la conexión a la base de datos
                comando.CommandType = System.Data.CommandType.Text; //Tipo de comando que se va a ejecutar
                comando.CommandText = sql.ToString(); //Se manda la sentencia SQL

                //=================================================================
                //Agrega los parámetros ingresados en el Append con su tipo de Dato
                //ingresado en la columna
                //Éste parámetro captura el nombre  ingresado a la aplicación
                comando.Parameters.Add("@NumeroTicket", SqlDbType.Int).Value = creacionTicket.NumeroTicket;
                //================================================================= 
                comando.ExecuteNonQuery();
                return true;
#pragma warning disable CS0162 // Se detectó código inaccesible
                MiConexion.Close();
#pragma warning restore CS0162 // Se detectó código inaccesible
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ValidarTicket(Ticket creacionTicket)
        {
            bool valido = false;

            try //Evita que si la aplicación tiene un error no se rompa
            {
                StringBuilder sql = new StringBuilder(); //Permite agregar una consulta SQL
                sql.Append(" SELECT 1 FROM Ticket WHERE Numero= @NumeroTicket;");

                comando.Connection = MiConexion; //Comando declarado en la clase conexión
                MiConexion.Open(); //Se abre la conexión a la base de datos
                comando.CommandType = System.Data.CommandType.Text; //Tipo de comando que se va a ejecutar
                comando.CommandText = sql.ToString(); //Se manda la sentencia SQL

                //=================================================================
                //Agrega los parámetros ingresados en el Append con su tipo de Dato
                //ingresado en la columna
                //Éste parámetro captura el número de ticket ingresado a la aplicación
                comando.Parameters.Add("@NumeroTicket", SqlDbType.Int).Value = creacionTicket.NumeroTicket;
                //================================================================= 
                valido = Convert.ToBoolean(comando.ExecuteScalar());
                MiConexion.Close();

            }
            catch (Exception)
            {
            }
            return valido;
        }

        public DataTable GetTicket()
        {
            DataTable columna = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder(); //Permite agregar una consulta SQL
                sql.Append("SELECT * FROM Ticket");

                comando.Connection = MiConexion; //Comando declarado en la clase conexión
                MiConexion.Open(); //Se abre la conexión a la base de datos
                comando.CommandType = System.Data.CommandType.Text; //Tipo de comando que se va a ejecutar
                comando.CommandText = sql.ToString(); //Se manda la sentencia SQL
                SqlDataReader reader = comando.ExecuteReader();
                columna.Load(reader);
                MiConexion.Close();
            }
            catch (Exception)
            {

            }
            return columna;
        }

        private SqlDataReader LeerFilas;

        public DataTable ListarTickets()
        {
            DataTable tabla = new DataTable();

            comando.Connection = MiConexion; //Comando declarado en la clase conexión
            MiConexion.Open(); //Se abre la conexión a la base de datos
            comando.CommandText = "ListarTickets";
            comando.CommandType = CommandType.StoredProcedure; //Tipo de comando que se va a ejecutar

            LeerFilas = comando.ExecuteReader();
            tabla.Load(LeerFilas);
            LeerFilas.Close();
            MiConexion.Close();

            return tabla;
        }

    }
}

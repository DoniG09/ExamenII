using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Modelos.Entidades; //Para poder usar la clase usuario en la carpeta "Entidades"
using POO.Modelos.DAO;
using System.Data;
using System.Data.SqlClient;

namespace POO.Modelos.DAO
{
    class DetalleTicketDAO : Conexion
    {
        //Se crea un comando global para no instanciar diversos comandos en cada método
        SqlCommand comando = new SqlCommand();
        public void InsertarDetalle(string idEstado, string idPropietario, int idNumero, string idTipoSoporte)
        {
            comando.Connection = MiConexion; //Comando declarado en la clase conexión
            MiConexion.Open(); //Se abre la conexión a la base de datos
            comando.CommandText = "InsertarEstado";
            comando.CommandType = CommandType.StoredProcedure; //Tipo de comando que se va a ejecutar

            comando.Parameters.AddWithValue("@IdEstado", idEstado);
            comando.Parameters.AddWithValue("@IdPropietario", idPropietario);
            comando.Parameters.AddWithValue("@IdNumero", idNumero);
            comando.Parameters.AddWithValue("@IdTipoSoporte", idTipoSoporte);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public DataTable GetDetalles()
        {
            DataTable columna = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder(); //Permite agregar una consulta SQL
                sql.Append("SELECT * FROM DetalleTicket");

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

        public bool LlenarDetalle(DetalleDeTicket detalleGenerado)
        {

            //Método para validar el usuario
            try
            {
                StringBuilder sql = new StringBuilder(); //Permite agregar una consulta SQL
                sql.Append(" INSERT INTO DetalleTicket (Estado, Propietario, NumeroTicket, " +
                    "TipoSoporte) VALUES (@EstadoDelTicket, @NombreDueñoDelTicket, " +
                    "@NumeroDelTicket, @)SoporteRequeridoElegido");

                comando.Connection = MiConexion; //Comando declarado en la clase conexión
                MiConexion.Open(); //Se abre la conexión a la base de datos
                comando.CommandType = System.Data.CommandType.Text; //Tipo de comando que se va a ejecutar
                comando.CommandText = sql.ToString(); //Se manda la sentencia SQL

                //=================================================================
                //Agrega los parámetros ingresados en el Append con su tipo de Dato
                //ingresado en la columna
                //Éste parámetro captura el estado del ticket
                comando.Parameters.Add("@EstadoDelTicket", SqlDbType.VarChar, 50).Value = detalleGenerado.EstadoDelTicket;
                //Éste parámetro captura el nombre del usuario que generó el ticket
                comando.Parameters.Add("@NombreDueñoDelTicket", SqlDbType.VarChar, 80).Value = detalleGenerado.NombreDueñoDelTicket;
                //Éste parámetro captura el número del ticket
                comando.Parameters.Add("@NumeroDelTicket", SqlDbType.Int).Value = detalleGenerado.NumeroDelTicket;
                //Éste parámetro captura el soporte que ha seleccionado el usurio
                comando.Parameters.Add("@SoporteRequeridoElegido", SqlDbType.VarChar,100).Value = detalleGenerado.SoporteRequeridoElegido;
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

    }
}

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
    public class TipoSoporteDAO : Conexion
    {
        //Se crea un comando global para no instanciar diversos comandos en cada método
        SqlCommand comando = new SqlCommand();

        //Método para validar el usuario

        public bool NuevoSoporte(TipoSoporteElegido soporteElegido)
        {

            //Método para validar el usuario
            try
            {
                StringBuilder sql = new StringBuilder(); //Permite agregar una consulta SQL
                sql.Append(" INSERT INTO TipoSoporte (Nombre) VALUES (@SoporteRequerido)");

                comando.Connection = MiConexion; //Comando declarado en la clase conexión
                MiConexion.Open(); //Se abre la conexión a la base de datos
                comando.CommandType = System.Data.CommandType.Text; //Tipo de comando que se va a ejecutar
                comando.CommandText = sql.ToString(); //Se manda la sentencia SQL

                //=================================================================
                //Agrega los parámetros ingresados en el Append con su tipo de Dato
                //ingresado en la columna
                //Éste parámetro captura el nombre  ingresado a la aplicación
                comando.Parameters.Add("@SoporteRequerido", SqlDbType.NVarChar, 50).Value = soporteElegido.SoporteRequerido;
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

        public DataTable GetSoporte()
        {
            DataTable columna = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder(); //Permite agregar una consulta SQL
                sql.Append("SELECT * FROM TipoSoporte");

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

        public DataTable ListarEstado()
        {
            DataTable tabla = new DataTable();

            comando.Connection = MiConexion; //Comando declarado en la clase conexión
            MiConexion.Open(); //Se abre la conexión a la base de datos
            comando.CommandText = "InsertarEstado";
            comando.CommandType = CommandType.StoredProcedure; //Tipo de comando que se va a ejecutar

            LeerFilas = comando.ExecuteReader();
            tabla.Load(LeerFilas);
            LeerFilas.Close();
            MiConexion.Close();

            return tabla;
        }

    }
}

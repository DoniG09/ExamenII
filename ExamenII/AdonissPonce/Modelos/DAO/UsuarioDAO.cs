using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using POO.Modelos.Entidades; //Para poder usar la clase usuario en la carpeta "Entidades"
using POO.Modelos.DAO;
using System.Windows.Forms;

namespace POO.Modelos.DAO
{
    public class UsuarioDAO : Conexion //Se hereda la clase "Conexion", por lo tanto tiene acceso a la
                                       //cadena de conexión
    {
        //Se crea un comando global para no instanciar diversos comandos en cada método
        SqlCommand comando = new SqlCommand();

        //Método para validar el usuario
        public bool ValidarUsuario(Usuario usuarioIngresado)
        {
            bool valido = false;

            try //Evita que si la aplicación tiene un error no se rompa
            {
                StringBuilder sql = new StringBuilder(); //Permite agregar una consulta SQL
                sql.Append(" SELECT 1 FROM Usuario WHERE Correo= @Email AND Contrasenia= @Clave;");

                comando.Connection = MiConexion; //Comando declarado en la clase conexión
                MiConexion.Open(); //Se abre la conexión a la base de datos
                comando.CommandType = System.Data.CommandType.Text; //Tipo de comando que se va a ejecutar
                comando.CommandText = sql.ToString(); //Se manda la sentencia SQL

                //=================================================================
                //Agrega los parámetros ingresados en el Append con su tipo de Dato
                //ingresado en la columna
                //Éste parámetro captura el correo ingresado a la aplicación
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = usuarioIngresado.Email;
                //Éste parámetro captura la contraseña ingresada a la aplicación
                comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 100).Value = usuarioIngresado.Clave;
                //================================================================= 
                valido = Convert.ToBoolean(comando.ExecuteScalar());
                MiConexion.Close();

            }
            catch (Exception)
            {
            }
            return valido;

        }

        public bool NuevoUsuario(Usuario usuarioIngresado)
        {
            try
            {
                StringBuilder sql = new StringBuilder(); //Permite agregar una consulta SQL
                sql.Append(" INSERT INTO Usuario (Nombre, Correo, Contrasenia) VALUES (@Nombre, @Email, @Clave)");

                comando.Connection = MiConexion; //Comando declarado en la clase conexión
                MiConexion.Open(); //Se abre la conexión a la base de datos
                comando.CommandType = System.Data.CommandType.Text; //Tipo de comando que se va a ejecutar
                comando.CommandText = sql.ToString(); //Se manda la sentencia SQL

                //=================================================================
                //Agrega los parámetros ingresados en el Append con su tipo de Dato
                //ingresado en la columna
                //Éste parámetro captura el nombre  ingresado a la aplicación
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 80).Value = usuarioIngresado.Nombre;
                //Éste parámetro captura el correo  ingresado a la aplicación
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = usuarioIngresado.Email;
                //Éste parámetro captura la contraseña ingresada a la aplicación
                comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 100).Value = EncriptarClave(usuarioIngresado.Clave);
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

        public DataTable GetUsuarios()
        {
            DataTable columna = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder(); //Permite agregar una consulta SQL
                sql.Append("SELECT * FROM Usuario");

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

        public DataTable GetNombreUsuario()
        {
            DataTable columna = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder(); //Permite agregar una consulta SQL
                sql.Append("SELECT Nombre FROM Usuario");

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

        public DataTable GetNumeroTicket()
        {
            DataTable columna = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder(); //Permite agregar una consulta SQL
                sql.Append("SELECT Numero FROM Ticket");

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

        public bool GuardarNombre()
        {
           
           StringBuilder sql1 = new StringBuilder(); //Permite agregar una consulta SQL
           sql1.Append("SELECT  * FROM Usuario");

           comando.Connection = MiConexion; //Comando declarado en la clase conexión
           MiConexion.Open(); //Se abre la conexión a la base de datos
           comando.CommandType = CommandType.Text; //Tipo de comando que se va a ejecutar
           SqlDataReader reader = comando.ExecuteReader();

            try
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        int c = +1;

                        MessageBox.Show(c.ToString());
                        //GuardarDatosCache.Id = reader.GetInt32(0);
                        //GuardarDatosCache.Nombre = reader.GetString(1);
                        //GuardarDatosCache.Email = reader.GetString(2);
                    }

                    return true;
                }
              else
                {
                    return false;
                }
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }

        }

        private SqlDataReader LeerFilas;

        public DataTable ListarDatosUsuario()
        {
            DataTable tabla = new DataTable();

            comando.Connection = MiConexion; //Comando declarado en la clase conexión
            MiConexion.Open(); //Se abre la conexión a la base de datos
            comando.CommandText = "ListarDatosUsuario";
            comando.CommandType = CommandType.StoredProcedure; //Tipo de comando que se va a ejecutar

            LeerFilas = comando.ExecuteReader();
            tabla.Load(LeerFilas);
            LeerFilas.Close();
            MiConexion.Close();

            return tabla;
        }

            public static string EncriptarClave(string str)
        {
            string cadena = str + "MiClavePersonal";
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(cadena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }


    }
}

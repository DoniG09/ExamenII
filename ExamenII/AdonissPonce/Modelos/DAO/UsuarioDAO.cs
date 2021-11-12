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
                //sql.Append(" VALUES (Nombre, Correo, Contrasenia); ");

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

        public DataTable GetUsuariosNombre()
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

        public bool GuardarNombre()
        {
            try
            {
                StringBuilder sql1 = new StringBuilder(); //Permite agregar una consulta SQL
                sql1.Append("SELECT  1 FROM Usuario WHERE Nombre = @Nombre");

                comando.Connection = MiConexion; //Comando declarado en la clase conexión
                MiConexion.Open(); //Se abre la conexión a la base de datos
                comando.CommandType = CommandType.Text; //Tipo de comando que se va a ejecutar
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //GuardarDatosCache.Nombre = 
                        comando.Parameters.Add(reader.GetString(1), SqlDbType.NVarChar, 80).Value = GuardarDatosCache.Nombre; 
                    }
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace POO.Modelos.DAO
{
    public static class GuardarDatosCache
    {
        //private Conexion conectar = new Conexion();

        //SqlDataReader leer;
        //DataTable tabla = new DataTable();
        //SqlCommand comando = new SqlCommand();

        //public DataTable Mostrar()
        //{
        //    comando.Connection =  MiConexion;
        //    MiConexion.Open();
        //    comando.CommandText = "SELECT Nombre FROM Usuario";
        //    leer = comando.ExecuteReader();
        //    tabla.Load(leer);
        //    MiConexion.Close();
        //    return tabla;
        //}

        public static string Nombre { get; set; }
        public static string Email { get; set; }

    }
}

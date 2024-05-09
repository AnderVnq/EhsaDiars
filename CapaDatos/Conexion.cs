using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        private static readonly Conexion _instance = new Conexion();
        public static Conexion Instance { get {  return _instance; } }
        public SqlConnection Conectar()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString= "Data Source=CESARCHAUCA; Initial Catalog = ETHSA_bd2;" + "Integrated Security=true";
            return conexion;
        }
    }
}

using MySql.Data.MySqlClient;
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
        // Instancia singleton
        private static readonly Conexion _instance = new Conexion();
        public static Conexion Instance { get { return _instance; } }

        //private string connectionString = "Server=bd9tpws8jfqulufuy2ur-mysql.services.clever-cloud.com;Port=3306;Database=bd9tpws8jfqulufuy2ur;Uid=u7mam79auuacon4t;Pwd=NV0qEqUJCdvE7bREVvAV;";
        private string connectionString = "Server=localhost;Port=3306;Database=ethsa_db2;Uid=root;Pwd=heaveny2;";
        // Constructor privado para evitar la instanciación desde fuera
        private Conexion() { }

        // Método para obtener la conexión MySQL
        public MySqlConnection Conectar()
        {
            MySqlConnection conexion = new MySqlConnection(connectionString);
            return conexion;
        }
    }
}

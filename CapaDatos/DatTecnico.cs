using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class DatTecnico
    {

        #region singleton

        private static readonly DatTecnico _instace = new DatTecnico() ;
        public static DatTecnico Instance
        {
            get { return _instace; }
        }
        #endregion





        public List<Tecnico> list_tecnicos()
        {
            MySqlCommand sqlCommand = null;
            List<Tecnico> lista = new List<Tecnico>();
            try
            {
                MySqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new MySqlCommand("spListarTecnicos", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                cn.Open();
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Tecnico mante = new Tecnico();
                    mante.id = Convert.ToInt32(reader["id_tecnico"]);
                    mante.id_taller = Convert.ToInt32(reader["id_taller"]);
                    mante.nombre_taller = reader["taller"].ToString();
                    mante.fecha_contrato = Convert.ToDateTime(reader["fecha_contratacion"]);
                    mante.apellido = reader["apellido"].ToString();
                    mante.especialidad = reader["especialidad"].ToString().ToLower();
                    mante.telefono = reader["telefono"].ToString().ToLower();
                    mante.direccion = reader["direccion"].ToString().ToLower();
                    mante.nombre = reader["nombre"].ToString();
                    mante.estado = Convert.ToBoolean(reader["estado"]);
                    lista.Add(mante);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }
            return lista;
        }
    }
}

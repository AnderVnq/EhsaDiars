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
    public class DatTaller
    {


        #region singleton

        private static readonly DatTaller _instace = new DatTaller();
        public static DatTaller Instance
        {
            get { return _instace; }
        }
        #endregion



        public List<Taller> listar_taller()
        {
            MySqlCommand sqlCommand = null;
            List<Taller> lista = new List<Taller>();
            try
            {
                MySqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new MySqlCommand("splistarTaller", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                cn.Open();
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    Taller taller = new Taller();
                    taller.entMantenimiento = new entMantenimiento();
                    taller.id = Convert.ToInt32(reader["id_taller"]);
                    taller.entMantenimiento.id = Convert.ToInt32(reader["id_mantenimiento"]);
                    taller.nombre = reader["nombre"].ToString();
                    taller.direccion = reader["direccion"].ToString();
                    taller.telefono = reader["telefono"].ToString();
                    lista.Add(taller);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;

        }

        public List<Mantenimiento_interno> listar_Mante_interno()
        {
            MySqlCommand sqlCommand = null;
            List<Mantenimiento_interno> lista = new List<Mantenimiento_interno>();
            try
            {
                MySqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new MySqlCommand("listaManteInterno", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                cn.Open();
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    Mantenimiento_interno taller = new Mantenimiento_interno();
                    taller.id = Convert.ToInt32(reader["id_taller"]);
                    taller.id_mantenimiento = Convert.ToInt32(reader["id_mantenimiento"]);
                    taller.tipo_matenimiento = reader["tipo_mantenimiento"].ToString();
                    taller.fecha_mantenimiento = Convert.ToDateTime(reader["fecha_mantenimiento"]);
                    taller.costo = Convert.ToInt32(reader["costo"]);
                    taller.nombre = reader["nombre"].ToString();
                    lista.Add(taller);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;
        }



    }
}

using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datMantenimiento
    {
        #region singleton

        private static readonly datMantenimiento _instace = new datMantenimiento();
        public static datMantenimiento Instance
        {
            get { return _instace; }
        }
        #endregion



        public List<entMantenimiento> listar()
        {
            SqlCommand sqlCommand = null;
            List<entMantenimiento> lista = new List<entMantenimiento>();
            try
            {
                SqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new SqlCommand("spListMantenimiento", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    entMantenimiento mante = new entMantenimiento();
                    mante.id = Convert.ToInt32(reader["id_mantenimiento"]);
                    mante.id_vehiculo = Convert.ToInt32(reader["id_vehiculo"]);
                    mante.placa_vehiculo = reader["placa"].ToString();
                    mante.fecha_mantenimiento = Convert.ToDateTime(reader["fecha_mantenimiento"]);
                    mante.tipo_mantenimiento = reader["tipo_mantenimiento"].ToString();
                    mante.componente = reader["componente_reparado"].ToString().ToLower();
                    mante.kilometraje = reader["kilometraje"].ToString().ToLower();
                    mante.comentario = reader["comentarios"].ToString().ToLower();
                    mante.costo = Convert.ToSingle(reader["costo"]);
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



        public bool crearMantenimiento(entMantenimiento mantenimiento)
        {
            SqlCommand sqlCommand = null;
            Boolean creado = false;

            try
            {
                SqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new SqlCommand("spInsertarMantenimiento", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@id_vehiculo",mantenimiento.id_vehiculo);
                sqlCommand.Parameters.AddWithValue("@tipo_mantenimiento",mantenimiento.tipo_mantenimiento);
                sqlCommand.Parameters.AddWithValue("@fecha_mantenimiento", mantenimiento.fecha_mantenimiento);
                sqlCommand.Parameters.AddWithValue("@costo",mantenimiento.costo);
                sqlCommand.Parameters.AddWithValue("@kilometraje", mantenimiento.kilometraje);
                sqlCommand.Parameters.AddWithValue("@componente_reparado",mantenimiento.componente);
                sqlCommand.Parameters.AddWithValue("@comentarios",mantenimiento.comentario);

                cn.Open();
                int i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    creado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCommand != null)
                {
                    sqlCommand.Connection.Close();
                }
            }
            return creado;
        }



        public List<entMantenimiento> Mantemintos_disp()
        {
            SqlCommand sqlCommand = null;
            List<entMantenimiento> lista = new List<entMantenimiento>();
            try
            {
                SqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new SqlCommand("mantenimientos_Disponibles", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    entMantenimiento mante = new entMantenimiento();
                    mante.id = Convert.ToInt32(reader["id_mantenimiento"]);
                    mante.id_vehiculo = Convert.ToInt32(reader["id_vehiculo"]);
                    mante.placa_vehiculo = reader["placa"].ToString();
                    mante.fecha_mantenimiento = Convert.ToDateTime(reader["fecha_mantenimiento"]);
                    mante.tipo_mantenimiento = reader["tipo_mantenimiento"].ToString();
                    mante.componente = reader["componente_reparado"].ToString().ToLower();
                    mante.kilometraje = reader["kilometraje"].ToString().ToLower();
                    mante.comentario = reader["comentarios"].ToString().ToLower();
                    mante.costo = Convert.ToSingle(reader["costo"]);
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

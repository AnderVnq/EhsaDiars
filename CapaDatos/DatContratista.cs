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
    public class DatContratista
    {


        #region singleton

        private static readonly DatContratista _instace = new DatContratista();
        public static DatContratista Instance
        {
            get { return _instace; }
        }
        #endregion



        public List<Contratistas> list_contratistas()
        {
            MySqlCommand sqlCommand = null;
            List<Contratistas> lista = new List<Contratistas>();
            try
            {
                MySqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new MySqlCommand("splistarContratistas", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                cn.Open();
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Contratistas contratista = new Contratistas();
                    contratista.id = Convert.ToInt32(reader["id_contratista"]);
                    contratista.tipo_documento = reader["tipo_documento"].ToString();
                    contratista.nro_Documento = reader["nro_documento"].ToString();
                    contratista.razon_Social = reader["nombre_razonsoc"].ToString();
                    contratista.direccion = reader["direccion"].ToString();
                    contratista.nro_Contacto = reader["nro_contacto"].ToString();
                    contratista.correo = reader["correo"].ToString();
                    contratista.especialidad = reader["especialidad"].ToString();
                    lista.Add(contratista);
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



        public Boolean createContratista(Contratistas contratista)
        {
            MySqlCommand sqlCommand = null;
            Boolean creado = false;

            try
            {
                MySqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new MySqlCommand("createContratista", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@tipo_documento", contratista.tipo_documento);
                sqlCommand.Parameters.AddWithValue("@nro_documento", contratista.nro_Documento);
                sqlCommand.Parameters.AddWithValue("@nombre_razonsoc", contratista.razon_Social);
                sqlCommand.Parameters.AddWithValue("@direccion", contratista.direccion);
                sqlCommand.Parameters.AddWithValue("@nro_contacto", contratista.nro_Contacto);
                sqlCommand.Parameters.AddWithValue("@correo", contratista.correo);
                sqlCommand.Parameters.AddWithValue("@especialidad", contratista.especialidad);

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

        public Boolean deleteContratista(int id)
        {
            MySqlCommand sqlCommand = null;
            Boolean eliminado = false;

            try
            {
                MySqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new MySqlCommand("spEliminarContratista", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@id", id);

                cn.Open();
                int i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    eliminado = true;
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
            return eliminado;
        }




        public List<OrdenMantenimiento> listar_orden_mantenimiento()
        {
            MySqlCommand sqlCommand = null;
            List<OrdenMantenimiento> lista = new List<OrdenMantenimiento>();
            try
            {
                MySqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new MySqlCommand("splistarOrdenes", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                cn.Open();
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    OrdenMantenimiento orden = new OrdenMantenimiento();
                    orden.id = Convert.ToInt32(reader["id_orden"]);
                    orden.id_contratista =Convert.ToInt32(reader["id_contratista"]);
                    orden.razon_social = reader["nombre_razonsoc"].ToString();
                    orden.id_mantenimiento =Convert.ToInt32(reader["id_mantenimiento"]);
                    orden.tipo_mantenimiento = reader["tipo_mantenimiento"].ToString();
                    orden.costo = Convert.ToSingle(reader["costo"]);
                    orden.componente = reader["componente_reparado"].ToString();
                    orden.fecha_inicio =Convert.ToDateTime(reader["fecha_inicio"]);
                    orden.fecha_fin = Convert.ToDateTime(reader["fecha_fin"]);
                    orden.estado = reader["estado"].ToString();
                    lista.Add(orden);
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

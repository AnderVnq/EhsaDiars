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
    public class DatAuto
    {
        #region singleton

        private static readonly DatAuto _instace = new DatAuto();
        public static DatAuto Instance
        {
            get { return _instace; }
        }
        #endregion



        public List<Automovil> listar()
        {
            SqlCommand sqlCommand = null;
            List<Automovil> lista = new List<Automovil>();
            try
            {
                SqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new SqlCommand("spListarAutos", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Automovil automovil = new Automovil();
                    automovil.id= Convert.ToInt32(reader["id_vehiculo"]);
                    automovil.id_conductor= Convert.ToInt32(reader["id_conductor"]);
                    automovil.conductor = reader["nombre"].ToString();
                    automovil.marca = reader["marca"].ToString();
                    automovil.modelo = reader["modelo"].ToString();
                    automovil.fabricacion = Convert.ToDateTime(reader["anio_fabricacion"]);
                    automovil.capacidad = reader["capacidad_pasajeros"].ToString();
                    automovil.kilometraje = reader["kilometraje"].ToString();
                    automovil.estado = Convert.ToBoolean(reader["estado"]);
                    lista.Add(automovil);
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


        public List<Conductor> listar_conductores_disp()
        {
            SqlCommand sqlCommand = null;
            List<Conductor> lista = new List<Conductor>();
            try
            {
                SqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new SqlCommand("ConductorNoAsigAuto", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Conductor conductor = new Conductor();
                    conductor.id = Convert.ToInt32(reader["id_conductor"]);
                    conductor.nombre =reader["nombre"].ToString();
                    conductor.tipo_licencia = reader["tipo_licencia"].ToString();
                    lista.Add(conductor);
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





        public Automovil Get_Id(int id)
        {
            SqlCommand sqlCommand = null;
            Automovil auto = new Automovil();

            try
            {
                SqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new SqlCommand("vehiculo_by_id", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
                cn.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {

                    auto.id = Convert.ToInt32(reader["id_vehiculo"]);
                    auto.placa = reader["placa"].ToString();
                    auto.id_conductor = Convert.ToInt32(reader["id_conductor"]);
                    auto.marca = reader["marca"].ToString();
                    auto.modelo = reader["modelo"].ToString();
                    auto.fabricacion = Convert.ToDateTime(reader["anio_fabricacion"]);
                    auto.kilometraje = reader["kilometraje"].ToString();
                    auto.estado = Convert.ToBoolean(reader["estado"]);
                    auto.capacidad = reader["capacidad_pasajeros"].ToString();
                }
                else
                {
                    return null;
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

            return auto;
        }


        public Boolean ActualizarAuto(Automovil auto)
        {
            SqlCommand sqlCommand = null;
            Boolean actualiza = false;
            try
            {
                SqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new SqlCommand("spUpdateVehiculo", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros para el procedimiento almacenado
                sqlCommand.Parameters.AddWithValue("@id", auto.id);
                sqlCommand.Parameters.AddWithValue("@id_conductor",auto.id_conductor);
                sqlCommand.Parameters.AddWithValue("@marca",auto.marca);
                sqlCommand.Parameters.AddWithValue("@modelo",auto.modelo);
                sqlCommand.Parameters.AddWithValue("@fabricacion", auto.fabricacion);
                sqlCommand.Parameters.AddWithValue("@capacidad", auto.capacidad);
                sqlCommand.Parameters.AddWithValue("@kilometraje", auto.kilometraje);
                sqlCommand.Parameters.AddWithValue("@placa",auto.placa);
                sqlCommand.Parameters.AddWithValue("@estado", auto.estado);
                // Agrega otros parámetros para otros campos que deseas actualizar

                cn.Open();
                int i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    actualiza = true;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según sea necesario
                throw ex;
            }
            finally
            {
                if (sqlCommand != null)
                {
                    sqlCommand.Connection.Close();
                }
            }
            return actualiza;
        }


        public Boolean createAutomovil(Automovil auto)
        {
            SqlCommand sqlCommand = null;
            bool creado = false;

            try
            {
                SqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new SqlCommand("spInsertVehiculo", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@id_conductor",auto.id_conductor);
                sqlCommand.Parameters.AddWithValue("@marca", auto.marca);
                sqlCommand.Parameters.AddWithValue("@modelo", auto.modelo);
                sqlCommand.Parameters.AddWithValue("@fabricacion",auto.fabricacion);
                sqlCommand.Parameters.AddWithValue("@capacidad", auto.capacidad);
                sqlCommand.Parameters.AddWithValue("@kilometraje", auto.kilometraje);
                sqlCommand.Parameters.AddWithValue("@placa", auto.placa);

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




        public Boolean deleteAuto(int id)
        {
            SqlCommand sqlCommand = null;
            Boolean eliminado = false;

            try
            {
                SqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new SqlCommand("spEliminarAuto", cn);
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




        public List<string> detalle_vehiculo(int id)
        {
            SqlCommand sqlCommand = null;
            bool detalle = false;
            List<string> list = null;
            try
            {
                SqlConnection con = Conexion.Instance.Conectar();
                sqlCommand = new SqlCommand("spEspecicficaciones", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                list = new List<string>();
                if (reader.Read())
                {
                    list.Add(reader["placa"].ToString());
                    list.Add(reader["tipo_motor"].ToString());
                    list.Add(reader["tipo_combustible"].ToString());
                    list.Add(reader["numero_cilindros"].ToString());
                    list.Add(reader["total_puertas"].ToString());
                    list.Add(reader["caja_velocidades"].ToString());
                    list.Add(reader["nro_aro"].ToString());
                    list.Add(reader["material_aro"].ToString());
                    list.Add(reader["tipo_freno_post"].ToString());
                    list.Add(reader["tipo_freno_del"].ToString());
                    list.Add(reader["alto"].ToString());
                    list.Add(reader["ancho"].ToString());
                    list.Add(reader["tipo_faros"].ToString());
                    list.Add(reader["neumatico"].ToString());
                }
                else
                {
                    return null;
                }


            }
            catch (Exception ex )
            {
                throw ex;
            }
            finally
            {
                if(sqlCommand != null)
                {
                    sqlCommand.Connection.Close();
                }
            }
            return list;
        }



    }
}

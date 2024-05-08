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





        public Conductor Get_Id(int id)
        {
            SqlCommand sqlCommand = null;
            Conductor conductor = new Conductor();

            try
            {
                SqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new SqlCommand("spConductorById", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
                cn.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {

                    conductor.id = Convert.ToInt32(reader["id_conductor"]);
                    conductor.nombre = reader["nombre"].ToString();
                    conductor.apellido = reader["apellido"].ToString();
                    conductor.dni = reader["dni"].ToString();
                    conductor.licencia = reader["licencia"].ToString();
                    conductor.tipo_licencia = reader["tipo_licencia"].ToString();
                    conductor.telefono = reader["telefono"].ToString();
                    conductor.direccion = reader["direccion"].ToString();
                    conductor.fecha_contratacion = Convert.ToDateTime(reader["fecha_contratacion"].ToString());
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

            return conductor;
        }


        public Boolean ActualizarConductor(int id, string nombre, string apellido, string licencia, string tipo_licencia, string telefono, string direccion, string dni)
        {
            SqlCommand sqlCommand = null;
            Boolean actualiza = false;
            try
            {
                SqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new SqlCommand("spUpdateConductor", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros para el procedimiento almacenado
                sqlCommand.Parameters.AddWithValue("@Id", id);
                sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                sqlCommand.Parameters.AddWithValue("@apellido", apellido);
                sqlCommand.Parameters.AddWithValue("@licencia", licencia);
                sqlCommand.Parameters.AddWithValue("@tipo_licencia", tipo_licencia);
                sqlCommand.Parameters.AddWithValue("@telefono", telefono);
                sqlCommand.Parameters.AddWithValue("@direccion", direccion);
                sqlCommand.Parameters.AddWithValue("@dni", dni);
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


        public Boolean createConductor(Conductor conductor)
        {
            SqlCommand sqlCommand = null;
            bool creado = false;

            try
            {
                SqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new SqlCommand("spInsertarConductor", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@nombre", conductor.nombre);
                sqlCommand.Parameters.AddWithValue("@apellido", conductor.apellido);
                sqlCommand.Parameters.AddWithValue("@licencia", conductor.licencia);
                sqlCommand.Parameters.AddWithValue("@tipo_licencia", conductor.tipo_licencia);
                sqlCommand.Parameters.AddWithValue("@telefono", conductor.telefono);
                sqlCommand.Parameters.AddWithValue("@direccion", conductor.direccion);
                sqlCommand.Parameters.AddWithValue("@dni", conductor.dni);
                sqlCommand.Parameters.AddWithValue("@fecha", conductor.fecha_contratacion);

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




        public Boolean deleteConductor(int id)
        {
            SqlCommand sqlCommand = null;
            Boolean eliminado = false;

            try
            {
                SqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new SqlCommand("spEliminar", cn);
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

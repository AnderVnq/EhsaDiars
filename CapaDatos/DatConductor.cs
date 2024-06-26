﻿using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatConductor
    {
        #region singleton

        private static readonly DatConductor _instace= new DatConductor();
        public static DatConductor Instance
        {
            get { return _instace; }
        }
        #endregion




        public List<Conductor> listar()
        {
            MySqlCommand sqlCommand = null;
            List<Conductor> lista = new List<Conductor> ();
            try
            {
                MySqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new MySqlCommand("spListarConductor", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                cn.Open();
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Conductor conductor = new Conductor();
                    conductor.id = Convert.ToInt32(reader["id_conductor"]);
                    conductor.nombre = reader["nombre"].ToString();
                    conductor.apellido = reader["apellido"].ToString() ;
                    conductor.dni = reader["dni"].ToString();
                    conductor.licencia= reader["licencia"].ToString().ToLower();
                    conductor.tipo_licencia = reader["tipo_licencia"].ToString().ToLower();
                    conductor.telefono = reader["telefono"].ToString ().ToLower();
                    conductor.direccion = reader["direccion"].ToString ();
                    conductor.fecha_contratacion = Convert.ToDateTime(reader["fecha_contratacion"]);
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
            MySqlCommand sqlCommand = null;
            Conductor conductor = new Conductor();

            try
            {
                MySqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new MySqlCommand("spConductorById", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
                cn.Open();
                MySqlDataReader reader = sqlCommand.ExecuteReader();

                if(reader.Read())
                {

                    conductor.id = Convert.ToInt32(reader["id_conductor"]);
                    conductor.nombre = reader["nombre"].ToString();
                    conductor.apellido = reader["apellido"].ToString();
                    conductor.dni = reader["dni"].ToString();
                    conductor.licencia= reader["licencia"].ToString();
                    conductor.tipo_licencia = reader["tipo_licencia"].ToString();
                    conductor.telefono = reader["telefono"].ToString();
                    conductor.direccion = reader["direccion"].ToString();
                    conductor.fecha_contratacion = Convert.ToDateTime(reader["fecha_contratacion"].ToString());
                }
                else
                {
                    return null  ;
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
            MySqlCommand sqlCommand = null;
            Boolean actualiza = false;
            try
            {
                MySqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new MySqlCommand("spUpdateConductor", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros para el procedimiento almacenado
                sqlCommand.Parameters.AddWithValue("@Id", id);
                sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                sqlCommand.Parameters.AddWithValue("@apellido", apellido);
                sqlCommand.Parameters.AddWithValue("@licencia", licencia);
                sqlCommand.Parameters.AddWithValue("@tipo_licencia",tipo_licencia);
                sqlCommand.Parameters.AddWithValue("@telefono", telefono);
                sqlCommand.Parameters.AddWithValue("@direccion", direccion);
                sqlCommand.Parameters.AddWithValue("@dni",dni);
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
            MySqlCommand sqlCommand = null;
            Boolean creado = false;

            try
            {
                MySqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new MySqlCommand("spInsertarConductor", cn);
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
            MySqlCommand sqlCommand = null;
            Boolean eliminado = false;

            try
            {
                MySqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new MySqlCommand("spEliminar", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@id",id);

                cn.Open();
                int i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    eliminado = true;
                }

            }
            catch(Exception ex)
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
    }
}

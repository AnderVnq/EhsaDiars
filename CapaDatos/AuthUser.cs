using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Data;
using CapaEntidad;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class AuthUser
    {

        #region singleton

        private static readonly AuthUser _instace = new AuthUser();
        public static AuthUser Instance
        {
            get { return _instace; }
        }
        #endregion


        public bool login_auth(string username,string password)
        {
            MySqlCommand sqlComand = null;
            bool is_login = false;

            try
            {
                MySqlConnection con = Conexion.Instance.Conectar();
                sqlComand = new MySqlCommand("login", con);
                sqlComand.CommandType = CommandType.StoredProcedure;

                string sesion_id=Guid.NewGuid().ToString("N");

                sqlComand.Parameters.AddWithValue("@sesion_id", sesion_id);
                sqlComand.Parameters.AddWithValue("@input_username", username);
                sqlComand.Parameters.AddWithValue("@input_password", password);

                con.Open();
                object result = sqlComand.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    int res = Convert.ToInt32(result);
                    if (res == 1)
                    {
                        is_login = true;
                    }
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally
            {
                if (sqlComand != null)
                {
                    sqlComand.Connection.Close();
                }
            }
            return is_login;

        }



        public bool validate_user(string username,string password)
        {
            MySqlCommand sqlComand = null;
            bool is_valid = false;

            try
            {
                MySqlConnection con = Conexion.Instance.Conectar();
                sqlComand = new MySqlCommand("valid_user", con);
                sqlComand.CommandType = CommandType.StoredProcedure;

                sqlComand.Parameters.AddWithValue("@input_username",username);
                sqlComand.Parameters.AddWithValue ("@input_contraseña", password);

                con.Open();
                object result = sqlComand.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    int res = Convert.ToInt32(result);
                    if (res == 1)
                    {
                        is_valid = true;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlComand != null)
                {
                    sqlComand.Connection.Close();
                }
            }

            return is_valid;
        }

        public bool validate_sessions(string sesion_id)
        {
            MySqlCommand sqlComand = null;
            bool activo = false;

            try
            {
                MySqlConnection con = Conexion.Instance.Conectar();
                sqlComand = new MySqlCommand("view_sessions", con);
                sqlComand.CommandType = CommandType.StoredProcedure;

                sqlComand.Parameters.AddWithValue("@username", sesion_id);

                con.Open();
                object result = sqlComand.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    int res = Convert.ToInt32(result);
                    if (res == 1)
                    {
                        activo = true;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlComand != null)
                {
                    sqlComand.Connection.Close();
                }
            }

            return activo;
        }


        public bool logout(string username)
        {
            MySqlCommand sqlComand = null;
            bool activo=false;
            try
            {
                MySqlConnection con = Conexion.Instance.Conectar();
                sqlComand = new MySqlCommand("logout", con);
                sqlComand.CommandType = CommandType.StoredProcedure;

                sqlComand.Parameters.AddWithValue("@username",username);
                con.Open();
                object result = sqlComand.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    int res = Convert.ToInt32(result);
                    if (res == 1)
                    {
                        activo = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlComand != null)
                {
                    sqlComand.Connection.Close();
                }
            }
            return activo;
        }


        public bool crear_user(Usuario usuario)
        {
            MySqlCommand sqlCommand = null;
            bool creado = false;

            try
            {
                MySqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new MySqlCommand("spInsertarUser", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@nombre", usuario.nombre);
                sqlCommand.Parameters.AddWithValue("@apellido_pat", usuario.apellido_pat);
                sqlCommand.Parameters.AddWithValue("@apellido_mat",usuario.apellido_mat);
                sqlCommand.Parameters.AddWithValue("@dni",usuario.dni);
                sqlCommand.Parameters.AddWithValue("@username",usuario.username);
                sqlCommand.Parameters.AddWithValue("@password",usuario.password);

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


    }
}

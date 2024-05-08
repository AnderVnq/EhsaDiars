using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Data;


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
            SqlCommand sqlComand = null;
            bool is_login = false;

            try
            {
                SqlConnection con = Conexion.Instance.Conectar();
                sqlComand = new SqlCommand("login", con);
                sqlComand.CommandType = CommandType.StoredProcedure;

                string sesion_id=Guid.NewGuid().ToString("N");

                sqlComand.Parameters.AddWithValue("@sesion_id", sesion_id);
                sqlComand.Parameters.AddWithValue("@username", username);
                sqlComand.Parameters.AddWithValue("@password", password);

                con.Open();
                bool res =(bool)sqlComand.ExecuteScalar();
                if (res == true)
                {
                    is_login = true;
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }

            return is_login;

        }



        public bool validate_user(string username,string password)
        {
            SqlCommand sqlComand = null;
            bool is_valid = false;

            try
            {
                SqlConnection con = Conexion.Instance.Conectar();
                sqlComand = new SqlCommand("valid_user", con);
                sqlComand.CommandType = CommandType.StoredProcedure;

                sqlComand.Parameters.AddWithValue("@username",username);
                sqlComand.Parameters.AddWithValue ("@contraseña", password);

                con.Open();
                bool i = (bool)sqlComand.ExecuteScalar();
                if (i)
                {
                    is_valid = true;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return is_valid;
        }

        public bool validate_sessions(string sesion_id)
        {
            SqlCommand sqlComand = null;
            bool activo = false;

            try
            {
                SqlConnection con = Conexion.Instance.Conectar();
                sqlComand = new SqlCommand("view_sessions", con);
                sqlComand.CommandType = CommandType.StoredProcedure;

                sqlComand.Parameters.AddWithValue("@username", sesion_id);

                con.Open();
                bool i = (bool)sqlComand.ExecuteScalar() ;
                if (i)
                {
                    activo = true;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return activo;
        }


        public void logout(string sesion_id)
        {
            SqlCommand sqlComand = null;

            try
            {
                SqlConnection con = Conexion.Instance.Conectar();
                sqlComand = new SqlCommand("logout", con);
                sqlComand.CommandType = CommandType.StoredProcedure;

                sqlComand.Parameters.AddWithValue("@sesion_id", sesion_id);
                con.Open();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

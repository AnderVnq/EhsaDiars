using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogAuthUser
    {

        #region singleton

        private static readonly LogAuthUser _instance = new LogAuthUser();

        public static LogAuthUser Instancia
        {
            get { return LogAuthUser._instance; }
        }
        #endregion 




        public Boolean login(string username, string password)
        {
            return AuthUser.Instance.login_auth(username, password);
        }

        public void logout(string sesion_id)
        {
            AuthUser.Instance.logout(sesion_id);
        }


        public bool validate_user(string username, string password)
        {
            return AuthUser.Instance.validate_user(username, password);
        }


        public bool validate_session(string sesion_id)
        {
            return AuthUser.Instance.validate_sessions(sesion_id);
        }

    }
}

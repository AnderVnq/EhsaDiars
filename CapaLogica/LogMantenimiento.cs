using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogMantenimiento
    {
        #region singleton

        private static readonly LogMantenimiento _instance = new LogMantenimiento();

        public static LogMantenimiento Instancia
        {
            get { return LogMantenimiento._instance; }
        }
        #endregion 


        public List<entMantenimiento> lista_mantenimientos()
        {
            return datMantenimiento.Instance.listar();
        }


    }
}

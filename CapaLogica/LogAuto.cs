using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogAuto
    {
        #region singleton

        private static readonly LogAuto _instance = new LogAuto();

        public static LogAuto Instancia
        {
            get { return LogAuto._instance; }
        }
        #endregion 




        public List<Automovil> listar_autos()
        {
            return DatAuto.Instance.listar();
        }
    }
}

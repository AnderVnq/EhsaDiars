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


        public bool crearMantenimiento(entMantenimiento entMantenimiento)
        {
            return datMantenimiento.Instance.crearMantenimiento(entMantenimiento);
        }

        public List<entMantenimiento> mantenimientos_disp()
        {
            return datMantenimiento.Instance.Mantemintos_disp();
        }


        public List<Automovil> autos_disp()
        {
            return DatAuto.Instance.autos_dips();
        }


    }
}

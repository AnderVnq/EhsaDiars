using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogTaller
    {

        #region singleton

        private static readonly LogTaller _instance = new LogTaller();

        public static LogTaller Instancia
        {
            get { return LogTaller._instance; }
        }
        #endregion 





        public List<Taller> listar_taller()
        {
            return DatTaller.Instance.listar_taller();
        }


        public List<Mantenimiento_interno> listar_mante_interno()
        {
            return DatTaller.Instance.listar_Mante_interno();
        }


    }
}

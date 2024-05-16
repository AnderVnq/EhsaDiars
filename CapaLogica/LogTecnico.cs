using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogTecnico
    {
        #region singleton

        private static readonly LogTecnico _instance = new LogTecnico();

        public static LogTecnico Instancia
        {
            get { return LogTecnico._instance; }
        }
        #endregion 






        public List<Tecnico> list_tecnicos()
        {
            return DatTecnico.Instance.list_tecnicos();
        }




    }
}

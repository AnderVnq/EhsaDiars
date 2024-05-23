using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogContratista
    {

        #region singleton

        private static readonly LogContratista _instance = new LogContratista();

        public static LogContratista Instancia
        {
            get { return LogContratista._instance; }
        }
        #endregion 




        public List<Contratistas> listar_contratistas()
        {
            return DatContratista.Instance.list_contratistas();
        }


        public bool crearContratista(Contratistas contratista)
        {
            return DatContratista.Instance.createContratista(contratista);
        }


        public bool eliminarContratista(int id)
        {
            return DatContratista.Instance.deleteContratista(id);
        }

        public List<OrdenMantenimiento> listar_ordenes()
        {
            return DatContratista.Instance.listar_orden_mantenimiento();
        }
    }

}

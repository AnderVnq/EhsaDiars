using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogPagos
    {
        #region singleton

        private static readonly LogPagos _instance = new LogPagos();

        public static LogPagos Instancia
        {
            get { return LogPagos._instance; }
        }
        #endregion 

        public List<entMantenimiento> lista_mantenimientos()
        {
            return datMantenimiento.Instance.Mantemintos_disp();
        }


        public entMantenimiento manteById(int id)
        {
            return datMantenimiento.Instance.mantenimiento_byId(id);
        }

        public List<Pagos> list_pagos()
        {
            return DatPagos.Instance.list_pagos();
        }



    }
}

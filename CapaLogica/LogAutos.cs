using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogAutos
    {
        #region singleton

        private static readonly LogAutos _instance = new LogAutos();

        public static LogAutos Instancia
        {
            get { return LogAutos._instance; }
        }
        #endregion 





        public List<Automovil> listar_autos()
        {
            return DatAuto.Instance.listar();
        }

        public List<Conductor> Conduc_sin_asignar()
        {
            return DatAuto.Instance.listar_conductores_disp();
        }



        public List<string> detalle(int id)
        {
           return DatAuto.Instance.detalle_vehiculo(id);
        }



        public bool create_auto(Automovil auto)
        {

            return DatAuto.Instance.createAutomovil(auto);

        }

        public bool update_vehiculo(Automovil auto)
        {
            return DatAuto.Instance.ActualizarAuto(auto);
        }

        public Automovil get_by_id(int id)
        {
            return DatAuto.Instance.Get_Id(id);
        }

        public bool eliminar_auto(int id)
        {
            return DatAuto.Instance.deleteAuto(id);
        }



    }
}

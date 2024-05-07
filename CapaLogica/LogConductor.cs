using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class LogConductor
    {
        #region singleton

        private static readonly LogConductor instance = new LogConductor();

        public static LogConductor Instancia
        {
            get { return LogConductor.instance; }
        }
        #endregion 




        public List<Conductor> Listar_Conductor()
        {
            return DatConductor.Instance.listar();
        }

        public Conductor Get_By_Id(int id)
        {
            return DatConductor.Instance.Get_Id(id);
        }

        public Boolean Actualizar_conductor(List<string> valores)
        {
            if (valores.Count >= 8)
            {
               int id = Convert.ToInt32(valores[0]);
               string dato1 = valores[1];
               string dato2 = valores[2];
               string dato3 = valores[3];
               string dato4 = valores[4];
               string dato5 = valores[5];
               string dato6 = valores[6];
               string dato7 = valores[7];

                return DatConductor.Instance.ActualizarConductor(id, dato1, dato2, dato3, dato4, dato5, dato6, dato7);
            }
            else
            {
                return false;
            }
        }

        public Boolean insertar_conductor(Conductor conductor)
        {
            return DatConductor.Instance.createConductor(conductor);
        }

        public Boolean Eliminar_Conductor(int id)
        {
            return DatConductor.Instance.deleteConductor(id);
        }
    }
}

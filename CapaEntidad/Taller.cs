using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Taller
    {
        public int id {  get; set; }
        public entMantenimiento entMantenimiento { get; set; }
        public string nombre { get; set; }
        public string direccion {  get; set; }
        public string telefono { get; set; }

    }

    public class Mantenimiento_interno
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int id_mantenimiento { get; set; }
        public string tipo_matenimiento { get; set; }
        public DateTime fecha_mantenimiento { get; set; }
        public float costo { get; set; }
    }



}

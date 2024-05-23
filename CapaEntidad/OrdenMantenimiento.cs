using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class OrdenMantenimiento
    {

        public int id {  get; set; }
        public int id_contratista { get; set; }
        public string razon_social { get; set; }
        public int id_mantenimiento { get; set; }
        public string tipo_mantenimiento { get; set; }
        public float costo {  get; set; }
        public string componente { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin {  get; set; }
        public string estado { get; set; }


    }
}

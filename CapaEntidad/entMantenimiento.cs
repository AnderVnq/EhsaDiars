using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entMantenimiento
    {
        public int id { get; set; }
        public int id_vehiculo {  get; set; }
        public string placa_vehiculo { get; set; }
        public string tipo_mantenimiento { get; set; }
        public float costo { get; set; }
        public string kilometraje { get; set; }
        public DateTime fecha_mantenimiento { get; set; }
        public string componente { get; set; }
        public string comentario { get; set; }
        public bool estado {  get; set; }
    }
}

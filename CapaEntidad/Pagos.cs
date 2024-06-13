using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pagos
    {

        public int id { get; set; }
        public int id_orden { get; set; }
        public int id_tipo_pago { get; set; }
        public string nombre_e { get; set; }
        public float monto_total { get; set; }
        public DateTime fecha_pago { get; set; }
        public string concepto { get; set; }
        public string nro_cuenta { get; set; }

    }
}

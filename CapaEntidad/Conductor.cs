using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Conductor
    {
        public int id {  get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni {  get; set; }
        public string licencia {  get; set; }
        public string tipo_licencia { get; set; }
        public string telefono { get; set; }
        public string direccion {  get; set; }
        public DateTime fecha_contratacion { get; set; }

    }
}

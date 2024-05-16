using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Tecnico
    {
        public int id {  get; set; }
        public int id_taller {  get; set; }
        public string nombre_taller { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string especialidad { get; set; }
        public string telefono { get; set; }
        public string direccion {  get; set; }
        public DateTime fecha_contrato { get; set; }
        public bool estado {  get; set; }
    }
}

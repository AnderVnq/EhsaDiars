using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Automovil
    {
        public int id {  get; set; }
        public int id_conductor { get; set; }
        public string conductor { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public DateTime fabricacion { get; set; }
        public string capacidad { get; set; }
        public string kilometraje { get; set; }
        public bool estado { get; set; }
        public string placa { get; set; }
    }
}

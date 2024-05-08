using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {

        public int Id { get; set; }
        public string nombre { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string apellido_pat {  get; set; }
        public string apellido_mat {  get; set; }
        public string dni {  get; set; }
    }
}

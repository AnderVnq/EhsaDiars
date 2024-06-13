using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Dashboard
    {

        public DateTime startDate {  get; set; }
        public DateTime endDate { get; set; }
        public int numberDays { get; set; }


        public int numero_mantenimientos { get; set; }
        public int numero_conductores { get; set; }
        public int numero_vehiculos { get; set; }

        public float total_costo_interno { get; set; }
        public float total_costo_externo { get; set; }
        public float total_costo_mantenimientos { get; set; }

        public int numero_ordenes {  get; set; }
        public int numero_pagos_fecha { get; set; }



        public void getNumeros_totales()
        {
            using (var conec = Conexion.Instance.Conectar())
            {
                conec.Open();
                using(var command = conec.CreateCommand())
                {
                    command.CommandText = "select count(id_mantenimiento) as total_mantenimientos from mantenimiento;";
                    numero_mantenimientos=(int)command.ExecuteNonQuery();


                    command.CommandText = "select count(id_conductor) as total_conductores from conductor;";
                    numero_conductores=(int)command.ExecuteNonQuery();



                    command.CommandText = "select count(id_vehiculo) as total_vehiculos from vehiculo;";
                    numero_vehiculos=(int)command.ExecuteNonQuery();




                    command.CommandText = "select count(id_orden) as total_ordenes from orden_mantenimiento;";
                    numero_ordenes=(int)command.ExecuteNonQuery();





                    command.CommandText = "SELECT count(id_pago) as total_pagos FROM Pagos WHERE fecha_pago BETWEEN @deDate AND @HastaDate;";
                    command.Parameters.Add("@deDate");
                    command.Parameters.Add("@HastaDate");
                    numero_pagos_fecha=(int)command.ExecuteNonQuery();

                }
            }
        }






    }
}

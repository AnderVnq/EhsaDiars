using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatPagos
    {


        #region singleton

        private static readonly DatPagos _instace = new DatPagos();
        public static DatPagos Instance
        {
            get { return _instace; }
        }
        #endregion




        public List<Pagos> list_pagos()
        {
            MySqlCommand sqlCommand = null;
            List<Pagos> lista = new List<Pagos>();
            try
            {
                MySqlConnection cn = Conexion.Instance.Conectar();
                sqlCommand = new MySqlCommand("spListpagos", cn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                cn.Open();
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Pagos pagos = new Pagos();
                    pagos.id= Convert.ToInt32(reader["id_pago"]);
                    pagos.id_orden = Convert.ToInt32(reader["id_orden"]);
                    pagos.id_tipo_pago = Convert.ToInt32(reader["id_tipo_pago"]);
                    pagos.nombre_e = reader["emisor"].ToString();
                    pagos.monto_total = Convert.ToSingle(reader["monto_total"]);
                    pagos.fecha_pago = Convert.ToDateTime(reader["fecha_pago"]);
                    pagos.concepto = reader["concepto_pago"].ToString();
                    pagos.nro_cuenta = reader["nro_cuenta"].ToString();
                    lista.Add(pagos);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }
            return lista;
        }



        //public List<Pagos> lista_mante_disp()
        //{
        //    MySqlCommand sqlCommand = null;
        //    List<Pagos> lista = new List<Pagos>();
        //    try
        //    {
        //        MySqlConnection cn = Conexion.Instance.Conectar();
        //        sqlCommand = new MySqlCommand("spListpagos", cn);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        cn.Open();
        //        MySqlDataReader reader = sqlCommand.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            Pagos pagos = new Pagos();
        //            pagos.id = Convert.ToInt32(reader["id_pago"]);
        //            pagos.id_orden = Convert.ToInt32(reader["id_orden"]);
        //            pagos.id_tipo_pago = Convert.ToInt32(reader["id_tipo_pago"]);
        //            pagos.nombre_e = reader["emisor"].ToString();
        //            pagos.monto_total = Convert.ToSingle(reader["monto_total"]);
        //            pagos.fecha_pago = Convert.ToDateTime(reader["fecha_pago"]);
        //            pagos.concepto = reader["concepto"].ToString();
        //            pagos.nro_cuenta = reader["nro_cuenta"].ToString();
        //            lista.Add(pagos);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        sqlCommand.Connection.Close();
        //    }
        //    return lista;
        //}









    }
}

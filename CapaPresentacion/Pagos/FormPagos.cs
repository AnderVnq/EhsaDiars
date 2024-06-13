using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion.Pagos
{
    public partial class FormPagos : Form
    {
        public FormPagos()
        {
            InitializeComponent();
            InicializarTimer();


            comboMante.DropDownStyle = ComboBoxStyle.DropDownList;
            txtComponente.ReadOnly = true;
            txtPlaca.ReadOnly = true;
        }

        private void FormPagos_Load(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString();
            lblprecio.Text = "S/500";

            List<entMantenimiento> lista = LogMantenimiento.Instancia.mantenimientos_disp();

            foreach (entMantenimiento m in lista)
            {
                comboMante.Items.Add($"ID: {m.id}; Vehiculo: {m.placa_vehiculo}");
            }


            dataGridView1.DataSource = LogPagos.Instancia.list_pagos();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString();
        }

        private void InicializarTimer()
        {
            timer1.Interval = 1000; // 1 segundo
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void comboMante_SelectedIndexChanged(object sender, EventArgs e)
        {

            string id_mantenimiento = null;
            if (comboMante.SelectedIndex != -1)
            {
                // Obtener la opción seleccionada y almacenarla en la variable
                string seleccion_vehiculo = comboMante.SelectedItem.ToString();

                string patron = @"ID:\s*(\d+)";

                // Buscar coincidencias utilizando la expresión regular
                Match match = Regex.Match(comboMante.SelectedItem.ToString(), patron);

                // Verificar si se encontró una coincidencia
                if (match.Success)
                {
                    // Extraer el valor del grupo capturado (el ID)
                    id_mantenimiento = match.Groups[1].Value;
                }

                if (id_mantenimiento != null)
                {
                    //MessageBox.Show($"id {id_vehiculo}");
                    entMantenimiento entMantenimiento = LogPagos.Instancia.manteById(Convert.ToInt32(id_mantenimiento));
                    txtPlaca.Text = entMantenimiento.placa_vehiculo.ToString();
                    txtComponente.Text= entMantenimiento.componente.ToString();
                }
            }

        }
    }
}

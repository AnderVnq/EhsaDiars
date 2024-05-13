using CapaEntidad;
using CapaLogica;
using CapaPresentacion.Conductores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Autos
{
    public partial class frmListAutos : Form
    {


        public frmListAutos()
        {
            InitializeComponent();
        }

        private void frmListAutos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LogAutos.Instancia.listar_autos();
            lblCountAutos.Text = dataGridView1.RowCount.ToString();
            listar_conductores();
        }





        public void listar_conductores()
        {
            //List<Conductor> conductores = LogAutos.Instancia.Conduc_sin_asignar();
            //foreach (Conductor con in conductores)
            //{
            //    comboBox1.Items.Add($"ID{con.id} - Nombre: {con.nombre} licencia: {con.tipo_licencia}");
            //}
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmInsertVehiculo frmInsertVehiculo = new frmInsertVehiculo();
            frmInsertVehiculo.ShowDialog();
        }

        private void Editar_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Crear una lista para almacenar los datos seleccionados
                string id = null;
                // Iterar sobre todas las filas seleccionadas
                foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
                {
                    // Obtener los datos de la fila seleccionada
                    id = fila.Cells["id"].Value.ToString();

                }
                frmInsertVehiculo frmEditar = new frmInsertVehiculo();
                frmEditar.Dato1 = id;
                frmEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione al menos una fila.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = null;
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    id = row.Cells["id"].Value.ToString();
                }

                detalleAuto frmDetalle = new detalleAuto();
                frmDetalle.dato = id;
                frmDetalle.ShowDialog();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LogAutos.Instancia.listar_autos();
            lblCountAutos.Text = dataGridView1.RowCount.ToString();
        }
    }
}

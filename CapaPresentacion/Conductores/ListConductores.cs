using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Conductores
{
    public partial class ListConductores : Form
    {
        public ListConductores()
        {
            InitializeComponent();
            dataGridView1.DataSource = LogConductor.Instancia.Listar_Conductor();
            lblCountConductores.Text = dataGridView1.RowCount.ToString();
        }

        private void ListConductores_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = LogConductor.Instancia.Listar_Conductor();
            //lblCountConductores.Text = dataGridView1.RowCount.ToString();

        }

        public void ActualizarGridView()
        {
            dataGridView1.Refresh();
            dataGridView1.DataSource = LogConductor.Instancia.Listar_Conductor();
            lblCountConductores.Text = dataGridView1.RowCount.ToString();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CrearConductor frmCrear = new CrearConductor();
            frmCrear.ShowDialog();

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
                CrearConductor frmEditar = new CrearConductor();
                frmEditar.Dato1 = id;
                frmEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione al menos una fila.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = null;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Iterar sobre todas las filas seleccionadas
                foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
                {
                    // Obtener los datos de la fila seleccionada
                    id = fila.Cells["id"].Value.ToString();

                }
                if (id !=null)
                {
                    bool resultado = LogConductor.Instancia.Eliminar_Conductor(Convert.ToInt32(id));
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = LogConductor.Instancia.Listar_Conductor();
                    lblCountConductores.Text = dataGridView1.RowCount.ToString();
                }
                else
                {
                    MessageBox.Show("Error en los datos", "Error");
                }
                

            }
            else
            {
                MessageBox.Show("Seleccione un valor ", "Error");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.ActualizarGridView();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

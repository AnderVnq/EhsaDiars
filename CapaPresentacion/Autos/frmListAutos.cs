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

        private BindingSource bindingSource;
        public frmListAutos()
        {
            InitializeComponent();
            bindingSource = new BindingSource();

            // Asigna el origen de datos al BindingSource
            bindingSource.DataSource = LogAutos.Instancia.listar_autos();

            // Asigna el BindingSource al DataGridView
            dataGridView1.DataSource = bindingSource;

            // Suscribe al evento TextChanged del TextBox para filtrar en tiempo real
            txtfiltrar.TextChanged += txtfiltrar_TextChanged;
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
            frmInsertVehiculo.Dato1 = null;
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

        private void txtfiltrar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtfiltrar.Text;

            // Filtra la lista subyacente basándose en el texto del TextBox
            var autosFiltrados = LogAutos.Instancia.listar_autos()
                                    .Where(auto => auto.placa.Contains(filtro) || auto.marca.Contains(filtro))
                                    .ToList();

            // Asigna la lista filtrada como origen de datos del BindingSource
            bindingSource.DataSource = autosFiltrados;
            dataGridView1.Refresh();
        }
    }
}

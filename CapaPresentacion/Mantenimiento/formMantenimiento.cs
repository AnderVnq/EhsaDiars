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

namespace CapaPresentacion.Mantenimiento
{
    public partial class formMantenimiento : Form
    {
        public formMantenimiento()
        {
            InitializeComponent();

            dataGridView1.DataSource = LogMantenimiento.Instancia.lista_mantenimientos();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string seleccion_vehiculo = null;
            string seleccion_tipo = null;
            string id_vehiculo = null;
            if (!Validators.ValidarSoloNumeros(txtcosto.Text))
            {
                MessageBox.Show("Ingrese un Costo Valido");
            }
            else if (!Validators.ValidarSoloNumeros(txtKilometraje.Text))
            {
                MessageBox.Show("Ingrese un kilometraje Valido");
            }
            else if (!Validators.ValidarNombreApellido(txtcomponente.Text))
            {
                MessageBox.Show("Error Ingrese un componente valido");
            }
            else
            {
                if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
                {
                    // Obtener la opción seleccionada y almacenarla en la variable
                    seleccion_vehiculo = comboBox1.SelectedItem.ToString();
                    seleccion_tipo = comboBox2.SelectedItem.ToString();

                    string patron = @"ID:\s*(\d+)";

                    // Buscar coincidencias utilizando la expresión regular
                    Match match = Regex.Match(comboBox1.SelectedItem.ToString(), patron);

                    // Verificar si se encontró una coincidencia
                    if (match.Success)
                    {
                        // Extraer el valor del grupo capturado (el ID)
                        id_vehiculo = match.Groups[1].Value;
                    }
                    entMantenimiento mantenimiento = new entMantenimiento();
                    mantenimiento.id_vehiculo = Convert.ToInt32(id_vehiculo);
                    mantenimiento.tipo_mantenimiento = seleccion_tipo;
                    mantenimiento.fecha_mantenimiento = dateTimePicker1.Value;
                    mantenimiento.costo = Convert.ToSingle(txtcosto.Text);
                    mantenimiento.kilometraje = txtKilometraje.Text;
                    mantenimiento.componente = txtcomponente.Text;
                    mantenimiento.comentario = txtcomentario.Text;


                    bool insert = LogMantenimiento.Instancia.crearMantenimiento(mantenimiento);
                    if (insert)
                    {
                        MessageBox.Show("Mantenimiento registrado Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("error al registrar mantenimiento");
                    }

                    // Realizar acciones con la selección almacenada
                }
                else
                {
                    // En caso de que no se haya seleccionado ninguna opción, muestra un mensaje de advertencia
                    MessageBox.Show("Por favor, seleccione una opción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void ActualizarGridView()
        {
            dataGridView1.Refresh();
            dataGridView1.DataSource = LogMantenimiento.Instancia.lista_mantenimientos();

        }


        private void formMantenimiento_Load(object sender, EventArgs e)
        {
            List<Automovil> mante = LogMantenimiento.Instancia.autos_disp();
            foreach (Automovil m in mante)
            {
                comboBox1.Items.Add($"ID: {m.id}; Vehiculo: {m.placa}");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.ActualizarGridView();

        }

        private void btnAsigInterna_Click(object sender, EventArgs e)
        {
            ManteInterno manteInterno = new ManteInterno();
            manteInterno.ShowDialog();
        }

        private void btnAsigExterna_Click(object sender, EventArgs e)
        {
            ManteExterno manteExterno = new ManteExterno();
            manteExterno.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id_vehiculo = null;
            if (comboBox1.SelectedIndex != -1)
            {
                // Obtener la opción seleccionada y almacenarla en la variable
                string seleccion_vehiculo = comboBox1.SelectedItem.ToString();

                string patron = @"ID:\s*(\d+)";

                // Buscar coincidencias utilizando la expresión regular
                Match match = Regex.Match(comboBox1.SelectedItem.ToString(), patron);

                // Verificar si se encontró una coincidencia
                if (match.Success)
                {
                    // Extraer el valor del grupo capturado (el ID)
                    id_vehiculo = match.Groups[1].Value;
                }

                if (id_vehiculo != null)
                {
                    //MessageBox.Show($"id {id_vehiculo}");
                    Automovil auto = LogAutos.Instancia.get_by_id(Convert.ToInt32(id_vehiculo));
                    txtKilometraje.Text = auto.kilometraje.ToString();
                }

            }
        }
    }
}

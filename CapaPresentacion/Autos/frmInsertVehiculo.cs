using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CapaPresentacion.Autos
{
    public partial class frmInsertVehiculo : Form
    {

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);


        public string Dato1 { get; set; }
        public frmInsertVehiculo()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmInsertVehiculo_Load(object sender, EventArgs e)
        {
            List<Conductor> conductores = LogAutos.Instancia.Conduc_sin_asignar();
            foreach (Conductor con in conductores)
            {
                comboBox1.Items.Add($"ID:{con.id} - Conductor: {con.nombre}; licencia: {con.tipo_licencia}");
            }
            if (this.Dato1 != null)
            {
                //Conductor conductor = LogConductor.Instancia.Get_By_Id(Convert.ToInt32(Dato1));
                Automovil auto = LogAutos.Instancia.get_by_id(Convert.ToInt32(Dato1));

                //MessageBox.Show($"auto {auto.id} {auto.capacidad} {auto.placa}");

                if (auto != null)
                {
                    if (auto.estado == true)
                    {
                        radioDisponible.Checked = true;
                    }
                    else
                    {
                        radioMantenimiento.Checked = true;
                    }
                    txtCapacidad.Text = auto.capacidad;
                    txtKilometraje.Text = auto.kilometraje;
                    txtMarca.Text = auto.marca;
                    txtModelo.Text = auto.modelo;
                    dateTimePicker1.Value = auto.fabricacion;
                    txtPlaca.Text= auto.placa;


                }
                else
                {
                    MessageBox.Show("Error al recuperar datos");
                }

                groupBox1.Visible = true;
                lblTitulo.Text = "Modificar Vehiculo";

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Dato1 != null)
            {

                if (!string.IsNullOrEmpty(txtModelo.Text) && !string.IsNullOrEmpty(txtMarca.Text) && !string.IsNullOrEmpty(txtCapacidad.Text) && !string.IsNullOrEmpty(txtKilometraje.Text))
                {
                    if (!Validators.ValidarSoloNumeros(txtCapacidad.Text) || txtCapacidad.Text.Length > 20)
                    {
                        MessageBox.Show("Por favor, ingrese solo números para la capacidad del vehículo y asegúrese de que no exceda los 20 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!Validators.ValidarSoloNumeros(txtKilometraje.Text))
                    {
                        MessageBox.Show("Por favor, ingrese solo números para el kilometraje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!Validators.ValidarNombreApellido(txtMarca.Text))
                    {
                        MessageBox.Show("Por favor, ingrese un valor válido para la marca del vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!Validators.ValidarNombreApellido(txtModelo.Text))
                    {
                        MessageBox.Show("Por favor, ingrese un valor válido para el modelo del vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!radioDisponible.Checked && !radioMantenimiento.Checked)
                    {
                        MessageBox.Show("Por favor, seleccione el estado del vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string selectedItem = comboBox1.SelectedItem?.ToString() ?? "";
                        string idString = Regex.Match(selectedItem, @"\d+").Value;



                        Automovil auto = LogAutos.Instancia.get_by_id(Convert.ToInt32(Dato1));
                        auto.id = Convert.ToInt32(Dato1);
                        auto.marca = txtMarca.Text;
                        auto.modelo = txtModelo.Text;
                        auto.estado = radioDisponible.Checked ? true : radioMantenimiento.Checked ? false : throw new Exception("Por favor, seleccione el estado del auto.");
                        auto.id_conductor = string.IsNullOrEmpty(idString) ? auto.id_conductor : Convert.ToInt32(idString);
                        auto.fabricacion = dateTimePicker1.Value;
                        auto.capacidad = txtCapacidad.Text;
                        auto.kilometraje = txtKilometraje.Text;
                        auto.placa = txtPlaca.Text;
                        bool actualizado = LogAutos.Instancia.update_vehiculo(auto);

                        if (actualizado)
                        {
                            MessageBox.Show("Vehiculo Actualizado Correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Error al Actualizar vehiculo");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error: Faltan datos. Por favor, complete todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtModelo.Text) && !string.IsNullOrEmpty(txtMarca.Text) && !string.IsNullOrEmpty(txtCapacidad.Text) && !string.IsNullOrEmpty(txtKilometraje.Text))
                {
                    if (!Validators.ValidarSoloNumeros(txtCapacidad.Text) || txtCapacidad.Text.Length > 20)
                    {
                        MessageBox.Show("Por favor, ingrese solo números para la capacidad del vehículo y asegúrese de que no exceda los 20 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!Validators.ValidarSoloNumeros(txtKilometraje.Text))
                    {
                        MessageBox.Show("Por favor, ingrese solo números para el kilometraje O El rango es muy corto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!Validators.ValidarNombreApellido(txtMarca.Text))
                    {
                        MessageBox.Show("Por favor, ingrese un valor válido para la marca del vehículo O El rango es muy corto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!Validators.ValidarNombreApellido(txtModelo.Text))
                    {
                        MessageBox.Show("Por favor, ingrese un valor válido para el modelo del vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (comboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, Asigne un conductor ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string selectedItem = comboBox1.SelectedItem?.ToString();
                        string idString = Regex.Match(selectedItem, @"\d+").Value;



                        Automovil auto = new Automovil();
                        auto.marca = txtMarca.Text;
                        auto.modelo = txtModelo.Text;
                        auto.id_conductor = Convert.ToInt32(idString);
                        auto.fabricacion = dateTimePicker1.Value;
                        auto.capacidad = txtCapacidad.Text;
                        auto.kilometraje = txtKilometraje.Text;
                        auto.placa = txtPlaca.Text;
                        bool creado = LogAutos.Instancia.create_auto(auto);

                        if (creado)
                        {
                            MessageBox.Show("Vehiculo Creado y Asignado Correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Error al Crear vehiculo");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error: Faltan datos. Por favor, complete todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //string selectedItem = comboBox1.SelectedItem.ToString();


            //string idString = Regex.Match(selectedItem, @"\d+").Value;
            //MessageBox.Show(idString);
            this.Close();
        }
    }
}

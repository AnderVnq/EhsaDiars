using CapaDatos;
using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CapaPresentacion.Conductores
{
    public partial class CrearConductor : Form
    {




        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);



        public string Dato1 { get; set; }
        private readonly ConsultaAPI _consultaAPI;
        public CrearConductor()
        {
            InitializeComponent();
            _consultaAPI = new ConsultaAPI();

        }
        ListConductores listConductores = new ListConductores();
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearConductor_Load(object sender, EventArgs e)
        {
            if (this.Dato1 != null)
            {
                Conductor conductor = LogConductor.Instancia.Get_By_Id(Convert.ToInt32(Dato1));

                if (conductor != null)
                {
                    txtNombre.Text = conductor.nombre;
                    txtApellido.Text = conductor.apellido;
                    txtDireccion.Text = conductor.direccion;
                    txtNroLicencia.Text = conductor.licencia;
                    txtTipoLicencia.Text = conductor.tipo_licencia;
                    txtDni.Text = conductor.dni;
                    txtTelefono.Text = conductor.telefono;
                    dateTimePicker1.Value = Convert.ToDateTime(conductor.fecha_contratacion);
                }
                else
                {
                    MessageBox.Show("Error al recuperar datos");
                }

                groupBox1.Visible = false;
                btnGuardar.Location = new System.Drawing.Point(150, 347);
                btnSalir.Location = new System.Drawing.Point(386, 347);
                label9.Text = "Actualizar Conductor";
                dateTimePicker1.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.Dato1 != null)
            {

                //hacer validaciones
                List<string> lista = new List<string>();
                lista.Add(this.Dato1);
                lista.Add(txtNombre.Text);
                lista.Add(txtApellido.Text);
                lista.Add(txtNroLicencia.Text);
                lista.Add(txtTipoLicencia.Text);
                lista.Add(txtTelefono.Text);
                lista.Add(txtDireccion.Text);
                lista.Add(txtDni.Text);


                bool actualiza = LogConductor.Instancia.Actualizar_conductor(lista);

                if (actualiza)
                {
                    MessageBox.Show("Datos Actualizados correctamente");
                    this.Close();
                }
            }
            else
            {
                Conductor conductor = new Conductor();

                conductor.nombre = txtNombre.Text;
                conductor.apellido = txtApellido.Text;
                conductor.licencia = txtNroLicencia.Text;
                conductor.tipo_licencia = txtTipoLicencia.Text;
                conductor.telefono = txtTelefono.Text;
                conductor.direccion = txtDireccion.Text;
                conductor.dni = txtDni.Text;
                conductor.fecha_contratacion = dateTimePicker1.Value;

                DialogResult resultado = MessageBox.Show("Confirmar Registro Conductor", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (resultado == DialogResult.OK)
                {
                    bool creado = LogConductor.Instancia.insertar_conductor(conductor);
                    if (creado)
                    {
                        MessageBox.Show("Conductor Creado Con Exito");

                        listConductores.ActualizarGridView();

                    }
                    else
                    {
                        MessageBox.Show("Error al registrar conductor");
                    }
                }


            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (Validators.ValidarDNI(txtDni.Text))
            {
                ConsultaCliente(txtDni.Text);
            }
            else if (Validators.ValidarRepeticion(txtDni.Text, 4))
            {
                MessageBox.Show("Error DNI no valido");
            }
            else
            {
                MessageBox.Show("Error DNI no valido");
            }
            
        }


        private void ConsultaCliente(string dni)
        {

            //string ruc= "https:// dni ru c.apisperu .com/api/v1/ruc/poner aca el ruc?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Im5kcnNudmVuZWdhc0BnbWFpbC5jb20ifQ.LO89ABUgdQavZhRqnBTh6K2kLfX3st3cT5o8Evdiqk4"
            try
            {
                if (dni.Length == 8)
                {
                    //dynamic respuesta = _consultaAPI.get($"https://dniruc.apisperu.com/api/v1/dni/{dni}?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Im5kcnNudmVuZWdhc0BnbWFpbC5jb20ifQ.LO89ABUgdQavZhRqnBTh6K2kLfX3st3cT5o8Evdiqk4");
                    dynamic respuesta = _consultaAPI.get($"https://api.sunat.dev/dni/{dni}?apikey=gfoKM4J0r69OxS0ez8sPuCPsXuafVhTY4rvtdegghVoWEfQcvztRyQUmxuVmjeD9");
                    //MessageBox.Show($"nombre: {respuesta.nombres} \n apellido: {respuesta.apellidoPaterno} \n {respuesta.apellidoMaterno}");
                    if (respuesta != null && respuesta.body != null)
                    {
                        MessageBox.Show("Informacion validada con exito", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Accede a 'apePaterno' dentro de 'body'
                        txtNombre.Text = $"{respuesta.body.preNombres}";
                        txtApellido.Text = respuesta.body.apePaterno;
                        txtDireccion.Text = respuesta.body.desDireccion;
                        string fechaString = respuesta.body.feNacimiento;
                        DateTime fechaNacimiento = DateTime.ParseExact(fechaString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        dateTimePicker1.Value = fechaNacimiento;
                        //MessageBox.Show($"response {respuesta.body.feNacimiento}");

                    }
                    else
                    {
                        MessageBox.Show("La respuesta de la API no tiene el formato esperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

using CapaEntidad;
using CapaLogica;
using CapaPresentacion.Conductores;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Contratista
{
    public partial class formContratistas : Form
    {

        private readonly ConsultaAPI _consultaAPI;
        public formContratistas()
        {
            InitializeComponent();
            _consultaAPI = new ConsultaAPI();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (Validators.ValidarSoloNumeros(txtRucConsulta.Text))
            {
                ConsultaRuc(txtRucConsulta.Text);
            }
            else
            {
                MessageBox.Show("Ingrese Datos Correctos a la Consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ConsultaRuc(string ruc)
        {

            //string ruc= "https:// dni ru c.apisperu .com/api/v1/ruc/poner aca el ruc?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Im5kcnNudmVuZWdhc0BnbWFpbC5jb20ifQ.LO89ABUgdQavZhRqnBTh6K2kLfX3st3cT5o8Evdiqk4"
            try
            {
                if (ruc.Length >= 11 && Validators.ValidarSoloNumeros(ruc))
                {
                    //dynamic respuesta = _consultaAPI.get($"https://api.sunat.dev/dni/{dni}?apikey=gfoKM4J0r69OxS0ez8sPuCPsXuafVhTY4rvtdegghVoWEfQcvztRyQUmxuVmjeD9");
                    dynamic respuesta = _consultaAPI.get($"https://api.sunat.dev/ruc-premium/{ruc}?apikey=gfoKM4J0r69OxS0ez8sPuCPsXuafVhTY4rvtdegghVoWEfQcvztRyQUmxuVmjeD9");

                    if (respuesta != null && respuesta.body != null)
                    {
                        var resp = respuesta.statusCode;
                        Console.WriteLine(resp);
                        if (respuesta.statusCode == 400)
                        {
                            string errorMessage = respuesta.body.errors[0].message;
                            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (respuesta.statusCode == 200)
                        {
                            MessageBox.Show("Informacion validada con exito", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtRuc.Text = $"{respuesta.body.numeroRuc}";
                            txtRazonSocial.Text = respuesta.body.datosContribuyente.desRazonSocial;

                            string actividadEconomicaString = respuesta.body.actividadEconomica[0];
                            string[] resultadoSplit = actividadEconomicaString.Split(new string[] { " - " }, StringSplitOptions.None);
                            MessageBox.Show(resultadoSplit[2], "aviso");
                            txtEspecialidad.Text = resultadoSplit[2];
                            txtContacto.Text = respuesta.body.datosContribuyente.contacto.numTelefono1 != "-" ? respuesta.body.datosContribuyente.contacto.numTelefono1
                                              : respuesta.body.datosContribuyente.contacto.numTelefono2 != "-" ? respuesta.body.datosContribuyente.contacto.numTelefono2
                                              : respuesta.body.datosContribuyente.contacto.numTelefono3;

                            txtDireccion.Text = respuesta.body.datosContribuyente.desDireccion;
                            txtCorreo.Text = respuesta.body.datosContribuyente.codCorreo1 != "-" ? respuesta.body.datosContribuyente.codCorreo1
                                          : respuesta.body.datosContribuyente.codCorreo2 != "-" ? respuesta.body.datosContribuyente.codCorreo2
                                          : respuesta.body.datosContribuyente.codCorreo3;

                        }
                        else if (respuesta.statusCode == 404)
                        {
                            MessageBox.Show("Error al traer informacion Dni no valido", "Error");
                        }
                        else
                        {
                            MessageBox.Show("La respuesta de la API no tiene el formato esperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La respuesta de la API no tiene el formato esperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error en el Numero de Ruc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (WebException webEx)
            {
                if (webEx.Response != null)
                {
                    using (var errorResponse = (HttpWebResponse)webEx.Response)
                    {
                        if (errorResponse.StatusCode == HttpStatusCode.NotFound)
                        {
                            MessageBox.Show("DNI no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                            {
                                string errorText = reader.ReadToEnd();
                                dynamic errorData = JsonConvert.DeserializeObject(errorText);
                                string errorMessage = errorData?.body?.errors[0]?.message ?? "Error desconocido.";
                                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error al conectar con la API.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formContratistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LogContratista.Instancia.listar_contratistas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validators.ValidarSoloNumeros(txtRuc.Text))
            {
                MessageBox.Show("El RUC debe contener solo números y tener al menos 4 dígitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Validators.ValidarSoloNumeros(txtContacto.Text))
            {
                MessageBox.Show("El número de contacto debe contener solo números.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Validators.ValidarTexto(txtEspecialidad.Text))
            {
                MessageBox.Show("La especialidad debe contener solo letras.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Contratistas contratista = new Contratistas();
                contratista.razon_Social = txtRazonSocial.Text;
                contratista.nro_Documento = txtRuc.Text;
                contratista.tipo_documento = "RUC";
                contratista.direccion = txtDireccion.Text;
                contratista.especialidad = txtEspecialidad.Text;
                contratista.correo = txtCorreo.Text;
                contratista.nro_Contacto = txtContacto.Text;

                DialogResult resultado = MessageBox.Show("Confirmar Registro Conductor", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (resultado == DialogResult.OK)
                {
                    bool creado = LogContratista.Instancia.crearContratista(contratista);
                    if (creado)
                    {
                        MessageBox.Show("Conductor Creado Con Exito");

                        dataGridView1.Refresh();
                        dataGridView1.DataSource = LogContratista.Instancia.listar_contratistas();

                    }
                    else
                    {
                        MessageBox.Show("Error al registrar conductor");
                    }
                }
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
                if (id != null)
                {
                    bool resultado = LogContratista.Instancia.eliminarContratista(Convert.ToInt32(id));
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = LogContratista.Instancia.listar_contratistas();
                }
                else
                {
                    MessageBox.Show("Error en los datos", "Error");
                }
            }
        }
    }
}

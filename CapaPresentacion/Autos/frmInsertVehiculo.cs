using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Autos
{
    public partial class frmInsertVehiculo : Form
    {

        public string Dato1 { get; set; }
        public frmInsertVehiculo()
        {
            InitializeComponent();
        }

        private void frmInsertVehiculo_Load(object sender, EventArgs e)
        {
            List<Conductor> conductores = LogAutos.Instancia.Conduc_sin_asignar();
            foreach (Conductor con in conductores)
            {
                comboBox1.Items.Add($"Conductor: {con.nombre}; licencia: {con.tipo_licencia}");
            }
            if (this.Dato1 != null)
            {
                //Conductor conductor = LogConductor.Instancia.Get_By_Id(Convert.ToInt32(Dato1));

                //if (conductor != null)
                //{

                //}
                //else
                //{
                //    MessageBox.Show("Error al recuperar datos");
                //}

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

        }

        private void Editar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

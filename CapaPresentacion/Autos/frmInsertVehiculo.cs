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
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}

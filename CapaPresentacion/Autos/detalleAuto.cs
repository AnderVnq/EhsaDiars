using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Autos
{
    public partial class detalleAuto : Form
    {


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public string dato { get; set; }
        public detalleAuto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void detalleAuto_Load(object sender, EventArgs e)
        {
            if (dato == null || dato.Length == 0)
            {
                MessageBox.Show("Error al Mostrar Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<string> list = LogAutos.Instancia.detalle(Convert.ToInt32(dato));

                txtPlaca.Text = list[0];
                txtMotor.Text = list[1];
                txtCombus.Text = list[2];
                txtCilindros.Text = list[3];
                txtPuertas.Text = list[4];
                txtCvelocidades.Text = list[5];
                txtAro.Text = list[6];
                txtFpost.Text = list[7];
                txtFrenoDel.Text = list[8];
                txtAlto.Text = list[9];
                txtAncho.Text = list[10];
                txtFaros.Text = list[11];
                txtNeumatico.Text = list[12];

            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

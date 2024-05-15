using CapaEntidad;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion.Mantenimiento
{
    public partial class ManteInterno : Form
    {


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);


        public ManteInterno()
        {
            InitializeComponent();
            comboMante.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTaller.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void ManteInterno_Load(object sender, EventArgs e)
        {
            List<entMantenimiento> lista = LogMantenimiento.Instancia.mantenimientos_disp();

            foreach (entMantenimiento m in lista)
            {
                comboMante.Items.Add($"ID: {m.id}; Vehiculo: {m.placa_vehiculo}");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion.Mantenimiento
{
    public partial class ManteExterno : Form
    {


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public ManteExterno()
        {
            InitializeComponent();
            comboMante.DropDownStyle = ComboBoxStyle.DropDownList;
            comboContratista.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void ManteExterno_Load(object sender, EventArgs e)
        {
            List<entMantenimiento> lista = LogMantenimiento.Instancia.mantenimientos_disp();

            foreach (entMantenimiento m in lista)
            {
                comboMante.Items.Add($"ID: {m.id} - Vehiculo: {m.placa_vehiculo}");
            }


            List<Contratistas> lista_contratista = LogContratista.Instancia.listar_contratistas();

            foreach (Contratistas c in lista_contratista)
            {
                comboContratista.Items.Add($"ID: {c.id} - Razon Social: {c.razon_Social}");
            }


            dataGridView1.DataSource=LogContratista.Instancia.listar_ordenes();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            
            string selectedItem = comboMante.SelectedItem?.ToString() ?? "";
            string idString = Regex.Match(selectedItem, @"\d+").Value;

            string selectedItem_contratista = comboContratista.SelectedItem?.ToString() ?? "";
            string idString_contratista = Regex.Match(selectedItem_contratista, @"\d+").Value;

            MessageBox.Show($"{idString.Trim()}");
            MessageBox.Show($"{idString_contratista.Trim()}");


        }
    }
}

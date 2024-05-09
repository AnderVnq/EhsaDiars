using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}

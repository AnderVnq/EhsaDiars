using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Pagos
{
    public partial class FormPagos : Form
    {
        public FormPagos()
        {
            InitializeComponent();
            InicializarTimer();
        }

        private void FormPagos_Load(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString();
            lblprecio.Text = "S/500";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString();
        }       

        private void InicializarTimer(){
            timer1.Interval = 1000; // 1 segundo
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
    }
}

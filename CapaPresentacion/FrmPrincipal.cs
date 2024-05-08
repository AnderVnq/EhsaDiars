using CapaLogica;
using CapaPresentacion.Autos;
using CapaPresentacion.Conductores;
using CapaPresentacion.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

        }
        frmListAutos formAutos = new frmListAutos();
        ListConductores formConductores = new ListConductores();
        register formRegister = new register();

        private void abrir_form_hija(object frmHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = frmHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConductor_Click(object sender, EventArgs e)
        {
            abrir_form_hija(formConductores);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            abrir_form_hija(formAutos);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            btnAuto.Enabled = false;
            btnConductor.Enabled = false;
            btnMante.Enabled = false;
            btnPagos.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Length <= 10 && txtusuario.Text != null && txtusuario.Text != "")
            {
                string contraseña = txtContraseña.Text;
                string username = txtusuario.Text;

                bool valid_user = LogAuthUser.Instancia.validate_user(username, contraseña);
                bool response = LogAuthUser.Instancia.validate_session(username);

                if (valid_user)
                {
                    if (response)
                    {
                        MessageBox.Show("Erro al iniciar sesion , sesion ya iniciada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Session Iniciada con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnAuto.Enabled = false;
                        btnConductor.Enabled = false;
                        btnMante.Enabled = false;
                        btnPagos.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no Encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            txtContraseña.Text = "";
            txtusuario.Text = "";

        }
    }
}

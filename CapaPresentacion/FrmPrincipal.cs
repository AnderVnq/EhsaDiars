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
        List<Control> controles = new List<Control>();
        string usuario = null;
        string password = null;
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
            btnCerrarSesion.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Length <= 10 && txtusuario.Text != null && txtusuario.Text != "")
            {
                password = txtContraseña.Text;
                usuario = txtusuario.Text;

                bool valid_user = LogAuthUser.Instancia.validate_user(usuario, password);
                bool response = LogAuthUser.Instancia.validate_session(usuario);

                if (valid_user)
                {
                    if (response)
                    {
                        MessageBox.Show("Erro al iniciar sesion , sesion ya iniciada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        bool login = LogAuthUser.Instancia.login(usuario, password);
                        if (login)
                        {
                            MessageBox.Show("Session Iniciada con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnAuto.Enabled = true;
                            btnConductor.Enabled = true;
                            btnMante.Enabled = true;
                            btnPagos.Enabled = true;
                            btnCerrarSesion.Visible = true;
                        }
                        while (this.panelContenedor.Controls.Count > 0)
                        {
                            Control controlEliminado = this.panelContenedor.Controls[0];
                            controles.Add(controlEliminado);
                            this.panelContenedor.Controls.RemoveAt(0);
                        }
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            bool cerrado = LogAuthUser.Instancia.logout(usuario);
            string a = usuario;
            if (cerrado)
            {
                MessageBox.Show("cerrado");

            }
            else
            {
                MessageBox.Show("error");
            }
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            foreach (Control item in controles)
            {
                this.panelContenedor.Controls.Add(item);

            }

            btnAuto.Enabled = true;
            btnConductor.Enabled = true;
            btnMante.Enabled = true;
            btnPagos.Enabled = true;
            btnCerrarSesion.Visible = false;
            txtContraseña.Text = "";
            txtusuario.Text = "";
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {
            register formRegister = new();
            formRegister.ShowDialog();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cerrar la aplicación?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario hace clic en "No", cancelar el cierre del formulario
            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if (!string.IsNullOrEmpty(txtusuario.Text) && !string.IsNullOrEmpty(txtContraseña.Text))
                {
                    bool valid = LogAuthUser.Instancia.validate_user(txtusuario.Text, txtContraseña.Text);
                    if (!valid)
                    {
                        txtContraseña.Text = "";
                        txtusuario.Text = "";
                    }
                    else
                    {
                        _ = LogAuthUser.Instancia.logout(txtusuario.Text);
                    }

                }
            }
        }




    }
}

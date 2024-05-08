using CapaEntidad;
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
using System.Runtime.InteropServices;

namespace CapaPresentacion.Usuarios
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private bool ValidarDNI(string dni)
        {
            // Verificar que el DNI tenga exactamente 8 caracteres
            if (dni.Length != 8)
            {
                return false;
            }

            // Verificar que todos los caracteres del DNI sean dígitos
            foreach (char c in dni)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            bool todosIguales = true;
            char primerDigito = dni[0];
            foreach (char c in dni)
            {
                if (c != primerDigito)
                {
                    todosIguales = false;
                    break;
                }
            }

            if (todosIguales)
            {
                return false;
            }

            // Si pasa todas las validaciones, el DNI es válido
            return true;
        }

        private bool EsTexto(string cadena)
        {
            foreach (char c in cadena)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtApellidopat.Text) ||
                string.IsNullOrEmpty(txtApellidomat.Text) ||
                string.IsNullOrEmpty(txtdni.Text) ||
                string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtPasword.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!EsTexto(txtNombre.Text) || !EsTexto(txtApellidopat.Text) || !EsTexto(txtApellidomat.Text))
            {
                MessageBox.Show("El nombre y los apellidos no deben contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ValidarDNI(txtdni.Text))
                {
                    bool user_exists = LogAuthUser.Instancia.validate_user(txtUsername.Text, txtPasword.Text);
                    if (user_exists) { MessageBox.Show("Usuario ya registrado"); }

                    Usuario usuario = new();
                    usuario.nombre = txtNombre.Text;
                    usuario.apellido_pat = txtApellidopat.Text;
                    usuario.apellido_mat = txtApellidomat.Text;
                    usuario.dni = txtdni.Text;
                    usuario.username = txtUsername.Text;
                    usuario.password = txtPasword.Text;


                    bool create_user = LogAuthUser.Instancia.crear_usuario(usuario);
                    if (create_user)
                    {
                        MessageBox.Show("Usuario Creado Correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Text = "";
                        txtApellidopat.Text = "";
                        txtApellidomat.Text = "";
                        txtdni.Text = "";
                        txtUsername.Text = "";
                        txtPasword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Usuario ya registrado con esos datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El Dni no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
    }
}

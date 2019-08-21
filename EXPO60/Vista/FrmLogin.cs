using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using EXPO60.Controlador;
using EXPO60.Modelo;
using System.Runtime.InteropServices;

namespace EXPO60.Vista
{
    public partial class FrmLogin : Form
    {
        #region Dlls para mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        const int GRIP_SIZE = 15;
        int w = 0;
        int h = 0;
        #endregion
        public FrmLogin()
        {
            InitializeComponent();
        }
        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }
        private void btbAcceder_Click(object sender, EventArgs e)
        {
            Validar();
        }
        void Validar()
        {
            if (txtUsuario.Text.Trim() == "" || txtContra.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                ContructorLogin log = new ContructorLogin(txtUsuario.Text, txtContra.Text);
                ContructorLogin.usuario = txtUsuario.Text;
                log.clave = txtCifrado.Text;
                
                //Recuperando el valor de retorno
                bool datos = ValidarLogin.Acceso(log);
                //
                if (datos == true)
                {
                    FrmNuevo principal = new FrmNuevo();
                    principal.Show();
                    this.Hide();
                }
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = true;
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtContra.Text.ToString());
            txtCifrado.Text = Hash(pass);
        }

        private void linkPrimerUso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPrimerUso principal = new FrmPrimerUso();
            principal.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recuperarUsuario recu = new recuperarUsuario();
            recu.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCifrado_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolbtnCerra_Aplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }
    }
}

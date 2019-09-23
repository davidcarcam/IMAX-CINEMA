using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using EXPO60.Controlador;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using EXPO60.Modelo;

namespace EXPO60.Vista
{
    public partial class FrmRecuperar_administrador : Form
    {
        public FrmRecuperar_administrador()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }


        private void BtnPemitir_Click(object sender, EventArgs e)
        {
            ValidarAdmin();
        }
        void VerificarAdmin()
        {
            if (ConstructorRecuperar_admin.nivel <= 2)

            {
                MessageBox.Show("Acceso concedido exitosamente", "Acceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpUsuario.Enabled = true;
                txtContraseñaRecuperar.Enabled = false;
                BtnCambiarContraseña.Enabled = false;
                txtClaveAdmin.Visible = false;
                txtUsuarioAdmin.Visible = false;
                grpAdmin.Enabled = false;

            }

            else
            {
                MessageBox.Show("El usuario ingresado no es un Administrador", "Error al conceder permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ValidacionAdminRoot()
        {
            if (ConstructorRecuperar_admin.nivelRecu <= 2)

            {
                MessageBox.Show("No puedes recuperar un usuario de tipo Administrador o Root", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Ingrese la nueva contraseña", "Usuario encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnValidar.Enabled = false;
                BtnCambiarContraseña.Enabled = true;
                txtContraseñaRecuperar.Enabled = true;
                txtUsuarioRecuperar.Enabled = false;
            }
        }
        void ValidarAdmin()
        {
            if (txtUsuarioAdmin.Text.Trim() == "" || txtClaveAdmin.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar los datos que se le solicitan", "Existen campos vacios ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else

            {
                ConstructorRecuperar_admin rec = new ConstructorRecuperar_admin(txtUsuarioAdmin.Text, txtClaveAdmin.Text);
                ConstructorRecuperar_admin.usuario = txtUsuarioAdmin.Text;
                rec.clave = txtEncriptado.Text;
                bool datos = ValidarRecuperar_admin.ValidarUsu(rec);

                if (datos == true)
                {
                    VerificarAdmin();

                }
            }
        }
        void cambiarclave()
        {
            if (txtContraseñaRecuperar.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la nueva contraseña", "Complete el campo solicitado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else

            {

                ConstructorRecuperar_admin contrasena = new ConstructorRecuperar_admin(txtContraseñaRecuperar.Text, txtUsuarioRecuperar.Text);
                ConstructorRecuperar_admin.usuario = txtUsuarioRecuperar.Text;
                contrasena.clave = txtencriptado2.Text;
                bool datos = ValidarRecuperar_admin.clave(contrasena);

                if (datos == true)
                {
                    MessageBox.Show("La contraseña del usuario" + " " + ConstructorRecuperar_admin.usuario + " " + "fue actualizada correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmLogin kk = new FrmLogin();
                    kk.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("No se puede conceder permisos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtClaveAdmin.UseSystemPasswordChar == true)
            {
                txtClaveAdmin.UseSystemPasswordChar = false;
            }
            else if (txtClaveAdmin.UseSystemPasswordChar == false)
            {
                txtClaveAdmin.UseSystemPasswordChar = true;
            }
        }
        void validarUsuario()
        {
            if (txtUsuarioRecuperar.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el usuario que desea recuperar", "Complete el campo solicitado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else

            {

                ConstructorRecuperar_admin validar = new ConstructorRecuperar_admin(txtUsuarioRecuperar.Text, txtContraseñaRecuperar.Text);
                ConstructorRecuperar_admin.usuarioRecu = txtUsuarioRecuperar.Text;
                bool datos = ValidarRecuperar_admin.Validar(validar);

                if (datos == true)
                {
                    ValidacionAdminRoot();
                }

                else
                {
                    MessageBox.Show("No se puede conceder permisos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            validarUsuario();
        }

        private void BtnCambiarContraseña_Click(object sender, EventArgs e)
        {
            cambiarclave();
        }
    }
}

using EXPO60.Controlador;
using EXPO60.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXPO60.Vista
{
    public partial class RecuAdmin : Form
    {
        public RecuAdmin()
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
        private void ValidacionAdminRoot()
        {
            if (ConstructorRecuperarClave.nivelRecu <= 2)

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
        void validarUsuario()
        {
            if (txtUsuarioRecuperar.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el usuario que desea recuperar", "Complete el campo solicitado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else

            {

                ConstructorRecuperarClave validar = new ConstructorRecuperarClave(txtUsuarioRecuperar.Text, txtContraseñaRecuperar.Text);
                ConstructorRecuperarClave.usuarioRecu = txtUsuarioRecuperar.Text;
                bool datos = validarRecuperar.Validar(validar);

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
        void cambiarclave()
        {
            if (txtContraseñaRecuperar.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la nueva contraseña", "Complete el campo solicitado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else

            {

                ConstructorRecuperarClave contrasena = new ConstructorRecuperarClave(txtContraseñaRecuperar.Text, txtUsuarioRecuperar.Text);
                ConstructorRecuperarClave.usuario = txtUsuarioRecuperar.Text;
                contrasena.clave = txtencriptado2.Text;
                bool datos = validarRecuperar.clave(contrasena);

                if (datos == true)
                {
                    MessageBox.Show("La contraseña del usuario" + " " + ConstructorRecuperarClave.usuario + " " + "fue actualizada correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void VerificarAdmin()
        {
            if (ConstructorRecuperarClave.nivel <= 2)

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

        void ValidarAdmin()
        {
            if (txtUsuarioAdmin.Text.Trim() == "" || txtClaveAdmin.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar los datos que se le solicitan", "Existen campos vacios ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else

            {
                ConstructorRecuperarClave rec = new ConstructorRecuperarClave(txtUsuarioAdmin.Text, txtClaveAdmin.Text);
                ConstructorRecuperarClave.usuario = txtUsuarioAdmin.Text;
                rec.clave = txtEncriptado.Text;
                bool datos = validarRecuperar.ValidarUsu(rec);

                if (datos == true)
                {
                    VerificarAdmin();

                }
            }
        }

        private void txtClaveAdmin_TextChanged(object sender, EventArgs e)
        {
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtClaveAdmin.Text.ToString());
            txtEncriptado.Text = Hash(pass);
        }

        private void BtnPemitir_Click(object sender, EventArgs e)
        {
            ValidarAdmin();
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

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            validarUsuario();
        }

        private void BtnCambiarContraseña_Click(object sender, EventArgs e)
        {
            cambiarclave();
        }

        private void txtContraseñaRecuperar_TextChanged(object sender, EventArgs e)
        {
            txtContraseñaRecuperar.UseSystemPasswordChar = true;
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtContraseñaRecuperar.Text.ToString());
            txtencriptado2.Text = Hash(pass);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin kstr = new FrmLogin();
            kstr.Show();
        }
    }
}

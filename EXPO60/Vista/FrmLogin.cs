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

namespace EXPO60.Vista
{
    public partial class FrmLogin : Form
    {
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
    }
}

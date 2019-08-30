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
using EXPO60.Modelo;
using EXPO60.Controlador;


namespace EXPO60.Vista
{
    public partial class ConfirmarContraseña : Form
    {
        public ConfirmarContraseña()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = true;
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtContra.Text.ToString());
            txtCifrado.Text = Hash(pass);
            if (txt1.Text == txtContra.Text)
            {
                lblcontra.Visible = false;
            }
            else
            {
                lblcontra.Visible = true;
            }
        }
        private void toolbtnCerra_Aplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt1.Text.Trim() == "" || txtContra.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos vacion", "Falta informacion",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ContructorLogin2.clave = txtCifrado.Text;
                ValidarLogin.ActualizarContraseña();
            }
        }
        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }
    }
}

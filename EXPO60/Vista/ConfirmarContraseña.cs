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
        private void toolbtnCerra_Aplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }
        private void txtContra_TextChanged(object sender, EventArgs e)
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
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txt1.Text.Trim() == "" || txtContra.Text.Trim() == "" || txt1.Text != txtContra.Text)
            {
                MessageBox.Show("Existen campos vacios", "Falta informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt1.Text != txtContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden, por favor verifique que los campos sean correctos", "Error de verificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ContructorLogin2.clave = txtCifrado.Text;
                ValidarLogin.ActualizarContraseña();
                FrmMetodos_Recuperar c = new FrmMetodos_Recuperar();
                c.Close();
                ConfirmarContraseña a = new ConfirmarContraseña();
                a.Close();
                FrmLogin p = new FrmLogin();
                p.Show();
                this.Close();
            }
        }
        private void txt1_TextChanged_1(object sender, EventArgs e)
        {
            txt1.UseSystemPasswordChar = true;
        }
    }
}

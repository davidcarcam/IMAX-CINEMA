using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXPO60.Modelo;
using System.Windows.Forms;
using EXPO60.Controlador;
using System.Security.Cryptography;

namespace EXPO60.Vista
{
    public partial class FrmPrimerUso : Form
    {
        public FrmPrimerUso()
        {
            InitializeComponent();
        }
        Constructor_primerUso agr = new Constructor_primerUso();
        public void mostrarET()
        {

            cmbTip.DataSource = Funciones_primerUso.ObtenerTipoUsuario();
            cmbTip.DisplayMember = "tipo_usu";
            cmbTip.ValueMember = "id_tipo_usu";

            cmbEst.DataSource = Funciones_primerUso.ObtenerEstado();
            cmbEst.DisplayMember = "estado_usu";
            cmbEst.ValueMember = "id_estado_usu";

        }
        public void AgregarUsu()
        {
            if (txtApe.Text.Trim() == "" || txtCla.Text.Trim() == "" || txtCor.Text.Trim() == ""
                || txtDir.Text.Trim() == "" || txtDui.Text.Trim() == ""
                || txtNom.Text.Trim() == "" || txtTel.Text.Trim() == "" || txtUsu.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                agr.nombre = txtNom.Text;
                agr.direccion = txtDir.Text;
                agr.apellido = txtApe.Text;
                agr.clave = txtCla.Text;
                agr.correo = txtCor.Text;
                agr.dui = txtDui.Text;
             
                agr.telefono = txtTel.Text;
                agr.usuario = txtUsu.Text;
                agr.tipo = Convert.ToInt16(cmbTip.SelectedValue);
                agr.estado = Convert.ToInt16(cmbEst.SelectedValue);
                int datos = Funciones_primerUso.ingresarusuario(agr);
            }
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnIngUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsu();
            FrmLogin principal = new FrmLogin();
            principal.Show();
            this.Hide();
        }

        private void txtCla_TextChanged(object sender, EventArgs e)
        {
            txtCla.UseSystemPasswordChar = true;
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtCla.Text.ToString());
            txtCifrado.Text = Hash(pass);
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtUsu_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FrmPrimerUso_Load(object sender, EventArgs e)
        {
            mostrarET();
        }
        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }

        private void txtCifrado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

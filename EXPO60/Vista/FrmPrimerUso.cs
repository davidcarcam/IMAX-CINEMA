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
            cmbTip.DisplayMember = "tipo_usuario";
            cmbTip.ValueMember = "id_tipo_usuario";

            cmbEst.DataSource = Funciones_primerUso.ObtenerEstado();
            cmbEst.DisplayMember = "estado";
            cmbEst.ValueMember = "id_estado";

        }
        public void AgregarUsu()
        {
            if (txtApe.Text.Trim() == "" || txtCla.Text.Trim() == "" || txtCor.Text.Trim() == ""
                || txtDir.Text.Trim() == "" || txtDui.Text.Trim() == "" || txtNac.Text.Trim() == ""
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
                agr.fecha = txtNac.Text;
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

        }

        private void txtCla_TextChanged(object sender, EventArgs e)
        {
            txtCla.UseSystemPasswordChar = true;
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
    }
}

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
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace EXPO60.Vista
{
    public partial class FrmPrimerUso : Form
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

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir del formulario del primer usuario y cerrar la aplicacion","Cerrar Aplicacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnCargar_Foto_Click(object sender, EventArgs e)
        {
            try
            {
                ofpPrimer_Usuario.Filter = "Archivo de imagen (.jpg) | *.jpg | Archivos de Imagen (.png) | *.png | Archivos de Imagen (jpeg) | *jpeg | Todos los Archivos |*.*";
                DialogResult Resultado1 = ofpPrimer_Usuario.ShowDialog();
                if (Resultado1 == DialogResult.OK)
                {
                    picPerfil_image.Image = Image.FromFile(ofpPrimer_Usuario.FileName);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Sucedio un problema durante el proceso, por favor contacte con el administrador", "Error" + a.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnIngUsuario_Click_1(object sender, EventArgs e)
        {

        }

        private void ToolStripPrimer_Usuario_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        private void FrmPrimerUso_Resize(object sender, EventArgs e)
        {
            
        }
    }
}

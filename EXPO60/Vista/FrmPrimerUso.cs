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
        Form currentForm;
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //Buscar la coleccion del formulario
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                if (currentForm != null)
                {
                    currentForm.Close();
                    panelContenedor.Controls.Remove(currentForm);
                }

                currentForm = formulario;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }

        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            foreach (var control in panelContenedor.Controls)
            {
                if (control is FrmLogin)
                {

                }
                else if (control is FrmNuevo)
                {

                }
                else if (control is FrmPrimerUso)
                {

                }
                else
                {

                }
            }
        }
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
        private const Keys CopyKeys = Keys.Control | Keys.C;
        private const Keys PasteKeys = Keys.Control | Keys.V;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == CopyKeys) || (keyData == PasteKeys))
            {
                Clipboard.Clear();
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
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
            agr.nombre = txtNom.Text;
            agr.direccion = txtDir.Text;
            agr.apellido = txtApe.Text;
            Constructor_primerUso.clave = txtCifrado.Text;
            agr.correo = txtCor.Text;
            agr.dui = txtDui.Text;
            agr.telefono = txtTel.Text;
            agr.usuario = txtUsu.Text;
            agr.tipo = Convert.ToInt16(cmbTip.SelectedValue);
            agr.estado = Convert.ToInt16(cmbEst.SelectedValue);
            int datos = Funciones_primerUso.ingresarusuario(agr);
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
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       
        private void ToolStripPrimer_Usuario_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }
        private void txtCla_TextChanged_1(object sender, EventArgs e)
        {
            txtCla.UseSystemPasswordChar = true;
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtCla.Text.ToString());
            txtCifrado.Text = Hash(pass);
        }
        private void btnIngUsuario_Click_2(object sender, EventArgs e)
        {
            if (txtCla.Text != txtContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden, por favor verifique que sean iguales e intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtApe.Text.Trim() == "" || txtCla.Text.Trim() == "" || txtCor.Text.Trim() == ""
                || txtDir.Text.Trim() == "" || txtDui.Text.Trim() == ""
                || txtNom.Text.Trim() == "" || txtTel.Text.Trim() == "" || txtUsu.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos vacios", "Campos vacios",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                AgregarUsu();
                FrmAgregar_empresa principal = new FrmAgregar_empresa();
                principal.Show();
                this.Hide();
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
        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = true;
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtContra.Text.ToString());
            txtCifrado.Text = Hash(pass);
            if (txtCla.Text == txtContra.Text)
            {
                label13.Visible = false;
            }
            else
            {
                label13.Visible = true;
            }
        }
        private void txtCla_TextChanged_2(object sender, EventArgs e)
        {
            txtCla.UseSystemPasswordChar = true;
        }
    }
}

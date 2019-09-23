using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXPO60.Vista;
using System.Runtime.InteropServices;
using System.Threading;

namespace EXPO60.Vista
{
    public partial class FrmMetodos_Recuperar : Form
    {
        Form currentForm;
        #region Dlls para mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        const int GRIP_SIZE = 15;
        int w = 0;
        int h = 0;
        #endregion
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelMetodo_Mostrar.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {

                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                if (currentForm != null)
                {
                    currentForm.Close();
                    panelMetodo_Mostrar.Controls.Remove(currentForm);
                }
                currentForm = formulario;
                panelMetodo_Mostrar.Controls.Add(formulario);
                panelMetodo_Mostrar.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
        public FrmMetodos_Recuperar()
        {
            InitializeComponent();
        }

        private void BtntoolCerrar_Metodos_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void ToolStripMetodos_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        

        private void MenuItemPreguntas_Recuperacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRecuperar_Preguntas>();
        }

        private void MenuItemContactar_Administrador_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRecuperar_administrador>();
        }

        private void MenuItemCorreo_Recuperacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario<recuperarUsuario>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using EXPO60.Controlador;
using MySql.Data.MySqlClient;

namespace EXPO60.Vista
{
    public partial class FrmNuevo : Form
    {
        public FrmNuevo()
        {
            InitializeComponent();
        }
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
            formulario = PanelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {

                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                if (currentForm != null)
                {
                    currentForm.Close();
                    PanelContenedor.Controls.Remove(currentForm);
                }
                currentForm = formulario;
                PanelContenedor.Controls.Add(formulario);
                PanelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
                picimg.Visible = true;
                picimgL.Visible = false;
            }
            else
            {
                MenuVertical.Width = 250;
                picimg.Visible = false;
                picimgL.Visible = true;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar la aplicacion","Salir de la aplicacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            btnmaximizar.Visible = false;
            btnnormal.Visible = true;
            WindowState = FormWindowState.Maximized;
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void btnNormal_Click(object sender, EventArgs e)
        {
            btnmaximizar.Visible = true;
            btnnormal.Visible = false;
            WindowState = FormWindowState.Normal;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton22_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmUsuario>();
            toolStripButton1.Visible = true;
            toolStripLabel1.Visible = true;
        }

        private void FrmNuevo_Load(object sender, EventArgs e)
        {
            btnnormal.Visible = false;
            toolStripButton1.Visible = false;
            toolStripLabel1.Visible = false;
        }

        private void bunifuFlatButton21_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmPersonajes>();
        }

        private void bunifuFlatButton20_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmTicket>();
        }

        private void bunifuFlatButton19_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmFunciones>();
        }

        private void bunifuFlatButton18_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmSala>();
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmAsientos>();
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmPelicula>();
        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmProveedores>();
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmProducto>();
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frmalimentos>();
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frmfacturalocal>();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmBotones>();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form frm = new FrmUsuario();
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar el formulario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ToolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            btnnormal.Visible = false;
            btnmaximizar.Visible = true;
            this.Width = 1268;
            this.Height = 572;
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }


        private void ToolbtnCerrar_Sesion_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar sesion y regresar al login", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                FrmLogin login = new FrmLogin();
                login.Show();
            }
        }

        private void btnmaximizar_Click_1(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            btnmaximizar.Visible = false;
            btnnormal.Visible = true;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void btnnormal_Click_1(object sender, EventArgs e)
        {
            btnnormal.Visible = false;
            btnmaximizar.Visible = true;
            this.Width = 1268;
            this.Height = 572;
            this.CenterToScreen();
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelContenedor_Resize(object sender, EventArgs e)
        {

        }
    }
}

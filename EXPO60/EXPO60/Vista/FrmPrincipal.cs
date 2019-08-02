using EXPO60.Vista;
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


namespace EXPO60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            btnmaximizar.Visible = false;
            btnnormal.Visible = true;
            WindowState = FormWindowState.Maximized;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            btnmaximizar.Visible = true;
            btnnormal.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton22_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmUsuario>();
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmPelicula>();
        }

        private void bunifuFlatButton21_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frmpersonajes>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXPO60.Vista
{
    public partial class FrmNuevo : Form
    {
        public FrmNuevo()
        {
            InitializeComponent();
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
            Application.Exit();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            btnmaximizar.Visible = false;
            btnnormal.Visible = true;
            WindowState = FormWindowState.Maximized;
        }

        private void btnnormal_Click(object sender, EventArgs e)
        {

            btnmaximizar.Visible = true;
            btnnormal.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton22_Click(object sender, EventArgs e)
        {

        }
    }
}

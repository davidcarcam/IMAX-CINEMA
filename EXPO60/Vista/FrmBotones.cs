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
    public partial class FrmBotones : Form
    {
        public FrmBotones()
        {
            InitializeComponent();
        }

        Form currentForm;
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

        private void bunifuFlatButton22_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmUsuario>();
        }

        private void bunifuFlatButton20_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmTicket>();
        }

        private void bunifuFlatButton21_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmPersonajes>();
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

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frmfacturalocal>();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frmalimentos>();
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmTicket>();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmEmpresas>();
        }
    }
}

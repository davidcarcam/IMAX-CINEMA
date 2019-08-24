using EXPO60.Controlador;
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
        public void Ocultar()
        {
            btnusuario.Visible = false;
            btntickets.Visible = false;
            btnpersonajes.Visible = false;
            btnfactura.Visible = false;
            btnsalas.Visible = false;
            btnpeliculas.Visible = false;
            btnfunciones.Visible = false;
            btnproveedores.Visible = false;
            btnasientos.Visible = false;
            btnfaclocal.Visible = false;
            btnalimentos.Visible = false;
            btnproductos.Visible = false;
            btnidioma.Visible = false;
            btnempresa.Visible = false;
        }
        public void UbicacionRoot()
        {
            btnusuario.Location = new Point(50, 94);
            btntickets.Location = new Point(376, 94);
            btnpersonajes.Location = new Point(711, 94);
            btnfactura.Location = new Point(50, 183);
            btnsalas.Location = new Point(376, 183);
            btnpeliculas.Location = new Point(711, 183);
            btnfunciones.Location = new Point(50, 272);
            btnproveedores.Location = new Point(376, 272);
            btnasientos.Location = new Point(711, 272);
            btnfaclocal.Location = new Point(50, 361);
            btnalimentos.Location = new Point(376, 361);
            btnproductos.Location = new Point(711, 361);
            btnidioma.Location = new Point(50, 450);
            btnempresa.Location = new Point(376, 450);
        }
        void UbicacionAdministrador()
        {
            btnusuario.Location = new Point(50, 94);
            btntickets.Location = new Point(376, 94);
            btnpersonajes.Location = new Point(711, 94);
            btnfactura.Location = new Point(50, 183);
            btnsalas.Location = new Point(376, 183);
            btnpeliculas.Location = new Point(711, 183);
            btnfunciones.Location = new Point(50, 272);
            btnproveedores.Location = new Point(376, 272);
            btnasientos.Location = new Point(711, 272);
            btnfaclocal.Location = new Point(50, 361);
            btnalimentos.Location = new Point(376, 361);
            btnproductos.Location = new Point(711, 361);
            btnidioma.Location = new Point(50, 450);
            btnempresa.Location = new Point(376, 450);
            btnusuario.Visible = true;
            btntickets.Visible = true;
            btnpersonajes.Visible = true;
            btnfactura.Visible = true;
            btnsalas.Visible = true;
            btnpeliculas.Visible = true;
            btnfunciones.Visible = true;
            btnproveedores.Visible = true;
            btnasientos.Visible = true;
            btnfaclocal.Visible = true;
            btnalimentos.Visible = true;
            btnproductos.Visible = true;
            btnidioma.Visible = true;
            btnempresa.Visible = true;
        }
        void EncargadoSala()
        {
            //btnusuario.Location = new Point(50, 94);
            //btntickets.Location = new Point(376, 94);
            //btnpersonajes.Location = new Point(711, 94);
            //btnfactura.Location = new Point(50, 183);
            btnsalas.Location = new Point(376, 183);
            //btnpeliculas.Location = new Point(711, 183);
            //btnfunciones.Location = new Point(50, 272);
            //btnproveedores.Location = new Point(376, 272);
            btnasientos.Location = new Point(376, 272);
            //btnfaclocal.Location = new Point(50, 361);
            //btnalimentos.Location = new Point(376, 361);
            //btnproductos.Location = new Point(711, 361);
            //btnidioma.Location = new Point(50, 450);
            //btnempresa.Location = new Point(376, 450);
            btnusuario.Visible = false;
            btntickets.Visible = false;
            btnpersonajes.Visible = false;
            btnfactura.Visible = false;
            btnsalas.Visible = true;
            btnpeliculas.Visible = false;
            btnfunciones.Visible = false;
            btnproveedores.Visible = false;
            btnasientos.Visible = true;
            btnfaclocal.Visible = false;
            btnalimentos.Visible = false;
            btnproductos.Visible = false;
            btnidioma.Visible = false;
            btnempresa.Visible = false;
        }
        void Boletero()
        {
            //btnusuario.Location = new Point(50, 94);
            btntickets.Location = new Point(376, 272);
            //btnpersonajes.Location = new Point(711, 94);
            //btnfactura.Location = new Point(50, 183);
            //btnsalas.Location = new Point(376, 183);
            //btnpeliculas.Location = new Point(711, 183);
            //btnfunciones.Location = new Point(50, 272);
            //btnproveedores.Location = new Point(376, 272);
            //btnasientos.Location = new Point(711, 272);
            //btnfaclocal.Location = new Point(50, 361);
            //btnalimentos.Location = new Point(376, 361);
            //btnproductos.Location = new Point(711, 361);
            //btnidioma.Location = new Point(50, 450);
            //btnempresa.Location = new Point(376, 450);
            btnusuario.Visible = false;
            btntickets.Visible = true;
            btnpersonajes.Visible = false;
            btnfactura.Visible = false;
            btnsalas.Visible = false;
            btnpeliculas.Visible = false;
            btnfunciones.Visible = false;
            btnproveedores.Visible = false;
            btnasientos.Visible = false;
            btnfaclocal.Visible = false;
            btnalimentos.Visible = false;
            btnproductos.Visible = false;
            btnidioma.Visible = false;
            btnempresa.Visible = false;
        }
        void EncargadoInventario()
        {
            //btnusuario.Location = new Point(50, 94);
            //btntickets.Location = new Point(376, 94);
            //btnpersonajes.Location = new Point(711, 94);
            //btnfactura.Location = new Point(50, 183);
            //btnsalas.Location = new Point(376, 183);
            btnpeliculas.Location = new Point(711, 183);
            //btnfunciones.Location = new Point(50, 272);
            //btnproveedores.Location = new Point(376, 272);
            //btnasientos.Location = new Point(711, 272);
            //btnfaclocal.Location = new Point(50, 361);
            //btnalimentos.Location = new Point(376, 361);
            btnproductos.Location = new Point(376, 272);
            //btnidioma.Location = new Point(50, 450);
            //btnempresa.Location = new Point(376, 450);
            btnusuario.Visible = false;
            btntickets.Visible = false;
            btnpersonajes.Visible = false;
            btnfactura.Visible = false;
            btnsalas.Visible = false;
            btnpeliculas.Visible = true;
            btnfunciones.Visible = false;
            btnproveedores.Visible = false;
            btnasientos.Visible = false;
            btnfaclocal.Visible = false;
            btnalimentos.Visible = false;
            btnproductos.Visible = true;
            btnidioma.Visible = false;
            btnempresa.Visible = false;
        }
        void Consesionario()
        {
            //btnusuario.Location = new Point(50, 94);
            //btntickets.Location = new Point(376, 94);
            //btnpersonajes.Location = new Point(711, 94);
            //btnfactura.Location = new Point(50, 183);
            //btnsalas.Location = new Point(376, 183);
            //btnpeliculas.Location = new Point(711, 183);
            //btnfunciones.Location = new Point(50, 272);
            //btnproveedores.Location = new Point(376, 272);
            //btnasientos.Location = new Point(711, 272);
            //btnfaclocal.Location = new Point(50, 361);
            btnalimentos.Location = new Point(376, 272);
            btnproductos.Location = new Point(376, 183);
            //btnidioma.Location = new Point(50, 450);
            //btnempresa.Location = new Point(376, 450);
            btnusuario.Visible = false;
            btntickets.Visible = false;
            btnpersonajes.Visible = false;
            btnfactura.Visible = false;
            btnsalas.Visible = false;
            btnpeliculas.Visible = false;
            btnfunciones.Visible = false;
            btnproveedores.Visible = false;
            btnasientos.Visible = false;
            btnfaclocal.Visible = false;
            btnalimentos.Visible = true;
            btnproductos.Visible = true;
            btnidioma.Visible = false;
            btnempresa.Visible = false;
        }
        private void FrmBotones_Load(object sender, EventArgs e)
        {
            if (ContructorLogin.nivel == 1)
            {
                UbicacionRoot();
                MessageBox.Show("Root", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ContructorLogin.nivel == 2)
            {
                UbicacionAdministrador();
                MessageBox.Show("Administrador", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ContructorLogin.nivel == 3)
            {
                EncargadoSala();
                MessageBox.Show("Encargado de sala", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ContructorLogin.nivel == 4)
            {
                EncargadoInventario();
                MessageBox.Show("Encargado de inventario", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ContructorLogin.nivel == 5)
            {
                Boletero();
                MessageBox.Show("Boletero", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Consesionario();
                MessageBox.Show("Consesionario", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

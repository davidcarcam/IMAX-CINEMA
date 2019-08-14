using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXPO60.Controlador;
using EXPO60.Modelo;


namespace EXPO60.Vista
{
    public partial class FrmPersonajes : Form
    {
        public FrmPersonajes()
        {
            InitializeComponent();
        }
        public void validar()
        {

        }
        Constructor_Personajes Agregar = new Constructor_Personajes();
        Constructor_Personajes Actualizar = new Constructor_Personajes();
     
      
        public void AgregarPersonaje()
        {
            if (txtnombre.Text.Trim() == "" || cmbactor.Text.Trim() == "" || cmbpelicula.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos", "Falta informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Agregar.nombre = txtnombre.Text;
                Agregar.pelicula = cmbpelicula.Text;
                Agregar.actor = cmbactor.Text;
                int datos = FuncionPersonajes.IngresarPersonaje(Agregar);
            }
        }
        public void MostrarPersonaje()
        {
            dgvpersonajes.DataSource = FuncionPersonajes.MostrarPersonaje();
        }
        public void LimpiarCampos()
        {
            txtid.Clear();
            txtnombre.Clear();
        }
        public void ModificarPersonaje()
        {
            Actualizar.idpersonaje = Convert.ToInt32(txtid.Text);
            Actualizar.nombre = txtnombre.Text;
            Actualizar.pelicula = cmbpelicula.Text;
            Actualizar.actor = cmbactor.Text;
            FuncionPersonajes.ActualizarPersonaje(Actualizar);
        }
        public void EliminarPersonaje()
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FuncionPersonajes.EliminarPersonaje(Convert.ToInt32(txtid.Text));
            }
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            AgregarPersonaje();
            MostrarPersonaje();
            LimpiarCampos();
        }
        private void Frmpersonajes_Load(object sender, EventArgs e)
        {
            MostrarPersonaje();
            this.dgvpersonajes.Columns[0].Visible = false;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
        }
        private void btnmostrar_Click_1(object sender, EventArgs e)
        {
            MostrarPersonaje();
            LimpiarCampos();
        }
        private void btnactualizar_Click_1(object sender, EventArgs e)
        {
            ModificarPersonaje();
            LimpiarCampos();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
        }
        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            EliminarPersonaje();
            LimpiarCampos();
            MostrarPersonaje();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
        }
        private void dgvpersonajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvpersonajes.CurrentRow.Index;
            txtid.Text = this.dgvpersonajes[0, posicion].Value.ToString();
            txtnombre.Text = this.dgvpersonajes[1, posicion].Value.ToString();
            cmbactor.Text = this.dgvpersonajes[2, posicion].Value.ToString();
            cmbpelicula.Text = this.dgvpersonajes[3, posicion].Value.ToString();
            btnactualizar.Enabled = true;
            btneliminar.Enabled = true;
            btnagregar.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar el formulario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
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

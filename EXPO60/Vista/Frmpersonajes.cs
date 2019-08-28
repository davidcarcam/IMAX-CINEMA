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
            if (txtnombre.Text.Trim() == "" )
            {
                MessageBox.Show("Complete todos los campos", "Falta informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Agregar.nombre = txtnombre.Text;
             
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
            btnactualizar.Enabled = true;
            btneliminar.Enabled = true;
            btnagregar.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
                this.Close();
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

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                dgvpersonajes.CurrentCell = null;
                foreach (DataGridViewRow r in dgvpersonajes.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvpersonajes.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtbuscar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                MostrarPersonaje();
            }
        }
    }
}

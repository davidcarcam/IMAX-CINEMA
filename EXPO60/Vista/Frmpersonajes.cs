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
        Constructor_Personajes agregar = new Constructor_Personajes();
        Constructor_Personajes actualizar = new Constructor_Personajes();
        public FrmPersonajes()
        {
            InitializeComponent();
        }
        public void validar()
        {

        }
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


        public void AgregarPersonaje()
        {
            agregar.nombre = txtnombre.Text;
            agregar.pelicula = Convert.ToInt16(cmbpelicula.SelectedValue);
            agregar.actor = Convert.ToInt16(cmbactor.SelectedValue);
            int datos = FuncionPersonajes.IngresarPersonaje(agregar);
        }
        public void MostrarPersonaje()
        {
            dgvpersonajes.DataSource = FuncionPersonajes.MostrarPersonaje();
        }
        public void LimpiarCampos()
        {
            txtnombre.Clear();
            txtbuscar.Clear();
        
        }
        public void ModificarPersonaje()
        {
            actualizar.nombre = txtnombre.Text;
            actualizar.actor = Convert.ToInt16(cmbactor.SelectedValue);
            actualizar.idpersonaje = Convert.ToInt16(txtid.Text);
            actualizar.pelicula = Convert.ToInt16(cmbpelicula.SelectedValue);
            FuncionPersonajes.ActualizarPersonaje(actualizar); ;
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
            
        }
        private void Frmpersonajes_Load(object sender, EventArgs e)
        {
            MostrarPersonaje();
            dgvpersonajes.Columns[0].Visible = false;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
        }
        private void btnmostrar_Click_1(object sender, EventArgs e)
        {
            
        }
        private void btnactualizar_Click_1(object sender, EventArgs e)
        {
            
        }
        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            
        }
        private void dgvpersonajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = dgvpersonajes.CurrentRow.Index;
            txtid.Text = dgvpersonajes[0, posicion].Value.ToString();
            txtnombre.Text = dgvpersonajes[1, posicion].Value.ToString();
            cmbactor.Text = dgvpersonajes[2, posicion].Value.ToString();
            cmbpelicula.Text = dgvpersonajes[3, posicion].Value.ToString();
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
        public void mostrarET()
        {

            cmbpelicula.DataSource = Funciones_peliculas.ObtenerEstadoPelicula();
            cmbpelicula.DisplayMember = "estado_pelicula";
            cmbpelicula.ValueMember = "id_estado_pelicula";

            cmbactor.DataSource = Funciones_peliculas.ObtenerDimensiones();
            cmbactor.DisplayMember = "formatos";
            cmbactor.ValueMember = "id_formatos";

        }

        private void dgvpersonajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void FrmPersonajes_Load_1(object sender, EventArgs e)
        {
            MostrarPersonaje();
            dgvpersonajes.Columns[0].Visible = false;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;

            cmbpelicula.DataSource = FuncionPersonajes.obtenerpelicula();
            cmbpelicula.DisplayMember = "titulo";
            cmbpelicula.ValueMember = "id_pelicula";

            cmbactor.DataSource = FuncionPersonajes.obtenerActor();
            cmbactor.DisplayMember = "actor";
            cmbactor.ValueMember = "id_actor";
        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            AgregarPersonaje();
            MostrarPersonaje();
            LimpiarCampos();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            MostrarPersonaje();
            LimpiarCampos();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            ModificarPersonaje();
            LimpiarCampos();
            MostrarPersonaje();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            EliminarPersonaje();
            LimpiarCampos();
            MostrarPersonaje();
            btnactualizar.Enabled = false;
            btnagregar.Enabled = true;
            btneliminar.Enabled = false;
        }

        private void dgvpersonajes_CellClick_1(object sender, DataGridViewCellEventArgs e)
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
    }
}

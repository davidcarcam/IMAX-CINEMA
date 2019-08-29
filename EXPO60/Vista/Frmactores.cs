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
using MySql.Data.MySqlClient;

namespace EXPO60.Vista
{
    public partial class FrmActores : Form
    {
        Constructor_Actores Actualizar = new Constructor_Actores();
        Constructor_Actores agregar = new Constructor_Actores();
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
        public FrmActores()
        {
            InitializeComponent();
        }
        public void Mostrar_Actores()
        {
            dgvActores.DataSource = Funciones_Actores.Mostrar_Actores();
        }
        public void Limpiar_Datos()
        {
            txtactor.Clear();
        }
        public void Eliminar_Actor()
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el registro seleccionado?", "Eliminacion de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_Actores.Eliminar_Actor(Convert.ToInt16(txtID_Actor.Text));
            }
            else
            {
                MessageBox.Show("Eliminacion de registro abortada", "Eliminacion de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Agregar_Actor()
        {
            if (txtactor.Text.Trim() == "")
            {
                MessageBox.Show("El campo se encuentra vacio, Completelo", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                agregar.Nombre_Actor = txtactor.Text;
            }
        }
        public void Modificar_Actor()
        {
            Actualizar.ID_Actor = Convert.ToInt32(txtID_Actor);
            Actualizar.Nombre_Actor = txtactor.Text;
            Funciones_Actores.Actualizar_Actor(Actualizar);
        }
        private void BtnAgregar_Actor_Click(object sender, EventArgs e)
        {
            Limpiar_Datos();
            Agregar_Actor();
            Mostrar_Actores();
        }
        private void BtnMostrar_Actores_Click(object sender, EventArgs e)
        {
            Limpiar_Datos();
            Mostrar_Actores();
        }
        private void BtnActualizar_Actor_Click(object sender, EventArgs e)
        {
            Limpiar_Datos();
            Modificar_Actor();
            btnActualizar_Actor.Enabled = false;
            btnAgregar_Actor.Enabled = true;
            btnEliminar_Actor.Enabled = false;
        }
        private void BtnEliminar_Actor_Click(object sender, EventArgs e)
        {
            Eliminar_Actor();
            Limpiar_Datos();
            Mostrar_Actores();
            btnActualizar_Actor.Enabled = false;
            btnAgregar_Actor.Enabled = true;
            btnEliminar_Actor.Enabled = false;
        }
        private void DgvActores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvActores.CurrentRow.Index;
            txtID_Actor.Text = this.dgvActores[0, posicion].Value.ToString();
            txtactor.Text = this.dgvActores[1, posicion].Value.ToString();
            btnActualizar_Actor.Enabled = true;
            btnEliminar_Actor.Enabled = true;
            btnAgregar_Actor.Enabled = false;
        }
        private void FrmActores_Load(object sender, EventArgs e)
        {
            Mostrar_Actores();
            this.dgvActores.Columns[0].Visible = false;
            btnActualizar_Actor.Enabled = false;
            btnEliminar_Actor.Enabled = false;
        }
        private void TxtNombre_Actor_Validated(object sender, EventArgs e)
        {
            if (txtactor.Text.Trim() == "")
            {
                epError3.SetError(txtactor, "Introduce la capacidad de la sala.");
                txtactor.Focus();
            }
            else
            {
                epError3.Clear();
            }
        }
        private void TxtNombre_Actor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void ToolStrip1_Resize(object sender, EventArgs e)
        {

        }

        private void GrpActores_Resize(object sender, EventArgs e)
        {

        }

        private void lblNombre_Actor_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

            if (txtbuscar.Text != "")
            {
                dgvActores.CurrentCell = null;
                foreach (DataGridViewRow r in dgvActores.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvActores.Rows)
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
                Mostrar_Actores();
            }
        }
    }
}

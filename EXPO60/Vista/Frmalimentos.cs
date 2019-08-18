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
    public partial class Frmalimentos : Form
    {
        public Frmalimentos()
        {
            InitializeComponent();
        }
        Constructor_localAlimentos agregar = new Constructor_localAlimentos();
        Constructor_localAlimentos actualizar = new Constructor_localAlimentos();
        public void mostrarLocal()
        {
            dgvlocal.DataSource = FuncionesAlimentos.mostrarlocal();
        }
        public void modificarRegistro()
        {
            actualizar.NombreLocal = txtnombre.Text;
            actualizar.Telefono = txttelefonoLocal.Text;
            FuncionesAlimentos.actualizarLocal(actualizar);
        }
        public void agregarLocal()
        {
            agregar.NombreLocal = txtnombre.Text;
            agregar.Telefono = txttelefonoLocal.Text ;
            int datos = FuncionesAlimentos.insertarLocalAlimentos(agregar);
        }
        public void vaciarampos()
        {
            txtnombre.Clear();
            txttelefonoLocal.Clear();
        }
        public void eliminarRegistro()
        {
            if (MessageBox.Show("Esta seguro de realizar esta operacion?", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FuncionesAlimentos.eliminarLocal(Convert.ToInt32(txtid.Text));
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

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

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "" || txttelefonoLocal.Text == "")
            {
                MessageBox.Show("Por favor rellena todos los campos que se te piden", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                agregarLocal();
                mostrarLocal();
                vaciarampos();
            }
        }

        private void dgvactores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvlocal.CurrentRow.Index;
            txtid.Text = this.dgvlocal[0, posicion].Value.ToString();
            txtnombre.Text = this.dgvlocal[1, posicion].Value.ToString();
            txttelefonoLocal.Text = this.dgvlocal[2, posicion].Value.ToString();
            btnactualizar.Enabled = true;
            btneliminar.Enabled = true;
            btnagregar.Enabled = false;
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            mostrarLocal();
        }

        private void Frmalimentos_Load(object sender, EventArgs e)
        {
            mostrarLocal();
            this.dgvlocal.Columns[0].Visible = false;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            modificarRegistro();
            vaciarampos();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
            mostrarLocal();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            eliminarRegistro();
            vaciarampos();
            mostrarLocal();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
        }
    }
}

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
    public partial class FrmEmpresas : Form
    {
        public FrmEmpresas()
        {
            InitializeComponent();
        }
        constructorEmpresa agregar = new constructorEmpresa();
        constructorEmpresa actualizar = new constructorEmpresa();
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
        public void agregarEmpresa()
        {
            agregar.nombreEmpresa = txtNombre_empresa.Text;
            agregar.direccionEmpresa = txtDireccion_empresa.Text;
            int datos = funcionesEmpresa.insertarLocal(agregar);
        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
           

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        public void mostrarEmpresas()
        {
            dgvempresas.DataSource = funcionesEmpresa.mostrarEmpresas();
        }
        public void vaciarampos()
        {
            txtNombre_empresa.Clear();
            txtDireccion_empresa.Clear();
        }

        private void FrmEmpresas_Load(object sender, EventArgs e)
        {
            mostrarEmpresas();
            this.dgvempresas.Columns[0].Visible = false;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            mostrarEmpresas();
        }

        private void dgvactores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        public void modificarRegistro()
        {
            actualizar.nombreEmpresa = txtNombre_empresa.Text;
            actualizar.direccionEmpresa = txtDireccion_empresa.Text;
            funcionesEmpresa.actualizarEmpresa(actualizar);
        }
        public void eliminarRegistro()
        {
            if (MessageBox.Show("Esta seguro de realizar esta operacion?", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                funcionesEmpresa.eliminarEmpresa(Convert.ToInt32(txtid.Text));
            }
            
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {

            modificarRegistro();
            vaciarampos();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
            mostrarEmpresas();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            eliminarRegistro();
            vaciarampos();
            mostrarEmpresas();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre_empresa.Text == "" || txtDireccion_empresa.Text == "")
            {
                MessageBox.Show("Por favor rellena todos los campos que se te piden", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                agregarEmpresa();
                mostrarEmpresas();
                vaciarampos();
            }
        }

        private void txtDireccion_empresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                dgvempresas.CurrentCell = null;
                foreach (DataGridViewRow r in dgvempresas.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvempresas.Rows)
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
                mostrarEmpresas();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            vaciarampos();
        }

        private void dgvempresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvempresas.CurrentRow.Index;
            txtid.Text = this.dgvempresas[0, posicion].Value.ToString();
            txtNombre_empresa.Text = this.dgvempresas[1, posicion].Value.ToString();
            txtDireccion_empresa.Text = this.dgvempresas[2, posicion].Value.ToString();
            btnactualizar.Enabled = true;
            btneliminar.Enabled = true;
            btnagregar.Enabled = false;
        }
    }
}

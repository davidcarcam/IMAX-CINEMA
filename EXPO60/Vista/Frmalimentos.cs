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
using EXPO60.Reportes;

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
        public void mostrarLocal()
        {
            dgvlocal.DataSource = FuncionesAlimentos.mostrarlocal();
        }
        public void modificarRegistro()
        {
            actualizar.NombreLocal = txtnombre.Text;
            actualizar.Telefono = txttelefonoLocal.Text;
            actualizar.tipo = Convert.ToInt16(cmbestado.SelectedValue);
            FuncionesAlimentos.actualizarLocal(actualizar);
        }
        public void agregarLocal()
        {
            agregar.NombreLocal = txtnombre.Text;
            agregar.Telefono = txttelefonoLocal.Text ;
            agregar.tipo = Convert.ToInt16(cmbestado.SelectedValue);
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
            mostrarET();
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
        public void mostrarET()
        {

            cmbestado.DataSource = FuncionesAlimentos.ObtenerEstadoUsuario();
            cmbestado.DisplayMember = "estado_local";
           cmbestado.ValueMember = "id_estado_local";

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                dgvlocal.CurrentCell = null;
                foreach (DataGridViewRow r in dgvlocal.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvlocal.Rows)
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
                mostrarLocal();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            vaciarampos();
        }

        private void Btnalimento_Click(object sender, EventArgs e)
        {
            ReporteLocalAlimento repro = new ReporteLocalAlimento();
            repro.Show();
        }
    }
}

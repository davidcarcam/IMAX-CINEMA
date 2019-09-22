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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }
        Constructor_Proveedores agregar = new Constructor_Proveedores();
        Constructor_Proveedores actualizar = new Constructor_Proveedores();
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
        public void agregarProveedor()
        {
            agregar.nombre = txtnombre.Text;
            agregar.apellido = txtapellido.Text;
            agregar.correo = txtcorreo.Text;
            agregar.direccion = txtdireccion.Text;
            agregar.DUI = txtdui.Text;
            agregar.telefono = txttelefono.Text;
            agregar.id_empresa = Convert.ToInt16(cmbempresa.SelectedValue);
            agregar.id_estado_prov = Convert.ToInt16(cmbestado.SelectedValue);

            int datos = Funciones_proveedores.insertarProveedor(agregar);
        }
        public void vaciarampos()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtcorreo.Clear();
            txtdireccion.Clear();
            txtdui.Clear();
            txttelefono.Clear();
        }
        public void modificarRegistro()
        {
            actualizar.nombre = txtnombre.Text;
            actualizar.apellido = txtapellido.Text;
            actualizar.correo = txtcorreo.Text;
            actualizar.direccion = txtdireccion.Text;
            actualizar.DUI = txtdui.Text;
            actualizar.telefono = txttelefono.Text;
            actualizar.id_empresa = Convert.ToInt16(cmbempresa.SelectedValue);
            actualizar.id_estado_prov = Convert.ToInt16(cmbestado.SelectedValue);

            Funciones_proveedores.actualizarProveedor(actualizar);
        }
        public void mostrarProveedor()
        {
            dgvproveedores.DataSource = Funciones_proveedores.mostrarProveedor();
        }
        public void eliminarRegistro()
        {
            if (MessageBox.Show("Esta seguro de realizar esta operacion?", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_proveedores.eliminarProveedor(Convert.ToInt32(txtid.Text));
            }

        }
        public void mostrarET()
        {
            cmbempresa.DataSource = Funciones_proveedores.ObtenerEmpresa();
            cmbempresa.DisplayMember = "empresa";
            cmbempresa.ValueMember = "id_empresa";

            cmbestado.DataSource = Funciones_proveedores.ObtenerEstado();
            cmbestado.DisplayMember = "estado_prov";
            cmbestado.ValueMember = "id_estado_prov";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "" || txtapellido.Text == "" || txtcorreo.Text == "" || txtdireccion.Text == "" || txtdui.Text == "" || txttelefono.Text == "")
            {
                MessageBox.Show("Por favor rellena todos los campos que se te piden", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                agregarProveedor();
                mostrarProveedor();
                vaciarampos();
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            modificarRegistro();
            vaciarampos();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
            mostrarProveedor();
        }

        private void dgvproveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            mostrarET();
            mostrarProveedor();
            this.dgvproveedores.Columns[0].Visible = false;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            eliminarRegistro();
            vaciarampos();
            mostrarProveedor();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            mostrarProveedor();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                dgvproveedores.CurrentCell = null;
                foreach (DataGridViewRow r in dgvproveedores.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvproveedores.Rows)
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
                mostrarProveedor();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            vaciarampos();
        }

        private void dgvproveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvproveedores.CurrentRow.Index;
            txtid.Text = this.dgvproveedores[0, posicion].Value.ToString();
            txtnombre.Text = this.dgvproveedores[1, posicion].Value.ToString();
            txtapellido.Text = this.dgvproveedores[2, posicion].Value.ToString();
            txtcorreo.Text = this.dgvproveedores[3, posicion].Value.ToString();
            txtdireccion.Text = this.dgvproveedores[4, posicion].Value.ToString();
            txtdui.Text = this.dgvproveedores[5, posicion].Value.ToString();            
            txttelefono.Text = this.dgvproveedores[6, posicion].Value.ToString();
            btnactualizar.Enabled = true;
            btneliminar.Enabled = true;
            btnagregar.Enabled = false;
        }
    }
}

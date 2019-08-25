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
        public void agregarProveedor()
        {
            agregar.nombre = txtnombre.Text;
            agregar.apellido = txtapellido.Text;
            agregar.correo = txtcorreo.Text;
            agregar.direccion = txtdireccion.Text;
            agregar.DUI = txtdui.Text;
            agregar.telefono = txttelefono.Text;
            
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

            cmbestado.DataSource = Funciones_proveedores.ObtenerEstado();
            cmbestado.DisplayMember = "estado_prov";
            cmbestado.ValueMember = "id_estado_prov";


            cmbempresa.DataSource = Funciones_proveedores.ObtenerEmpresa();
            cmbempresa.DisplayMember = "empresa";
            cmbempresa.ValueMember = "id_empresa";
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
            int posicion;
            posicion = this.dgvproveedores.CurrentRow.Index;
            txtid.Text = this.dgvproveedores[0, posicion].Value.ToString();
            txtnombre.Text = this.dgvproveedores[1, posicion].Value.ToString();
            txtapellido.Text = this.dgvproveedores[2, posicion].Value.ToString();
            btnactualizar.Enabled = true;
            btneliminar.Enabled = true;
            btnagregar.Enabled = false;
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
    }
}

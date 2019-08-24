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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }
        Constructor_Productos Agregar = new Constructor_Productos();
        Constructor_Productos Actualizar = new Constructor_Productos();
     
        public void AgregarProducto()
        {
            if (txtprecio.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos", "Falta informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Agregar.precio = txtprecio.Text;
                Agregar.local = Convert.ToInt16(cbmlocal.SelectedValue);
                Agregar.proveedor = Convert.ToInt16(cmbprov.SelectedValue); ;
                Agregar.tipoproducto = Convert.ToInt16(cmbtipo.SelectedValue);
                int datos = Funciones_Productos.IngresarProducto(Agregar);
            }
        }
        public void MostrarProducto()
        {
            dgvproductos.DataSource = Funciones_Productos.MostrarProducto();
        }
        public void LimpiarCampos()
        {
            txtid.Clear();
            txtprecio.Clear();

        }
        public void ModificarProducto()
        {
            Actualizar.idproducto = Convert.ToInt32(txtid.Text);
            Actualizar.precio = txtprecio.Text;
            Actualizar.local = Convert.ToInt16(cbmlocal.SelectedValue);
            Actualizar.tipoproducto = Convert.ToInt16(cmbtipo.SelectedValue);
            Actualizar.proveedor = Convert.ToInt16(cmbprov.SelectedValue);
            Funciones_Productos.ActualizarProducto(Actualizar);
        }
        public void EliminarProducto()
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_Productos.EliminarProducto(Convert.ToInt32(txtid.Text));
            }
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
            MostrarProducto();
            LimpiarCampos();
        }
        private void btnmostrar_Click(object sender, EventArgs e)
        {
            MostrarProducto();
            LimpiarCampos();
        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            ModificarProducto();
            LimpiarCampos();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
            LimpiarCampos();
            MostrarProducto();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
        }
        private void dgvproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvproductos.CurrentRow.Index;
            txtid.Text = this.dgvproductos[0, posicion].Value.ToString();
            txtprecio.Text = this.dgvproductos[1, posicion].Value.ToString();
            cbmlocal.Text = this.dgvproductos[2, posicion].Value.ToString();
            cmbprov.Text = this.dgvproductos[3, posicion].Value.ToString();
            cmbtipo.Text = this.dgvproductos[4, posicion].Value.ToString();
            btnactualizar.Enabled = true;
            btneliminar.Enabled = true;
            btnagregar.Enabled = false;
        }
        private void Frmproductos_Load(object sender, EventArgs e)
        {
            MostrarProducto();
            this.dgvproductos.Columns[0].Visible = false;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            

            cmbprov.DataSource = Funciones_Productos.VerProveedor();
            cmbprov.DisplayMember = "NOMBRE_PROV";
            cmbprov.ValueMember = "ID_PROVEEDOR";

            cbmlocal.DataSource = Funciones_Productos.verLocal();
            cbmlocal.DisplayMember = "NOMBRE_LOCAL";
            cbmlocal.ValueMember = "ID_LOCAL";

            cmbtipo.DataSource = Funciones_Productos.VerTipo();
            cmbtipo.DisplayMember = "NOMBRE_TIPO_P";
            cmbtipo.ValueMember = "ID_TIPO_PRODUCTO";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            AgregarProducto();
        }
    }
}

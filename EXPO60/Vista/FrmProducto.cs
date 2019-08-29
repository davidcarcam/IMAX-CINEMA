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

        public void AgregarProducto()
        {
            if (txtprecio.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos", "Falta informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Agregar.nombre = txtnombre.Text;
                Agregar.precio = txtprecio.Text;
                Agregar.local = Convert.ToInt16(cmblocal.SelectedValue);
                Agregar.proveedor = Convert.ToInt16(cmbprov.SelectedValue); 
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
            Actualizar.nombre = txtnombre.Text;
            Actualizar.precio = txtprecio.Text;
            Actualizar.local = Convert.ToInt16(cmblocal.SelectedValue);
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
        public void mostrarEs()
        {

            cmbprov.DataSource = Funciones_Productos.ObtenerProv();
            cmbprov.DisplayMember = "nombre";
            cmbprov.ValueMember = "id_proveedor";


            cmblocal.DataSource = Funciones_Productos.ObtenerLocal();
            cmblocal.DisplayMember = "nombre";
            cmblocal.ValueMember = "id_local";

            cmbtipo.DataSource = Funciones_Productos.ObtenerEstado();
            cmbtipo.DisplayMember = "tipo_producto";
            cmbtipo.ValueMember = "id_tipo_prod";



        }
        
        private void btnmostrar_Click(object sender, EventArgs e)
        {
            MostrarProducto();
            LimpiarCampos();
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
            MostrarProducto();
        }

        private void Dgvproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvproductos.CurrentRow.Index;
            txtid.Text = this.dgvproductos[0, posicion].Value.ToString();
            txtprecio.Text = this.dgvproductos[1, posicion].Value.ToString();
            cmblocal.Text = this.dgvproductos[2, posicion].Value.ToString();
            cmbprov.Text = this.dgvproductos[3, posicion].Value.ToString();
            cmbtipo.Text = this.dgvproductos[4, posicion].Value.ToString();
            btnactualizar.Enabled = true;
            btneliminar.Enabled = true;
            btnagregar.Enabled = false;
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            
            MostrarProducto();
            mostrarEs();
            this.dgvproductos.Columns[0].Visible = false;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void btnmostrar_Click_1(object sender, EventArgs e)
        {
          
        
            MostrarProducto();
            LimpiarCampos();
        
    }

        private void btnactualizar_Click_1(object sender, EventArgs e)
        {
      
            ModificarProducto();
            LimpiarCampos();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
        
    }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {

        
            EliminarProducto();
            LimpiarCampos();
            MostrarProducto();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
        
    }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                dgvproductos.CurrentCell = null;
                foreach (DataGridViewRow r in dgvproductos.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvproductos.Rows)
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
                MostrarProducto();
            }
        }
    }
}

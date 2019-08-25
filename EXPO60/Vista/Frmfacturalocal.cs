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
    public partial class Frmfacturalocal : Form
    {
        Constructo_Factura_Local agregar = new Constructo_Factura_Local();
        Constructo_Factura_Local Actualizar = new Constructo_Factura_Local();
        public Frmfacturalocal()
        {
            InitializeComponent();
        }
        private void Frmfacturalocal_Load(object sender, EventArgs e)
        {
            Mostrar_Factura_Local();
            this.dgvfacturaloc.Columns[0].Visible = false;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            cmbusuario.DataSource = Funciones_Factura_Local.usuario();
            cmbusuario.DisplayMember = "usuario";
            cmbusuario.ValueMember = "id_usuario";
        }
        public void Mostrar_Factura_Local()
        {
            dgvfacturaloc.DataSource = Funciones_Factura_Local.Mostrar_Facturas();
        }
        public void Limpiar_Factura_Local()
        {
            txtfecha.Clear();
            txtmonto.Clear();
            txtnombre.Clear();
        }
        public void Eliminar_Factura_Local()
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el registro seleccionado?", "Eliminacion de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_Salas.Eliminar_Salas(Convert.ToInt16(txtid.Text));
            }
            else
            {
                MessageBox.Show("Eliminacion de registro abortada", "Eliminacion de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Agregar_Factura_Local()
        {
            agregar.monto_fac_local = txtmonto.Text;
            agregar.fecha_fac_local = txtfecha.Text;
            agregar.nombre_cliente = txtnombre.Text;
            agregar.id_usuario = Convert.ToInt32(cmbusuario.SelectedValue);
            int datos = Funciones_Factura_Local.Ingresar_Factura_Local(agregar);
        }
        public void Modificar_Factura_Local()
        {
            Actualizar.monto_fac_local = txtmonto.Text;
            Actualizar.fecha_fac_local = txtfecha.Text;
            Actualizar.nombre_cliente = txtnombre.Text;
            Actualizar.id_usuario = Convert.ToInt32(cmbusuario.SelectedValue);
            Funciones_Factura_Local.Actualizar_Factura_Local(Actualizar);
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvfacturaloc.CurrentRow.Index;
            txtid.Text = this.dgvfacturaloc[0, posicion].Value.ToString();
            txtmonto.Text = this.dgvfacturaloc[1, posicion].Value.ToString();
            txtfecha.Text = this.dgvfacturaloc[2, posicion].Value.ToString();
            txtnombre.Text = this.dgvfacturaloc[3, posicion].Value.ToString();
            cmbusuario.Text = this.dgvfacturaloc[4, posicion].Value.ToString();
            btnactualizar.Enabled = true;
            btneliminar.Enabled = true;
            btnagregar.Enabled = false;
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvfacturaloc.CurrentRow.Index;
            txtid.Text = this.dgvfacturaloc[0, posicion].Value.ToString();
            txtmonto.Text = this.dgvfacturaloc[1, posicion].Value.ToString();
            txtfecha.Text = this.dgvfacturaloc[2, posicion].Value.ToString();
            txtnombre.Text = this.dgvfacturaloc[3, posicion].Value.ToString();
            cmbusuario.Text = this.dgvfacturaloc[4, posicion].Value.ToString();
            btnactualizar.Enabled = true;
            btneliminar.Enabled = true;
            btnagregar.Enabled = false;
        }
    }
}

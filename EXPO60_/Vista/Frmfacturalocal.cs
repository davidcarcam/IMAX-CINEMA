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
using EXPO60.Reportes;

namespace EXPO60.Vista
{
    public partial class Frmfacturalocal : Form
    {
        Constructo_Factura_Local agregar = new Constructo_Factura_Local();
        Constructo_Factura_Local Actualizar = new Constructo_Factura_Local();
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
        public void MostrarComboBox()
        {
            cmbusuario.DataSource = Funciones_Factura_Local.usuario();
            cmbusuario.ValueMember = "id_usuario";
            cmbusuario.DisplayMember = "usuario";
        }
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
        }
        public void Mostrar_Factura_Local()
        {
            dgvfacturaloc.DataSource = Funciones_Factura_Local.Mostrar_Facturas();
        }
        public void Limpiar_Factura_Local()
        {
            txtmonto.Clear();
            txtnombre.Clear();
        }
        public void Eliminar_Factura_Local()
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el registro seleccionado?", "Eliminacion de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_Factura_Local.Eliminar_Factura_Local(Convert.ToInt32(txtid.Text));
            }
            else
            {
                MessageBox.Show("Eliminacion de registro abortada", "Eliminacion de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Agregar_Factura_Local()
        {
            agregar.monto_fac_local = txtMont.Text;
            agregar.fecha_fac_local = txtDate.Text;
            agregar.nombre_cliente = txtNom.Text;
            agregar.id_usuario = Convert.ToInt32(cmbusuario.SelectedValue);
            int datos = Funciones_Factura_Local.Ingresar_Factura_Local(agregar);
        }
        public void Modificar_Factura_Local()
        {
            Actualizar.id_factura_local = Convert.ToInt32(txtid.Text);
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
            DateTime fecha = DateTime.Today.AddDays(15);
            if (dateTimePicker1.Value.Date > fecha)
            {
                MessageBox.Show("La fecha ingresada esta fuera del rango permitido", "Fecha superior", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (dateTimePicker1.Value.Date < DateTime.Today)
                {
                    MessageBox.Show("La fecha ingresada es menor a la de hoy", "La fecha es erronea", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Agregar_Factura_Local();
                    Limpiar_Factura_Local();
                    Mostrar_Factura_Local();
                }
            }         
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
        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Eliminar_Factura_Local();
            Limpiar_Factura_Local();
            Mostrar_Factura_Local();
            btnactualizar.Enabled = false;
            btnagregar.Enabled = true;
            btneliminar.Enabled = false;
        }
        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Limpiar_Factura_Local();
            Modificar_Factura_Local();
            Mostrar_Factura_Local();
            btnactualizar.Enabled = false;
            btnagregar.Enabled = true;
            btneliminar.Enabled = false;
        }
        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Limpiar_Factura_Local();
            Mostrar_Factura_Local();
        }
        private void TxtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }
        private void TxtMont_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }
        private void MaskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                dgvfacturaloc.CurrentCell = null;
                foreach (DataGridViewRow r in dgvfacturaloc.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvfacturaloc.Rows)
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
                Mostrar_Factura_Local();
            }
        }
        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar_Factura_Local();
        }
        public void MostrarFactura()
        {
            dgvfacturaloc.DataSource = Funciones_Factura_Local.Mostrar_Facturas();
        }
        private void Frmfacturalocal_Load_1(object sender, EventArgs e)
        {
            MostrarComboBox();
            this.dgvfacturaloc.Columns[0].Visible = false;
            MostrarFactura();
        }
        private void BtnFacturaLocal_Click(object sender, EventArgs e)
        {
          
        }
    }
}


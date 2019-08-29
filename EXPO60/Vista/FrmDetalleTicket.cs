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
using EXPO60.Vista;
using MySql.Data.MySqlClient;

namespace EXPO60.Vista
{
    public partial class FrmDetalleTicket : Form
    {
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
        public FrmDetalleTicket()
        {
            InitializeComponent();
        }
        ConstructorDetalleTicket agregar = new ConstructorDetalleTicket();
        ConstructorDetalleTicket actualizar = new ConstructorDetalleTicket();
        public void mostrarPeliculas()
        {
            dgvtickets.DataSource = FuncionesDetalleTicket.MostrarTicket();
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void grpDetalleTicket_Enter(object sender, EventArgs e)
        {

        }
        public void Mostrarcmb()
        {
            cmbfuncion.DataSource = FuncionesDetalleTicket.funcion();
            cmbfuncion.DisplayMember = "hora";
            cmbfuncion.ValueMember = "id_funcion";

            cmbAsiento.DataSource = FuncionesDetalleTicket.asiento();
            cmbAsiento.DisplayMember = "id_num";
            cmbAsiento.ValueMember = "id_asiento";
        }

        private void FrmDetalleTicket_Load(object sender, EventArgs e)
        {
            Mostrarcmb();
            this.dgvtickets.Columns[0].Visible = false;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
        }
        public void agregarDetalleTickt()
        {
            agregar.funcion = Convert.ToInt16(cmbfuncion.Text);
            agregar.asiento = Convert.ToInt16(cmbAsiento.Text);
            int datos = FuncionesDetalleTicket.IngresarDetalle(agregar);
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (cmbfuncion.Text == "" || cmbfuncion.Text == "")
            {
                MessageBox.Show("Por favor rellena todos los campos que se te piden", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                agregarDetalleTickt();
                mostrarDetalleTicket();
                vaciarampos();

            }
        }

        private void vaciarampos()
        {
            throw new NotImplementedException();
        }

        private void mostrarDetalleTicket()
        {
            throw new NotImplementedException();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            Mostrarcmb();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                dgvtickets.CurrentCell = null;
                foreach (DataGridViewRow r in dgvtickets.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvtickets.Rows)
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
                mostrarDetalleTicket();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvtickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvtickets.CurrentRow.Index;
            idDetalletic.Text = this.dgvtickets[0, posicion].Value.ToString();
            btnactualizar.Enabled = true;
            btneliminar.Enabled = true;
            btnagregar.Enabled = false;
        }

        public void mostrarET()
        {            
            cmbAsiento.DataSource = FuncionesDetalleTicket.asiento();
            cmbAsiento.DisplayMember = "asiento";
            cmbAsiento.ValueMember = "id_asiento";

            cmbfuncion.DataSource = FuncionesDetalleTicket.funcion();
            cmbfuncion.DataSource = "funciones";
            cmbfuncion.DataSource = "id_funcion";
        }
        private void idDetalletic_TextChanged(object sender, EventArgs e)
        {

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
        public void modificarRegistro()
        {
            actualizar.funcion = Convert.ToInt16(cmbfuncion.SelectedValue);
            actualizar.asiento = Convert.ToInt16(cmbAsiento.SelectedValue);
            FuncionesDetalleTicket.ActualizarTicket(actualizar);
        }
        public void mostrarEmpresas()
        {
            dgvtickets.DataSource = FuncionesDetalleTicket.MostrarTicket();
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            eliminarRegistro();
            vaciarampos();
            mostrarEmpresas();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
        }
        public void eliminarRegistro()
        {
            if (MessageBox.Show("Esta seguro de realizar esta operacion?", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funcionesEmpresa.eliminarEmpresa(Convert.ToInt32(idDetalletic.Text));
            }

        }
    }
}



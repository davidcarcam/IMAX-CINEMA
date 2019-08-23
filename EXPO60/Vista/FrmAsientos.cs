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
    public partial class FrmAsientos : Form
    {
        Constructor_Asientos Actualizar = new Constructor_Asientos();
        Constructor_Asientos agregar = new Constructor_Asientos();
        public FrmAsientos()
        {
            InitializeComponent();
        }
        public void Mostrar_Asientos()
        {
            dgvAsientos.DataSource = Funciones_Asientos.Mostrar_Asientos();
            this.dgvAsientos.Columns[0].Visible = false;
        }
        public void Limpiar_Datos()
        {

        }
        public void Eliminar_Asiento()
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el registro seleccionado?", "Eliminacion de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_Asientos.Eliminar_Asiento(Convert.ToInt16(txtID_Asiento.Text));
            }
            else
            {
                MessageBox.Show("Eliminacion de registro abortada", "Eliminacion de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Agregar_Asiento()
        {


            agregar.estado = Convert.ToInt16(cmbEstado_Asiento.SelectedValue);
           
            agregar.sala = Convert.ToInt16(cmbSala.SelectedValue);
           
            int datos = Funciones_Asientos.Ingresar_Asientos(agregar);


        }
        public void Modificar_Asiento()
        {
            Actualizar.estado = Convert.ToInt16(cmbEstado_Asiento.SelectedValue);
       
            Actualizar.sala = Convert.ToInt16(cmbSala.SelectedValue);
        
            Funciones_Asientos.Actualizar_Asiento(Actualizar);
        }
        private void FrmAsientos_Load(object sender, EventArgs e)
        {
            Mostrar_Asientos();
            this.dgvAsientos.Columns[0].Visible = false;
            btnActualizar_Asiento.Enabled = false;
            btnEliminar_Asiento.Enabled = false;

            cmbEstado_Asiento.DataSource = Funciones_Asientos.Estado_Asiento();
            cmbEstado_Asiento.DisplayMember = "estado_as";
            cmbEstado_Asiento.ValueMember = "id_estado_asiento";

            cmbSala.DataSource = Funciones_Asientos.Sala();
            cmbSala.DisplayMember = "num_sala";
            cmbSala.ValueMember = "id_sala";

            
        }
        private void BtnAgregar_Asiento_Click(object sender, EventArgs e)
        {
            Limpiar_Datos();
            Agregar_Asiento();
            Mostrar_Asientos();
        }
        private void BtnMostrar_Asientos_Click(object sender, EventArgs e)
        {
            Limpiar_Datos();
            Mostrar_Asientos();
            btnAgregar_Asiento.Enabled = true;
        }
        private void BtnActualizar_Asiento_Click(object sender, EventArgs e)
        {
            Limpiar_Datos();
            Modificar_Asiento();
            Mostrar_Asientos();
            btnActualizar_Asiento.Enabled = false;
            btnAgregar_Asiento.Enabled = true;
            btnEliminar_Asiento.Enabled = false;
        }
        private void BtnEliminar_Asiento_Click(object sender, EventArgs e)
        {
            Eliminar_Asiento();
            Limpiar_Datos();
            Mostrar_Asientos();
            btnActualizar_Asiento.Enabled = false;
            btnAgregar_Asiento.Enabled = true;
            btnEliminar_Asiento.Enabled = false;
        }
        private void DgvAsientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvAsientos.CurrentRow.Index;
            txtID_Asiento.Text = this.dgvAsientos[0, posicion].Value.ToString();
            cmbEstado_Asiento.Text = this.dgvAsientos[1, posicion].Value.ToString();
           
            
            cmbSala.Text = this.dgvAsientos[4, posicion].Value.ToString();
            btnActualizar_Asiento.Enabled = true;
            btnEliminar_Asiento.Enabled = true;
            btnAgregar_Asiento.Enabled = false;
        }
        private void TxtNumero_Asiento_Validated(object sender, EventArgs e)
        {

        }
        private void TxtNumero_Asiento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar el formulario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();
            }
        }
    }
}

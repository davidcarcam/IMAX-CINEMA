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
    public partial class FrmSala : Form
    {
        private void FrmSala_Load(object sender, EventArgs e)
        {
            Mostrar_Salas();
            this.dgvSalas.Columns[0].Visible = false;
            btnActualizar_Sala.Enabled = false;
            btnEliminar_Sala.Enabled = false;


            cmbEstado_Sala.DataSource = Funciones_Salas.Estado_Sala();
            cmbEstado_Sala.DisplayMember = "NOMBRE_ESTADO";
            cmbEstado_Sala.ValueMember = "ID_ESTADO_SALA";
        }
        public FrmSala()
        {
            InitializeComponent();
        }

        public void Mostrar_Salas ()
        {
            dgvSalas.DataSource = Funciones_Salas.Mostrar_Salas();
        }
        public void Limpiar_Datos()
        {
            txtNumero_Sala.Clear();
            txtCapacidad_Sala.Clear();
        }
        public void Eliminar_Sala()
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el registro seleccionado?", "Eliminacion de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_Salas.Eliminar_Salas(Convert.ToInt16(txtID_Sala.Text));
            }
            else
            {
                MessageBox.Show("Eliminacion de registro abortada","Eliminacion de registro",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public void Agregar_Salas()
        {
            if (txtNumero_Sala.Text.Trim() == "" || cmbEstado_Sala.Text.Trim() == "" || txtCapacidad_Sala.Text.Trim() == "")
            {
                MessageBox.Show("Se han encontrado campos vacios, Completelos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                agregar.EstadoSala = Convert.ToInt16(cmbEstado_Sala.Text);
                agregar.CapacidadSala = txtCapacidad_Sala.Text;
                agregar.NumeroSala = txtNumero_Sala.Text;
            }
        }
        public void Modificar_Salas()
        {
            Actualizar.IDSala = Convert.ToInt32(txtID_Sala.Text);
            Actualizar.NumeroSala = txtNumero_Sala.Text;
            Actualizar.CapacidadSala = txtCapacidad_Sala.Text;
            Actualizar.EstadoSala = Convert.ToInt16(cmbEstado_Sala);
            Funciones_Salas.Actualizar_Sala(Actualizar);
        }

        private void BtnAgregar_Sala_Click(object sender, EventArgs e)
        {
            Agregar_Salas();
            Mostrar_Salas();
            Limpiar_Datos();
        }

        private void DgvSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvSalas.CurrentRow.Index;
            txtID_Sala.Text = this.dgvSalas[0, posicion].Value.ToString();
            txtNumero_Sala.Text = this.dgvSalas[1, posicion].Value.ToString();
            txtCapacidad_Sala.Text = this.dgvSalas[2, posicion].Value.ToString();
            cmbEstado_Sala.Text = this.dgvSalas[3, posicion].Value.ToString();
            btnActualizar_Sala.Enabled = true;
            btnEliminar_Sala.Enabled = true;
            btnAgregar_Sala.Enabled = false;
        }

        private void BtnMostrar_Salas_Click(object sender, EventArgs e)
        {
            Limpiar_Datos();
            Mostrar_Salas();
        }
        Constructor_Salas Actualizar = new Constructor_Salas();
        Constructor_Salas agregar = new Constructor_Salas();

        private void BtnActualizar_Salas_Click(object sender, EventArgs e)
        {
            btnActualizar_Sala.Enabled = false;
            btnAgregar_Sala.Enabled = true;
            btnEliminar_Sala.Enabled = false;
            Limpiar_Datos();
            Modificar_Salas();
        }

        private void BtnEliminar_Salas_Click(object sender, EventArgs e)
        {
            Mostrar_Salas();
            Eliminar_Sala();
            Limpiar_Datos();
            btnActualizar_Sala.Enabled = false;
            btnAgregar_Sala.Enabled = true;
            btnEliminar_Sala.Enabled = false;
        }

    }
}

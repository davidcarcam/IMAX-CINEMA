﻿using System;
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
        }
        public void Limpiar_Datos()
        {
            txtNumero_Asiento.Clear();
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
            if (txtNumero_Asiento.Text.Trim() == "" || cmbEstado_Asiento.Text.Trim() == "" || cmbSala.Text.Trim() == "")
            {
                MessageBox.Show("Se han encontrado campos vacios, Completelos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                agregar.ID_Estado_Asiento = Convert.ToInt16(cmbEstado_Asiento.Text);
                agregar.ID_Sala = Convert.ToInt16(cmbSala.Text);
                agregar.Asiento = txtNumero_Asiento.Text;
            }
        }
        public void Modificar_Asiento()
        {
            Actualizar.ID_Asiento = Convert.ToInt16(txtID_Asiento.Text);
            Actualizar.Asiento = txtNumero_Asiento.Text;
            Actualizar.ID_Sala =Convert.ToInt16(cmbSala.Text);
            Actualizar.ID_Estado_Asiento = Convert.ToInt16(cmbEstado_Asiento);
            Funciones_Asientos.Actualizar_Asiento(Actualizar);
        }
        private void FrmAsientos_Load(object sender, EventArgs e)
        {
            Mostrar_Asientos();
            this.dgvAsientos.Columns[0].Visible = false;
            btnActualizar_Asiento.Enabled = false;
            btnEliminar_Asiento.Enabled = false;

            cmbEstado_Asiento.DataSource = Funciones_Asientos.Estado_Asiento();
            cmbEstado_Asiento.DisplayMember = "NOMBRE_ESTADO";
            cmbEstado_Asiento.ValueMember = "ID_ESTADO_ASIENTO";

            cmbSala.DataSource = Funciones_Asientos.Sala();
            cmbSala.DisplayMember = "NUM_SALA";
            cmbSala.ValueMember = "ID_SALA";
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
        }
        private void BtnActualizar_Asiento_Click(object sender, EventArgs e)
        {
            Limpiar_Datos();
            Modificar_Asiento();
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
            txtNumero_Asiento.Text = this.dgvAsientos[1, posicion].Value.ToString();
            cmbSala.Text = this.dgvAsientos[2, posicion].Value.ToString();
            cmbEstado_Asiento.Text = this.dgvAsientos[3, posicion].Value.ToString();
            btnActualizar_Asiento.Enabled = true;
            btnEliminar_Asiento.Enabled = true;
            btnAgregar_Asiento.Enabled = false;
        }
        private void TxtNumero_Asiento_Validated(object sender, EventArgs e)
        {
            if (txtNumero_Asiento.Text.Trim() == "")
            {
                epError1.SetError(txtNumero_Asiento, "Introduce el numero del asiento.");
                txtNumero_Asiento.Focus();
            }
            else
            {
                epError1.Clear();
            }
        }
        private void TxtNumero_Asiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // codigo para solo ingresar numeros usando codigo ASCII
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Insertar solo numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
    }
}

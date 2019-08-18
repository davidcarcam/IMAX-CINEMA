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


namespace EXPO60.Vista
{
    public partial class FrmEmpresas : Form
    {
        public FrmEmpresas()
        {
            InitializeComponent();
        }
        constructorEmpresa agregar = new constructorEmpresa();
        constructorEmpresa actualizar = new constructorEmpresa();
        public void agregarEmpresa()
        {
            agregar.nombreEmpresa = txtNombre_empresa.Text;
            agregar.direccionEmpresa = txtDireccion_empresa.Text;
            int datos = funcionesEmpresa.insertarLocal(agregar);
        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
           

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        public void mostrarEmpresas()
        {
            dgvempresas.DataSource = funcionesEmpresa.mostrarEmpresas();
        }
        public void vaciarampos()
        {
            txtNombre_empresa.Clear();
            txtDireccion_empresa.Clear();
        }

        private void FrmEmpresas_Load(object sender, EventArgs e)
        {
            mostrarEmpresas();
            this.dgvempresas.Columns[0].Visible = false;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            mostrarEmpresas();
        }

        private void dgvactores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvempresas.CurrentRow.Index;
            txtid.Text = this.dgvempresas[0, posicion].Value.ToString();
            txtNombre_empresa.Text = this.dgvempresas[1, posicion].Value.ToString();
            txtDireccion_empresa.Text = this.dgvempresas[2, posicion].Value.ToString();
            btnactualizar.Enabled = true;
            btneliminar.Enabled = true;
            btnagregar.Enabled = false;
        }
        public void modificarRegistro()
        {
            actualizar.nombreEmpresa = txtNombre_empresa.Text;
            actualizar.direccionEmpresa = txtDireccion_empresa.Text;
            funcionesEmpresa.actualizarEmpresa(actualizar);
        }
        public void eliminarRegistro()
        {
            if (MessageBox.Show("Esta seguro de realizar esta operacion?", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                funcionesEmpresa.eliminarEmpresa(Convert.ToInt32(txtid.Text));
            }
            
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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            eliminarRegistro();
            vaciarampos();
            mostrarEmpresas();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar el formulario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre_empresa.Text == "" || txtDireccion_empresa.Text == "")
            {
                MessageBox.Show("Por favor rellena todos los campos que se te piden", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                agregarEmpresa();
                mostrarEmpresas();
                vaciarampos();
            }
        }
    }
}

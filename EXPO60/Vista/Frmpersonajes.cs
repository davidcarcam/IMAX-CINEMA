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
    public partial class FrmPersonajes : Form
    {
        public FrmPersonajes()
        {
            InitializeComponent();
        }
        Constructor_Personajes Agregar = new Constructor_Personajes();
        Constructor_Personajes Actualizar = new Constructor_Personajes();

        public void mostrarCombo()
        {

            cmbActor.DataSource = FuncionPersonajes.obtenerActor();
            cmbActor.DisplayMember = "actor";
            cmbActor.ValueMember = "id_actor";

            cmbpeliculas.DataSource = FuncionPersonajes.obtenerpelicula();
            cmbpeliculas.DisplayMember = "titulo";
            cmbpeliculas.ValueMember = "id_pelicula";

        }
        public void AgregarPersonaje()
        {
            if (txtnombre.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos", "Falta informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Agregar.nombre = txtnombre.Text;
                Agregar.pelicula = Convert.ToInt16(cmbpeliculas.SelectedValue);
                Agregar.actor = Convert.ToInt16(cmbActor.SelectedValue);
                int datos = FuncionPersonajes.IngresarPersonaje(Agregar);
            }
        }
        public void MostrarPersonaje()
        {
            dgvpersonajes.DataSource = FuncionPersonajes.MostrarPersonaje();
        }
        public void LimpiarCampos()
        {
            txtid.Clear();
            txtnombre.Clear();
        }
        public void ModificarPersonaje()
        {
            Actualizar.idpersonaje = Convert.ToInt32(txtid.Text);
            Actualizar.nombre = txtnombre.Text;
            Actualizar.pelicula = Convert.ToInt16(cmbpeliculas.SelectedValue);
            Actualizar.actor = Convert.ToInt16(cmbActor.SelectedValue);
            FuncionPersonajes.ActualizarPersonaje(Actualizar);
        }
        public void EliminarPersonaje()
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar este registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FuncionPersonajes.EliminarPersonaje(Convert.ToInt32(txtid.Text));
            }
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            AgregarPersonaje();
            MostrarPersonaje();
            LimpiarCampos();
        }
        private void Frmpersonajes_Load(object sender, EventArgs e)
        {
            MostrarPersonaje();
            this.dgvpersonajes.Columns[0].Visible = false;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
        }
        private void btnmostrar_Click_1(object sender, EventArgs e)
        {
            MostrarPersonaje();
            LimpiarCampos();
        }
        private void btnactualizar_Click_1(object sender, EventArgs e)
        {
            ModificarPersonaje();
            LimpiarCampos();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
        }
        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            EliminarPersonaje();
            LimpiarCampos();
            MostrarPersonaje();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
        }
        private void dgvpersonajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvpersonajes.CurrentRow.Index;
            txtid.Text = this.dgvpersonajes[0, posicion].Value.ToString();
            txtnombre.Text = this.dgvpersonajes[1, posicion].Value.ToString();
            cmbActor.Text = this.dgvpersonajes[2, posicion].Value.ToString();
            cmbpeliculas.Text = this.dgvpersonajes[3, posicion].Value.ToString();
            btnactualizar.Enabled = true;
            btneliminar.Enabled = true;
            btnagregar.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void ValidacionesNombre(KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = true;
            }

            else if (e.KeyChar.ToString().Equals("'"))
            {
                e.Handled = true;
            }
            else if (e.KeyChar.ToString().Equals(","))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

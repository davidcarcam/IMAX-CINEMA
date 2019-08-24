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
    public partial class FrmActores : Form
    {
        Constructor_Actores Actualizar = new Constructor_Actores();
        Constructor_Actores agregar = new Constructor_Actores();
        public FrmActores()
        {
            InitializeComponent();
        }
        public void Mostrar_Actores()
        {
            dgvActores.DataSource = Funciones_Actores.Mostrar_Actores();
        }
        public void Limpiar_Datos()
        {
            txtactor.Clear();
        }
        public void Eliminar_Actor()
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el registro seleccionado?", "Eliminacion de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_Actores.Eliminar_Actor(Convert.ToInt16(txtID_Actor.Text));
            }
            else
            {
                MessageBox.Show("Eliminacion de registro abortada", "Eliminacion de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Agregar_Actor()
        {
            if (txtactor.Text.Trim() == "")
            {
                MessageBox.Show("El campo se encuentra vacio, Completelo", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                agregar.Nombre_Actor = txtactor.Text;
            }
        }
        public void Modificar_Actor()
        {
            Actualizar.ID_Actor = Convert.ToInt32(txtID_Actor);
            Actualizar.Nombre_Actor = txtactor.Text;
            Funciones_Actores.Actualizar_Actor(Actualizar);
        }
        private void BtnAgregar_Actor_Click(object sender, EventArgs e)
        {
            Limpiar_Datos();
            Agregar_Actor();
            Mostrar_Actores();
        }
        private void BtnMostrar_Actores_Click(object sender, EventArgs e)
        {
            Limpiar_Datos();
            Mostrar_Actores();
        }
        private void BtnActualizar_Actor_Click(object sender, EventArgs e)
        {
            Limpiar_Datos();
            Modificar_Actor();
            btnActualizar_Actor.Enabled = false;
            btnAgregar_Actor.Enabled = true;
            btnEliminar_Actor.Enabled = false;
        }
        private void BtnEliminar_Actor_Click(object sender, EventArgs e)
        {
            Eliminar_Actor();
            Limpiar_Datos();
            Mostrar_Actores();
            btnActualizar_Actor.Enabled = false;
            btnAgregar_Actor.Enabled = true;
            btnEliminar_Actor.Enabled = false;
        }
        private void DgvActores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvActores.CurrentRow.Index;
            txtID_Actor.Text = this.dgvActores[0, posicion].Value.ToString();
            txtactor.Text = this.dgvActores[1, posicion].Value.ToString();
            btnActualizar_Actor.Enabled = true;
            btnEliminar_Actor.Enabled = true;
            btnAgregar_Actor.Enabled = false;
        }
        private void FrmActores_Load(object sender, EventArgs e)
        {
            Mostrar_Actores();
            this.dgvActores.Columns[0].Visible = false;
            btnActualizar_Actor.Enabled = false;
            btnEliminar_Actor.Enabled = false;
        }
        private void TxtNombre_Actor_Validated(object sender, EventArgs e)
        {
            if (txtactor.Text.Trim() == "")
            {
                epError3.SetError(txtactor, "Introduce la capacidad de la sala.");
                txtactor.Focus();
            }
            else
            {
                epError3.Clear();
            }
        }
        private void TxtNombre_Actor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            // codigo para solo ingresar letras(vocales y mayusculas, sin simbolos) usando codigo ASCII
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Insertar solo vocales y consonantes", "ERROR DE PRUEBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}

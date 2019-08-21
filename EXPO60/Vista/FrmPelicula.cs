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
    public partial class FrmPelicula : Form
    {
        public FrmPelicula()
        {
            InitializeComponent();
        }
        Constructor_pelicula agregar = new Constructor_pelicula();
        Constructor_pelicula actualizar = new Constructor_pelicula();
        public void mostrarPeliculas()
        {
            dgvpeliculas.DataSource = Funciones_peliculas.mostrarPeliculas();
        }
        public void modificarRegistro()
        {
            actualizar.Titulo = txttitulo.Text;
            actualizar.Año = Convert.ToInt16(txtaño);
            actualizar.Director = txtdirector.Text;
            actualizar.Idioma = txtaudio.Text;
            Funciones_peliculas.actualizarPelicula(actualizar);
        }
        public void eliminarRegistro()
        {
            if (MessageBox.Show("Esta seguro de realizar esta operacion?", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_peliculas.eliminarPelicula(Convert.ToInt32(idPelicula.Text));
            }

        }

        public void vaciarampos()
        {
            txttitulo.Clear();
            txtaño.Clear();
        }
        public void agregarEmpresa()
        {
            agregar.Titulo = txttitulo.Text;
            agregar.Año = Convert.ToInt16(txtaño.Text);
            agregar.Director = txtdirector.Text;
            agregar.Idioma = txtaudio.Text;
            int datos = Funciones_peliculas.insertarPelicula(agregar);
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar el formulario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void txtaudio_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void txtdirector_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void txttitulo_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txttitulo.Text == "" || txtaño.Text == "")
            {
                MessageBox.Show("Por favor rellena todos los campos que se te piden", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                agregarEmpresa();
                
                vaciarampos();
            }
        }

        private void FrmPelicula_Load(object sender, EventArgs e)
        {
            mostrarPeliculas();
            this.dgvpeliculas.Columns[0].Visible = false;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            mostrarPeliculas();
        }

        private void dgvpeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvpeliculas.CurrentRow.Index;
            idPelicula.Text = this.dgvpeliculas[0, posicion].Value.ToString();
            txttitulo.Text = this.dgvpeliculas[1, posicion].Value.ToString();
            txtaño.Text = this.dgvpeliculas[2, posicion].Value.ToString();
            txtdirector.Text = this.dgvpeliculas[3, posicion].Value.ToString();
            btnactualizar.Enabled = true;
            btneliminar.Enabled = true;
            btnagregar.Enabled = false;
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            modificarRegistro();
            vaciarampos();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
            mostrarPeliculas();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            eliminarRegistro();
            vaciarampos();
            mostrarPeliculas();
            btnactualizar.Enabled = false;
            btnagregar.Enabled = true;
            btneliminar.Enabled = false;
        }
    }
}

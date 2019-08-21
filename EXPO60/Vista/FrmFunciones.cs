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

namespace EXPO60.Vista
{
    public partial class FrmFunciones : Form
    {
        public FrmFunciones()
        {
            InitializeComponent();
        }
        Constructor_funciones agregar = new Constructor_funciones();
        Constructor_funciones actualizar = new Constructor_funciones();
        public void agregarFunciones()
        {
            agregar.duracion = mskDuracion.Text;
            agregar.hora = mskHora.Text;
            int datos = Funciones_funcion.insertarFuncion(agregar);
        }
        public void eliminarRegistro()
        {
            if (MessageBox.Show("Esta seguro de realizar esta operacion?", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_funcion.eliminarFuncion(Convert.ToInt32(textBox1.Text));
            }

        }

        public void modificarRegistro()
        {
            actualizar.duracion = mskDuracion.Text;
            actualizar.hora = mskHora.Text;
            Funciones_funcion.actualizarFunciones(actualizar);
        }
        public void vaciarampos()
        {
            mskDuracion.Clear();
            mskHora.Clear();
        }
        public void mostrarFunciones()
        {
            dgvFuncion.DataSource = Funciones_funcion.mostrarFunciones();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar el formulario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            eliminarRegistro();
            vaciarampos();
            mostrarFunciones();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnagregar.Enabled = true;
        }
        public void mostrarET()
        {

            cmbpelicula.DataSource = Funciones_funcion.ObtenerPelicula();
            cmbpelicula.DisplayMember = "titulo";
            cmbpelicula.ValueMember = "id_pelicula";


            cmbClasificacion.DataSource = Funciones_funcion.ObtenerClasificacion();
            cmbClasificacion.DisplayMember = "clasificacion";
            cmbClasificacion.ValueMember = "id_clasificacion";

            cmbSala.DataSource = Funciones_funcion.ObtenerSala();
            cmbSala.DisplayMember = "num_sala";
            cmbSala.ValueMember = "id_sala";



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (mskDuracion.Text == "000minutos" || mskHora.Text == "00:00")
            {
                MessageBox.Show("Por favor rellena todos los campos que se te piden", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                agregarFunciones();
                mostrarFunciones();
                vaciarampos();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            mostrarFunciones();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
            modificarRegistro();
            vaciarampos();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnagregar.Enabled = true;
            mostrarFunciones();
        }

        private void dgvFuncion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvFuncion.CurrentRow.Index;
            textBox1.Text = this.dgvFuncion[0, posicion].Value.ToString();
            mskDuracion.Text = this.dgvFuncion[1, posicion].Value.ToString();
            mskHora.Text = this.dgvFuncion[2, posicion].Value.ToString();
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnagregar.Enabled = false;
        }

        private void FrmFunciones_Load(object sender, EventArgs e)
        {
            mostrarFunciones();
            mostrarET();
            this.dgvFuncion.Columns[0].Visible = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }
    }
}

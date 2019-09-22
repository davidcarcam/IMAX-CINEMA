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
    public partial class FrmFunciones : Form
    {
        public FrmFunciones()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            mostrarET();

        }
        Constructor_funciones agregar = new Constructor_funciones();
        Constructor_funciones actualizar = new Constructor_funciones();
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
        public void agregarFunciones()
        {
            MessageBox.Show(mskDuracion.Text);
            agregar.duracion = mskDuracion.Text;
            agregar.hora = mskHora.Text;
            agregar.pelicula = Convert.ToInt16(cmbpelicula.SelectedValue);
            agregar.sala = Convert.ToInt16(cmbSala.SelectedValue);
            agregar.clasifiacion = Convert.ToInt16(cmbClasificacion.SelectedValue);
            agregar.dia = dateTimePicker1.Text;
            int datos = Funciones_funcion.insertarFuncion(agregar);
        }

        public bool validarFuncion()
        {
            foreach(DataRow r in dgvFuncion.Rows)
            {
                MessageBox.Show(r["pelicula"].ToString());
            }
            return true;
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
            actualizar.id_funcion = Convert.ToInt32(textBox1.Text);
            actualizar.duracion = mskDuracion.Text;
            actualizar.hora = mskHora.Text;
            actualizar.dia = dateTimePicker1.Text;
            actualizar.pelicula = Convert.ToInt16(cmbpelicula.SelectedValue);
            actualizar.sala = Convert.ToInt16(cmbSala.SelectedValue);
            actualizar.clasifiacion = Convert.ToInt16(cmbClasificacion.SelectedValue);
            agregar.dia = dateTimePicker1.Text;
            Funciones_funcion.actualizarFunciones(actualizar);
        }
        public void vaciarampos()
        {
            mskDuracion.Clear();
            mskHora.Clear();
        }
        public void mostrarFunciones()
        {
            try
            {
                int id_sala = Convert.ToInt32(cmbSala.SelectedValue);
                dgvFuncion.DataSource = Funciones_funcion.mostrarFunciones(dateTimePicker1.Text, cmbSala.SelectedValue.ToString());
                if (dgvFuncion.Rows.Count > 0)
                {
                    dgvFuncion.Columns["id_funcion"].Visible = false;
                    dgvFuncion.Columns["id_sala"].Visible = false;
                    dgvFuncion.Columns["id_pelicula"].Visible = false;
                    dgvFuncion.Columns["id_clasifiacion"].Visible = false;
                }
            }
            catch(Exception)
            {

            }
               
            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
                this.Close();
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
            DateTime fecha = DateTime.Today.AddDays(15);
            if (dateTimePicker1.Value.Date > fecha)
            {
                MessageBox.Show("La fecha ingresada esta fuera del rango permitido","Fecha superior",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
              
            }
            else
            {
                if (dateTimePicker1.Value.Date < DateTime.Today)
                {
                    MessageBox.Show("La fecha ingresada es menor a la de hoy", "La fecha es erronea", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    agregarFunciones();
                    mostrarFunciones();
                    vaciarampos();
                }
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
            
        }

        private void FrmFunciones_Load(object sender, EventArgs e)
        {
            mostrarFunciones();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                dgvFuncion.CurrentCell = null;
                foreach (DataGridViewRow r in dgvFuncion.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvFuncion.Rows)
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
                mostrarFunciones();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            vaciarampos();
            mostrarFunciones();

        }
        private void dgvFuncion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvFuncion.CurrentRow.Index;
            textBox1.Text = dgvFuncion["id_funcion", posicion].Value.ToString();
            mskDuracion.Text = dgvFuncion["duracion", posicion].Value.ToString();
            mskHora.Text = dgvFuncion["hora", posicion].Value.ToString();
            cmbpelicula.SelectedValue = dgvFuncion["id_pelicula", posicion].Value.ToString();
            cmbClasificacion.SelectedValue = dgvFuncion["id_clasifiacion", posicion].Value.ToString();
            cmbSala.SelectedValue = dgvFuncion["id_sala", posicion].Value.ToString();
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
            btnagregar.Enabled = false;
        }

        private void cmbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            vaciarampos();
            mostrarFunciones();
        }
    }
}

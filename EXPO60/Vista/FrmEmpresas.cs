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
    public partial class FrmEmpresas : Form
    {
        public FrmEmpresas()
        {
            InitializeComponent();
        }
        constructorEmpresa agregar = new constructorEmpresa();
        public void agregarEmpresa()
        {
            agregar.nombreEmpresa = txtNumero.Text;
            agregar.direccionEmpresa = textBox1.Text;
            int datos = funcionesEmpresa.insertarLocal(agregar);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            agregarEmpresa();
            mostrarEmpresas();
            vaciarampos();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        public void mostrarEmpresas()
        {
            dgvactores.DataSource = funcionesEmpresa.mostrarEmpresas();
        }
        public void vaciarampos()
        {
            txtNumero.Clear();
            textBox1.Clear();
        }

        private void FrmEmpresas_Load(object sender, EventArgs e)
        {
            mostrarEmpresas();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            mostrarEmpresas();
        }
    }
}

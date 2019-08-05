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
            agregar.nombreEmpresa = txtNombreEmpresa.Text;
            agregar.direccionEmpresa = txtDirrecionEmpresa.Text;
            int datos = funcionesEmpresa.insertarLocal(agregar);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

        }
    }
}

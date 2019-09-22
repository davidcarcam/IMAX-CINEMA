using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXPO60.Reportes
{
    public partial class ReporteProveedores : Form
    {
        public ReporteProveedores()
        {
            InitializeComponent();
        }
        private void ReporteProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetProveedores.Proveedores' Puede moverla o quitarla según sea necesario.
            this.ProveedoresTableAdapter.Proveedores(this.DataSetProveedores.Proveedores);

            this.reportViewer1.RefreshReport();
        }
    }
}

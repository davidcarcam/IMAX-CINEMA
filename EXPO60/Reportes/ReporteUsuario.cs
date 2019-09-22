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
    public partial class ReporteUsuario : Form
    {
        public ReporteUsuario()
        {
            InitializeComponent();
        }

        private void ReporteUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetUsuario.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Usuario(this.DataSetUsuario.DataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}

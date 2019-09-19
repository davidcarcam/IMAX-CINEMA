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
    public partial class ReporteFacturaLocal : Form
    {
        public ReporteFacturaLocal()
        {
            InitializeComponent();
        }

        private void ReporteFacturaLocal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetFacturaLocal.factura_local' Puede moverla o quitarla según sea necesario.
            this.factura_localTableAdapter.MostrarDatosDeFactura(DataSetFacturaLocal.factura_local);

            this.reportViewer1.RefreshReport();
        }

        private void ReporteFacturaLocal_Load_1(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }
    }
}

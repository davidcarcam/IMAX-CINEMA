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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetProducto.Producto' Puede moverla o quitarla según sea necesario.
            this.ProductoTableAdapter.Producto(this.DataSetProducto.Producto);

            this.reportViewer1.RefreshReport();
        }
    }
}

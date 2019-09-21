using EXPO60.Reportes;
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
    public partial class ReporteAsientos : Form
    {
        public ReporteAsientos()
        {
            InitializeComponent();
        }

        private void ReporteAsientos_Load(object sender, EventArgs e)
        {
            ReporteAsientos repro = new ReporteAsientos();
            repro.Show();
        }
    }
}

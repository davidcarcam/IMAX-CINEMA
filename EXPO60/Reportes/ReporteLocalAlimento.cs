﻿using System;
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
    public partial class ReporteLocalAlimento : Form
    {
        public ReporteLocalAlimento()
        {
            InitializeComponent();
        }

        private void ReporteLocalAlimento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetLocalAlimento.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.LocalAlimento(this.DataSetLocalAlimento.DataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}

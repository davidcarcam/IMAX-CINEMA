﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXPO60.Vista
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btbAcceder_Click(object sender, EventArgs e)
        {
            FrmPrincipal f = new FrmPrincipal();
            f.ShowDialog();
        }
    }
}

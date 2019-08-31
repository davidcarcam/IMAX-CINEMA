using System;
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
    public partial class Tipo_recuperacion : Form
    {
        public Tipo_recuperacion()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            RecuAdmin kk = new RecuAdmin();
            kk.Show();
            this.Hide();
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            recuperarUsuario kk = new recuperarUsuario();
            kk.Show();
            this.Hide();
        }
    }
}

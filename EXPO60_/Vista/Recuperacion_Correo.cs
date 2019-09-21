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
    public partial class Recuperacion_Correo : Form
    {
        public Recuperacion_Correo()
        {
            InitializeComponent();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Trim() == "")
                {
                    MessageBox.Show("Complete el campo de usuario", "Llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        Recovery user = new Recovery();
                        var result = user.recovery(txtUsuario.Text);
                        txtcodigo.Enabled = true;
                        button1.Enabled = true;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error al embiar el correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al embiar el correo electronico");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Trim() == "")
            {
                MessageBox.Show("campos vacios", "Llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ContructorLogin2 cons = new ContructorLogin2();
                cons.cod = Convert.ToInt16(txtcodigo.Text);
                bool datos = ValidarLogin.validarcod(cons);
                if (datos == true)
                {
                    txtcodigo.Clear();
                    Form f = new ConfirmarContraseña();
                    f.Show();
                    this.Hide();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXPO60.Controlador;
using EXPO60.Modelo;
using System.IO;

namespace EXPO60.Vista
{
    public partial class FrmAgregar_empresa : Form
    {
        public FrmAgregar_empresa()
        {
            InitializeComponent();
        }

        private void FrmAgregar_empresa_Load(object sender, EventArgs e)
        {
            TipoEmpresa();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        void TipoEmpresa()
        {
            cmbTipoEmpresa.DataSource = funciones_Empresa.mostrarEmpresas();
            cmbTipoEmpresa.ValueMember = "id_tipoemp";
            cmbTipoEmpresa.DisplayMember = "tipoempresa";
        }
        public Image TextoaImagen(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
            imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            pbLogo.Image = Image.FromStream(ms);
            return image;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Trim() == "" || txtEmpresa.Text.Trim() == "" || txtNit.Text.Trim() == "" || txtRepresentante.Text.Trim() == "" || pbLogo == null)
            {
                MessageBox.Show("Existen campos vacios", "Informacion incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Constructor_agregarEmpresa che = new Constructor_agregarEmpresa();
                che.id_tipo_empresa = Convert.ToInt16(cmbTipoEmpresa.SelectedValue);
                Constructor_agregarEmpresa.nombreEmpresa = txtEmpresa.Text;
                che.direccionEmpresa = txtDireccion.Text;
                che.nit = txtNit.Text;
                che.representante = txtRepresentante.Text;
                MemoryStream ms = new MemoryStream();
                pbLogo.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();
                string enconded = Convert.ToBase64String(aByte);
                txtlogo.Text = enconded;
                che.logo = txtlogo.Text;
                funciones_Empresa.insertarLocal(che);
                FrmLogin kk = new FrmLogin();
                kk.Show();
                this.Hide();
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                txtlogo.Clear();
                AbrirImagen.Filter = "Archivo de Imagen (.jpg) |*.jpg | Archivo de Imagen (.png) |*.png| Archivo de Imagen (.jpeg) |*.jpge| Todos los Archivos|*.*";
                DialogResult resultado = AbrirImagen.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pbLogo.Image = Image.FromFile(AbrirImagen.FileName);
                    MemoryStream ms = new MemoryStream();
                    pbLogo.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] aByte = ms.ToArray();
                    string enconded = Convert.ToBase64String(aByte);
                    txtlogo.Text = enconded;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar la imagen", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

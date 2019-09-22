using EXPO60.Controlador;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXPO60.Vista;
using System.Windows.Forms.DataVisualization.Charting;

namespace EXPO60.graficos
{
    public partial class graficoSalas : Form
    {
        public graficoSalas()
        {
            InitializeComponent();
        }
        public DataTable EnviarDatos(string consulta)
        {
            DataTable tabla = new DataTable();
            MySqlDataAdapter mda = new MySqlDataAdapter(consulta, Conexion.ObtenerConexion());
            mda.Fill(tabla);
            return tabla;
        }

        private void graficoSalas_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion.ObtenerConexion();
                grafico.Palette = ChartColorPalette.SemiTransparent;
                grafico.Series["Series1"].LegendText = "Gráfico de Salas";
                grafico.Series["Series1"].XValueMember = "num_sala";
                grafico.Series["Series1"].YValueMembers = "capacidad";
                grafico.DataSource = EnviarDatos("SELECT id_sala AS ID, num_sala, capacidad, estado_sala FROM salas INNER JOIN estado_sala ON salas.id_estado_sala = estado_sala.id_estado_sala");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido establecer la conexion" + ex, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.ObtenerConexion();
                grafico.Palette = ChartColorPalette.SemiTransparent;
                grafico.Series["Series1"].LegendText = "Gráfico de Salas";
                grafico.Series["Series1"].XValueMember = "num_sala";
                grafico.Series["Series1"].YValueMembers = "capacidad";
                grafico.DataSource = EnviarDatos("SELECT id_sala AS ID, num_sala, capacidad, estado_sala FROM salas INNER JOIN estado_sala ON salas.id_estado_sala = estado_sala.id_estado_sala");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido establecer la conexion" + ex, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using EXPO60.Controlador;
using EXPO60.Vista;
using MySql.Data.MySqlClient;

namespace EXPO60.graficos
{
    public partial class Grafico_pelicula : Form
    {
        public Grafico_pelicula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.ObtenerConexion();
                grafico.Palette = ChartColorPalette.SemiTransparent;
                grafico.Series["Series1"].LegendText = "Gráfico de películas";
                grafico.Series["Series1"].XValueMember = "titulo";
                grafico.Series["Series1"].YValueMembers = "ano";
                grafico.DataSource = EnviarDatos("SELECT id_pelicula AS ID, ano, titulo, director, genero, idioma, formato, estado_pel FROM peliculas INNER JOIN generos ON peliculas.id_genero = generos.id_genero INNER JOIN idiomas ON peliculas.id_idioma = idiomas.id_idioma INNER JOIN formatos ON peliculas.id_formatos = formatos.id_formatos INNER JOIN estado_pelicula ON peliculas.id_estado_pelicula = estado_pelicula.id_estado_pelicula");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido establecer la conexion"+ex, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }
        public DataTable EnviarDatos(string consulta)
        {
            DataTable tabla = new DataTable();
            MySqlDataAdapter mda = new MySqlDataAdapter(consulta, Conexion.ObtenerConexion());
            mda.Fill(tabla);
            return tabla;
            /*
             Se ubica separado este metodo por que es parte del select de la tabla donde se extraen los valores
             */
        }

        private void Grafico_pelicula_Load(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();
            grafico.Palette = ChartColorPalette.SemiTransparent;
            grafico.Series["Series1"].LegendText = "Gráfico de películas";
            grafico.Series["Series1"].XValueMember = "titulo";
            grafico.Series["Series1"].YValueMembers = "ano";
            grafico.DataSource = EnviarDatos("SELECT id_pelicula AS ID, ano, titulo, director, genero, idioma, formato, estado_pel FROM peliculas INNER JOIN generos ON peliculas.id_genero = generos.id_genero INNER JOIN idiomas ON peliculas.id_idioma = idiomas.id_idioma INNER JOIN formatos ON peliculas.id_formatos = formatos.id_formatos INNER JOIN estado_pelicula ON peliculas.id_estado_pelicula = estado_pelicula.id_estado_pelicula");
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXPO60.Controlador;
using MySql.Data.MySqlClient;
using System.Data;


namespace EXPO60.Modelo
{
    class FuncionPersonajes
    {
        public static int IngresarPersonaje(Constructor_Personajes add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO personajes (personaje ,id_actor , id_pelicula ) VALUES ('{0}', '{1}', '{2}')",add.nombre, add.actor, add.pelicula), Conexion.ObtenerConexion());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Personaje ingresado exitosamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El personaje no pudo ser ingresada, intente nuevamente y verifique que los datos sean correctos", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error critico de conexion " + e.Message, "Fallo de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable MostrarPersonaje()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_personaje AS ID, personaje,actor,titulo FROM personajes INNER JOIN actores ON personajes.id_actor = actores.id_actor INNER JOIN peliculas ON personajes.id_pelicula = peliculas.id_pelicula";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!, ha ocurrido un error en la obtencion de datos, consulte con su administrador. "+ex, "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data = new DataTable();
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
        public static bool ActualizarPersonaje(Constructor_Personajes upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE personajes SET personaje = '{0}', id_actor = '{1}',id_pelicula = '{2}' WHERE id_personaje = '{3}'", upd.nombre, upd.actor, upd.pelicula,upd.idpersonaje), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdupd.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Datos actualizados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser actualizados", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Oops!, ha ocurrido un problema, revise su conexion a internet o los servicios del servidor, consulte con el administrador" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static bool EliminarPersonaje(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM personajes WHERE id_personaje = '{0}'", id), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("El registro ha sido eliminado correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser eliminado", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Oops!, ha ocurrido un error en la obtencion de datos, consulte con su administrador. " + e, "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable obtenerActor()
        {
            string query = "SELECT * FROM actores";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error crítico " + e);
                return data;
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
        public static DataTable obtenerpelicula()
        {
            string query = "SELECT * FROM peliculas";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error crítico " + e);
                return data;
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
    }
}


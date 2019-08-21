﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using EXPO60.Controlador;
using System.Windows.Forms;
using System.Data;

namespace EXPO60.Modelo
{
    class Funciones_funcion
    {
        public static int insertarFuncion(Constructor_funciones add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO funciones(duracion, hora ) VALUES ('{0}','{1}')", add.duracion, add.hora), Conexion.ObtenerConexion());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Local agregado exitosamente", "proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha podido agregar el local", "proceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error critico de  conexion, revise su conexion de internet o consulte con el administrador " , "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }
        public static DataTable mostrarFunciones()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM funciones";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adapter.Fill(data);
                return data;
            }
            catch (Exception)
            {

                MessageBox.Show("Ops a ocurrido un problema con la obteccion de datos consulte con el administrador", "error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data = new DataTable();
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
        public static bool actualizarFunciones(Constructor_funciones upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE funciones SET duracion ='{0}' , hora = '{1}'", upd.duracion, upd.hora), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdupd.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Datos actualizados correctamente", "actualizacion completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Datos no se pudieron actualizados correctamente", "actualizacion denegada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception)
            {

                MessageBox.Show("Datos no actualizados correctamente , revise su conexion a internet o consulte con el administrador", "error critico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }
        }
        public static bool eliminarFuncion(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM funciones WHERE id_funcion = '{0}'", id), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Datos eliminados correctamente", "eliminacion completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos no se han podido eliminar correctamente", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return retorno;
            }
            catch (Exception)
            {

                MessageBox.Show("oops erro de coneccion consulte con el administrador", "error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable ObtenerPelicula()
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
        public static DataTable ObtenerClasificacion()
        {
            string query = "SELECT * FROM clasificacion";
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
        public static DataTable ObtenerSala()
        {
            string query = "SELECT * FROM salas";
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

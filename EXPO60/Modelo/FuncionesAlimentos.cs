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
    class FuncionesAlimentos
    {
        public static int insertarLocalAlimentos(Constructor_localAlimentos add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO local_alimentos (nombre, telefono ) VALUES ('{0}','{1}')", add.NombreLocal, add.Telefono), Conexion.ObtenerConexion());
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

                MessageBox.Show("Error critico de  conexion, consulte con el administrador " + ex, "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }
        public static DataTable mostrarlocal()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM  local_alimentos";
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
        public static bool actualizarLocal(Constructor_localAlimentos upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE  local_alimentos SET nombre ='{0}' , telefono = '{1}'", upd.NombreLocal, upd.Telefono), Conexion.ObtenerConexion());
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
            catch (Exception )
            {

                MessageBox.Show("Datos no actualizados correctamente , revise su conexion a internet o consulte con el administrador", "error critico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }
        }
        public static bool eliminarLocal(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM  local_alimentos WHERE id_local = '{0}'", id), Conexion.ObtenerConexion());
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

                MessageBox.Show("oops error de conexion consulte con el administrador", "error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}

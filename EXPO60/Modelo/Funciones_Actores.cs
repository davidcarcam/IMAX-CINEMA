using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using EXPO60.Controlador;

namespace EXPO60.Modelo
{
    class Funciones_Actores
    {
        public static int Ingresar_Actor(Constructor_Actores add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdcreate2 = new MySqlCommand(String.Format("INSERT INTO actores (actor) VALUES ('{0}')", add.Nombre_Actor), Conexion.ObtenerConexion());
                retorno = Convert.ToInt16(cmdcreate2.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("El nombre del actor ha sido ingresado con exito en la base de datos", "Insercion del nombre del actor exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hubo un fallo en la insercion del nombre del actor, asegurese de que los datos esten correctos", "Fallo al ingresar nombre del actor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception a)
            {
                MessageBox.Show("ha ocurrido un fallo al ejecutar el comando, por favor contacte con el administrador", "Error Critico" + a, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable Mostrar_Actores()
        {
            DataTable Actores;
            try
            {
                string query = "SELECT * FROM actores";
                MySqlCommand cmdread2 = new MySqlCommand(string.Format(query), Conexion.ObtenerConexion());
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmdread2);
                Actores = new DataTable();
                adapter2.Fill(Actores);
                return Actores;
            }
            catch (Exception b)
            {
                MessageBox.Show("Se ha detectado un fallo en la conexion, Consulte con un administrador cercano", "Error Critico" + b, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Actores = new DataTable();
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
        public static bool Actualizar_Actor(Constructor_Actores upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupdate2 = new MySqlCommand(string.Format("UPDATE actores SET actor = '{1}' WHERE id_actor = '{0}'", upd.ID_Actor, upd.Nombre_Actor), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdupdate2.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("El nombre del registro ha sido actualizado", "Actualizacion safistactoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fallo al actualizar el nombre del actor", "Fallo en actualizar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception c)
            {
                MessageBox.Show("Se ha detectado un fallo en la conexion, Consulte con un administrador cercano", "Error Critico" + c, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static bool Eliminar_Actor(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdeliminar2 = new MySqlCommand(string.Format("DELETE FROM actores WHERE id_actor = '{0}'", id), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdeliminar2.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("El registro ha sido eliminado de la base de datos satisfactoriamente", "Eliminacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro no se ha podido eliminar de la base de datos", "Fallo durante la eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception d)
            {
                MessageBox.Show("Se ha detectado un fallo en la conexion, Consulte con un administrador cercano" +d.Message, "Error Critico" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}

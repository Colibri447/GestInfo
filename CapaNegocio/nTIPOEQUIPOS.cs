using GestInfo.CapaDatos;
using GestInfo.CapaEntidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestInfo.CapaNegocio
{
    internal class nTIPOEQUIPOS
    {
        //metodo que inicializa la entidad con la propiedad nombre
        private readonly dInventarioCliente dInventarioCliente = new dInventarioCliente();

        private Tipoequipos RellenarEntidadNombre(string nombre)
        {
            Tipoequipos tipoequipos = new Tipoequipos(nombre);

            return tipoequipos;
        }

        //metodo que inicializa la entidad con todas las propiedades rellenadas con el constructor con todos los parametros
        private Tipoequipos RellenarEntidad(int id, string nombre)
        {
            Tipoequipos tipoequipos = new Tipoequipos(id, nombre);

            return tipoequipos;
        }

        /**
         *
         * Los metodos privados 'RellenarEntidadNombre' y 'RellenarEntidad' se encarga de crear
         * entidades 'Tipoequipos' con los campos que se rellenen en presentación,
         * para luego con los siguentes metodos realizar todas las acciones con
         *
         */

        //Método para insertar un tipo de equipo
        internal void Insert_INVENT_EQUI(string nombre)
        {
            try
            {
                dInventarioCliente.Insert_INVENT_EQUI(RellenarEntidadNombre(nombre));
            }
            catch (SqlException exSql)
            {
                MessageBox.Show(exSql.Message, "Error Sql Alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método para borrar un tipo de equipo
        internal void Delete_INVENT_EQUI(int id, string nombre)
        {
            try
            {
                dInventarioCliente.Delete_INVENT_EQUI(RellenarEntidad(id, nombre));
            }
            catch (SqlException exSql)
            {
                MessageBox.Show(exSql.Message, "Error Sql Alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método para modificar un tipo de equipo
        internal void Update_INVENT_EQUI(int id, string nombre)
        {
            try
            {
                dInventarioCliente.Update_INVENT_EQUI(RellenarEntidad(id, nombre));
            }
            catch (SqlException exSql)
            {
                MessageBox.Show(exSql.Message, "Error Sql Alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método para seleccionar la tabla TIPOEQUIPOS
        internal DataTable Select_INVENT_EQUI()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dInventarioCliente.Select_INVENT_EQUI();
            }
            catch (SqlException exSql)
            {
                MessageBox.Show(exSql.Message, "Error Sql Select ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Baja Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}
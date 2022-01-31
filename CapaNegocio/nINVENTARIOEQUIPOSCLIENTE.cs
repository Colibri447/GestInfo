using GestInfo.CapaDatos;
using GestInfo.CapaEntidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestInfo.CapaNegocio
{
    internal class nINVENTARIOEQUIPOSCLIENTE
    {
        private readonly dInventarioCliente dInventarioCliente = new dInventarioCliente();

        //metodo que inicializa la entidad con todas las propiedades rellenadas con el constructor con todos los parametros

        private InventarioEquiposCliente rellenarentidad(int IdInventario, string NumeroSerieInventarioEquipo, string MarcaInventarioEquipo, string ModeloInventarioEquipo, int IdTipoInventarioEquipo, DateTime FchaAltaInventarioEquipo, DateTime FchaBajaInventarioEquipo, int IdCliente)
        {
            InventarioEquiposCliente inven = new InventarioEquiposCliente(IdInventario, NumeroSerieInventarioEquipo, MarcaInventarioEquipo, ModeloInventarioEquipo, IdTipoInventarioEquipo, FchaAltaInventarioEquipo, FchaBajaInventarioEquipo, IdCliente);

            return inven;
        }

        //metodo que inicializa la entidad con todas las propiedades rellenadas con el constructor con todos los parametros menos el id
        private InventarioEquiposCliente RellenarEntidadSinId(string NumeroSerieInventarioEquipo, string MarcaInventarioEquipo, string ModeloInventarioEquipo, int IdTipoInventarioEquipo, DateTime FchaAltaInventarioEquipo, DateTime FchaBajaInventarioEquipo, int IdCliente)
        {
            InventarioEquiposCliente invent = new InventarioEquiposCliente(NumeroSerieInventarioEquipo, MarcaInventarioEquipo, ModeloInventarioEquipo, IdTipoInventarioEquipo, FchaAltaInventarioEquipo, FchaBajaInventarioEquipo, IdCliente);

            return invent;
        }

        private InventarioEquiposCliente rellenarentidadsoloconid(int IdInventario)
        {
            InventarioEquiposCliente inven = new InventarioEquiposCliente(IdInventario);

            return inven;
        }

        //metodo para insertar inventario
        internal void Insert_INVENT(string NumeroSerieInventarioEquipo, string MarcaInventarioEquipo, string ModeloInventarioEquipo, int IdTipoInventarioEquipo, DateTime FchaAltaInventarioEquipo, DateTime FchaBajaInventarioEquipo, int IdCliente)
        {
            try
            {
                dInventarioCliente.Insert_INVENT(RellenarEntidadSinId(NumeroSerieInventarioEquipo, MarcaInventarioEquipo, ModeloInventarioEquipo, IdTipoInventarioEquipo, FchaAltaInventarioEquipo, FchaBajaInventarioEquipo, IdCliente));
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

        //metodo para actualizar el inventario
        internal void Update_INVENT(int IdInventario, string NumeroSerieInventarioEquipo, string MarcaInventarioEquipo, string ModeloInventarioEquipo, int IdTipoInventarioEquipo, DateTime FchaAltaInventarioEquipo, DateTime FchaBajaInventarioEquipo, int IdCliente)
        {
            try
            {
                dInventarioCliente.Update_INVENT(rellenarentidad(IdInventario, NumeroSerieInventarioEquipo, MarcaInventarioEquipo, ModeloInventarioEquipo, IdTipoInventarioEquipo, FchaAltaInventarioEquipo, FchaBajaInventarioEquipo, IdCliente));
            }
            catch (SqlException exSql)
            {
                MessageBox.Show(exSql.Message, "Error Sql Modificacíon ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Baja Modificacíon", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //metodo para borrar el inventario
        internal void Delete_INVENT(int IdInventario)
        {
            try
            {
                dInventarioCliente.Delete_INVENT(rellenarentidadsoloconid(IdInventario));
            }
            catch (SqlException exSql)
            {
                MessageBox.Show(exSql.Message, "Error Sql Baja ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //metodo para mostrar el inventario
        internal DataTable SelectTablaInventario()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dInventarioCliente.Select_INVENT();
            }
            catch (SqlException exSql)
            {
                MessageBox.Show(exSql.Message, "Error Sql Select 0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Baja Select 0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        //metodo para mostrar el iventario metiendo el id
        internal DataTable Select_INVENT_ID(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dInventarioCliente.Select_INVENT_ID(rellenarentidadsoloconid(id));
            }
            catch (SqlException exSql)
            {
                MessageBox.Show(exSql.Message, "Error Sql Select 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Baja Select 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}
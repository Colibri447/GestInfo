// *****************************************************************************************************
// INFORMACION:
//
// EQUIPO DE DESARROLLO:  Equipo 2
// COMPONENTES DEL EQUIPO: Pedro, David, Alex, Irene
// FECHA: 26.01.2022
// *****************************************************************************************************







using GestInfo.CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace GestInfo.CapaDatos
{
    internal class dInventarioCliente
    {
        private readonly BBDD_Conex bDD_Conex = new BBDD_Conex();
        /**
         *
         * Select de las tablas INVENT.. y INVENT_EQUI..
         *
         */

        public DataTable Select_INVENT()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_SELECT_INVENT", bDD_Conex.Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter Sqldat = new SqlDataAdapter(cmd);
            Sqldat.Fill(dt);
            return dt;
        }

        public DataTable Select_INVENT_EQUI()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_SELECT_INVENT_EQUI", bDD_Conex.Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter Sqldat = new SqlDataAdapter(cmd);
            Sqldat.Fill(dt);
            return dt;
        }

        public DataTable Select_INVENT_ID(InventarioEquiposCliente inventario)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_SELECT_ID_INVENT", bDD_Conex.Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@IdInventario", inventario.IdInventario);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            return dt;
        }

        /**
         *
         * Insert de las tablas INVENT.. y INVENT_EQUI..
         *
         */

        public void Insert_INVENT(InventarioEquiposCliente inventarioEquiposCliente)
        {
            SqlCommand SqlCmd = new SqlCommand("SP_INSERT_INVENT", bDD_Conex.Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@NumeroSerieInventarioEquipo", inventarioEquiposCliente.NumeroSerieInventarioEquipo);
            SqlCmd.Parameters.AddWithValue("@MarcaInventarioEquipo", inventarioEquiposCliente.MarcaInventarioEquipo);
            SqlCmd.Parameters.AddWithValue("@ModeloInventarioEquipo ", inventarioEquiposCliente.ModeloInventarioEquipo);
            SqlCmd.Parameters.AddWithValue("@IdTipoInventarioEquipo", inventarioEquiposCliente.IdTipoInventarioEquipo);
            SqlCmd.Parameters.AddWithValue("@IdCliente", inventarioEquiposCliente.IdCliente);

            SqlCmd.ExecuteNonQuery();
            bDD_Conex.cerrarConexion();
        }

        public void Insert_INVENT_EQUI(Tipoequipos tipoequipos)
        {
            SqlCommand SqlCmd = new SqlCommand("SP_INSERT_INVENT_EQUI", bDD_Conex.Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@NombreTipoEquipo", tipoequipos.NombreTipoEquipo);

            SqlCmd.ExecuteNonQuery();
            bDD_Conex.cerrarConexion();
        }

        /**
         *
         * Delete de las tablas INVENT.. y INVENT_EQUI..
         *
         */

        public void Delete_INVENT(InventarioEquiposCliente inventarioEquiposCliente)
        {
            SqlCommand SqlCmd = new SqlCommand("SP_DELETE_INVENT", bDD_Conex.Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@IdInventario", inventarioEquiposCliente.IdInventario);

            SqlCmd.ExecuteNonQuery();
            bDD_Conex.cerrarConexion();
        }

        /**
         *
         *
         delete de la tabla tipoequipos
        */

        public void Delete_INVENT_EQUI(Tipoequipos tipoequipos)
        {
            SqlCommand SqlCmd = new SqlCommand("SP_DELETE_INVENT_EQUI", bDD_Conex.Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@IdTipoEquipo", tipoequipos.IdTipoEquipo);

            SqlCmd.ExecuteNonQuery();
            bDD_Conex.cerrarConexion();
        }

        /**
         *
         * Update de las tablas INVENT.. y INVENT_EQUI..
         *
         */

        public void Update_INVENT(InventarioEquiposCliente inventarioEquiposCliente)
        {
            SqlCommand SqlCmd = new SqlCommand("SP_UPDATE_INVENT", bDD_Conex.Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@IdInventario", inventarioEquiposCliente.IdInventario);
            SqlCmd.Parameters.AddWithValue("@NumeroSerieInventarioEquipo", inventarioEquiposCliente.NumeroSerieInventarioEquipo);
            SqlCmd.Parameters.AddWithValue("@MarcaInventarioEquipo", inventarioEquiposCliente.MarcaInventarioEquipo);
            SqlCmd.Parameters.AddWithValue("@ModeloInventarioEquipo ", inventarioEquiposCliente.ModeloInventarioEquipo);
            SqlCmd.Parameters.AddWithValue("@IdTipoInventarioEquipo", inventarioEquiposCliente.IdTipoInventarioEquipo);
            SqlCmd.Parameters.AddWithValue("@FchaAltaInventarioEquipo", inventarioEquiposCliente.FchaAltaInventarioEquipo);
            SqlCmd.Parameters.AddWithValue("@FchaBajaInventarioEquipo", inventarioEquiposCliente.FchaBajaInventarioEquipo);
            SqlCmd.Parameters.AddWithValue("@IdCliente", inventarioEquiposCliente.IdCliente);

            SqlCmd.ExecuteNonQuery();
            bDD_Conex.cerrarConexion();
        }

        /**
         *
         *
         *
         * update de la tablatipoequipo
         *
         *
         */

        public void Update_INVENT_EQUI(Tipoequipos tipoequipos)
        {
            SqlCommand SqlCmd = new SqlCommand("SP_UPDATE_INVENT_EQUI", bDD_Conex.Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@IdTipoEquipo", tipoequipos.IdTipoEquipo);
            SqlCmd.Parameters.AddWithValue("@NombreTipoEquipo", tipoequipos.NombreTipoEquipo);
            SqlCmd.ExecuteNonQuery();
            bDD_Conex.cerrarConexion();
        }
    }
}
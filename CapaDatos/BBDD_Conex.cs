// *****************************************************************************************************
// INFORMACION:
//
// EQUIPO DE DESARROLLO:  Equipo 1
// COMPONENTES DEL EQUIPO: Hector R., Nadia, Ruben, Pablo
// FECHA: 25.01.2022
// *****************************************************************************************************





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;

namespace GestInfo.CapaDatos
{
    class BBDD_Conex
    {
        private SqlConnection conexion;

        public BBDD_Conex()
        {
            conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx_Gestinfo"].ConnectionString);

           

        }

        //Metodo privado para devolver la conexion , validando que este abierta la conexion
        //y abriendola en caso de que este cerrada.
        private SqlConnection Retornar_Conexion()
        {
            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();//Abrir conexion
            }

            return conexion;
        }

        //Cerrar la conexion.
        public void cerrarConexion()
        {
            if (conexion.State != System.Data.ConnectionState.Closed)
            {
                conexion.Close();//Abrir conexion
            }

        }

        //Metodos Getter y Setter , metodo Retornar_Conexion se usa ya que la
        //encapsulacion (get) no me permite condicionales (IF).
        public SqlConnection Conexion { get => Retornar_Conexion(); }
    }
}

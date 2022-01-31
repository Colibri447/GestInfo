using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


using GestInfo.CapaEntidades;
// *****************************************************************************************************
// INFORMACION:
//
// EQUIPO DE DESARROLLO:  Equipo 1
// COMPONENTES DEL EQUIPO: Hector R., Nadia, Ruben, Pablo
// FECHA: 25.01.2022
// *****************************************************************************************************

namespace GestInfo.CapaDatos
{
    public class CD_Clientes
    {
        private BBDD_Conex conexion;
        public string Mensaje; //Para alertas de fallos en otras capas.

        public CD_Clientes()
        {
            this.conexion = new BBDD_Conex();
            this.Mensaje = "";
        }

       
        
        public Cliente insertarClientes(Cliente cl_in)
        {
            Cliente cl_out = null; 
            //Nombre del procedimiento y conexion a la Base de Datos
            SqlCommand cmd = new SqlCommand("SP_INSERT_CLIENTE", conexion.Conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NombreCliente", cl_in.NombreCliente);
            cmd.Parameters.AddWithValue("@DireccionCliente", cl_in.DireccionCliente);
            

           if( cmd.ExecuteNonQuery() > 0)
           {
                cl_out   =   cl_in;
           }

            conexion.cerrarConexion();
            //Retornamos el objeto cliente
            return cl_out;
        }


        //Da de baja el cliente pasado por parametro.Retorna un cliente Null si no se ha podido dar de baja.
        public Cliente bajaCliente(Cliente cl_in)
        {

            Cliente cl_out = null;//Como indicador bool

            Mensaje = "";

            try
            {

                //Nombre procedimiento y la conexion a la BDD.
                SqlCommand cmd = new SqlCommand("SP_BAJA_CLIENTE", conexion.Conexion);

                //Indicar que se va a utilizar un procedimiento
                //almacenado en la base de datos
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@IdCliente", cl_in);

                //Comprobacion si se ha realizado la baja , (0) si no se ha dado de baja al cliente.
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cl_out = cl_in;
                }


               
            }
            catch (SqlException ex_sql)//Excepciones SQL
            {
                Mensaje = ex_sql.Message;
            }
            catch (Exception ex) //Excepciones generales(Globales).
            {
                Mensaje = ex.Message;
            }
            finally
            {
                //Finally siempre se ejecuta , dando igual si hay excepcion o no.

                //Cerrar conexion BDD.
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }

            }

            return cl_out;


        }

        public List<Cliente> recuperarClientes()
         {

            List<Cliente> lista = null;

            try
            {
                //Nombre procedimiento y la conexion a la BDD.
                SqlCommand cmd = new SqlCommand("SP_TODOS_CLIENTES", conexion.Conexion)
            {
               //Indicar que se va a utilizar un procedimiento almacenado en la base de datos
              CommandType = CommandType.StoredProcedure
            };

            SqlDataReader rd = cmd.ExecuteReader();
             
                if(rd.HasRows)
                {
                    lista = new List<Cliente>();

                    while (rd.Read())
                    {
                        Cliente cliente = new Cliente();

                        cliente.IdCliente =(int) rd["idCliente"];
                        cliente.NombreCliente= (string)rd["NombreCliente"];
                        cliente.FechaAltaCliente = (DateTime)rd["FchaAltaCliente"];
                        cliente.FechaBajaCliente = ((rd["FchaBajaCliente"] == System.DBNull.Value) ? new DateTime() :(DateTime) rd["FchBajaCliente"]);
                        cliente.DireccionCliente = (string)rd["DireccionCliente"];

                        lista.Add(cliente);
                    }
                }
             
            }
            catch (SqlException ex_sql)
            {
                Mensaje = ex_sql.Message; //Mensaje de error cuando hay un fallos en el sql   
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message; //Mensaje de error cuando da error en la aplicacion en general
            }
            finally
            {
                //Finally siempre se ejecuta , dando igual si hay excepcion o no.
                //Cerrar conexion BDD.
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }

            }
            return lista;
        }
 
        public Cliente editarCliente(Cliente cl_in)
        {
            Cliente cl_out = null;//Como indicador bool
            Mensaje = "";
            try
            {
                //Nombre procedimiento y la conexion a la BDD.
                SqlCommand cmd = new SqlCommand("SP_UPDATE_CLIENTE", conexion.Conexion)
                {
                    //Indicar que se va a utilizar un procedimiento almacenado en la base de datos
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@IdCliente", cl_in.IdCliente);
                cmd.Parameters.AddWithValue("@FchaAltaCliente", cl_in.FechaAltaCliente );
                cmd.Parameters.AddWithValue("@NombreCliente", cl_in.NombreCliente );
                cmd.Parameters.AddWithValue("@DireccionCliente", cl_in.DireccionCliente );

                //Comprobacion si se ha realizado la modificacion , (0) si no se ha dado de baja al cliente.
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cl_out = cl_in;               
                }

            }
            catch (SqlException ex_sql)
            {
                Mensaje = ex_sql.Message; //Mensaje de error cuando hay un fallos en el sql   
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message; //Mensaje de error cuando da error en la aplicacion en general
            }
            finally
            {
                //Finally siempre se ejecuta , dando igual si hay excepcion o no.
                //Cerrar conexion BDD.
                if(conexion != null)
                {
                    conexion.cerrarConexion();
                }
                
            }

            return cl_out;
        }

        public Cliente obtenerCliente(Cliente cl_in)
        {

            Cliente cl_out = null;//Como indicador bool

            Mensaje = "";

            try
            {

                //Nombre procedimiento y la conexion a la BDD.
                SqlCommand cmd = new SqlCommand("SP_SELECT_CLIENTE", conexion.Conexion);

                //Indicar que se va a utilizar un procedimiento
                //almacenado en la base de datos
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@IdCliente", cl_in.IdCliente);

                //Comprobacion si se ha realizado la baja , (0) si no se ha dado de baja al cliente.
                //RECUPERO DATOS DE LA CONSULTA
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cl_out = new Cliente();

                    cl_out.IdCliente = (int)rd["idCliente"];
                    cl_out.NombreCliente = (string)rd["NombreCliente"];
                    cl_out.FechaAltaCliente = (DateTime)rd["FchaAltaCliente"];
                    cl_out.FechaBajaCliente = ((rd["FchaBajaCliente"] == System.DBNull.Value) ? new DateTime() : (DateTime)rd["FchBajaCliente"]);
                    cl_out.DireccionCliente = (string)rd["DireccionCliente"];
                }
            }
            catch (SqlException ex_sql)//Excepciones SQL
            {
                Mensaje = ex_sql.Message;
            }
            catch (Exception ex) //Excepciones generales(Globales).
            {
                Mensaje = ex.Message;
            }
            finally
            {
                //Finally siempre se ejecuta , dando igual si hay excepcion o no

                //Cerrar conexion BDD.
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }

            }
            return cl_out;
        }

    }
}

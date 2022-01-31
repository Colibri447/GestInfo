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
    public class CD_Empleados
    {
        private BBDD_Conex conexion;
        public string Mensaje; //Para alertas de fallos en otras capas.

        public CD_Empleados()
        {
            this.conexion = new BBDD_Conex();
            this.Mensaje = "";
        }

        //Insertar empleado
        public Empleado insertarEmpleado(Empleado emp_in)
        {
            Empleado emp_out = null;
            Mensaje = "";

            try
            {
                //Nombre del procedimiento y conexion a la Base de Datos
                SqlCommand cmd = new SqlCommand("SP_INSERT_EMPLEADO", conexion.Conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", emp_in.NombreEmpleado);
                cmd.Parameters.AddWithValue("@apellido", emp_in.ApellidoEmpleado);
                cmd.Parameters.AddWithValue("@idCategoria", emp_in.IdCategoria);
                cmd.Parameters.AddWithValue("@usuario", emp_in.UsuarioEmpleado);
                cmd.Parameters.AddWithValue("@pass", emp_in.PasswordEmpleado);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    emp_out = emp_in;
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
            //Retornamos el objeto empleado
            return emp_out;

        }


        //Editar empleado pasado por parámetros , retornara empleado null si ha habido un fallo a la hora
        //de modificar el empleado.

        //nadia
        public Empleado editarEmpleado(Empleado emp_in)
        {
            Empleado emp_out = null;

            Mensaje = "";
            try
            {
                //Nombre procedimiento y la conexion a la BDD.
                SqlCommand cmd = new SqlCommand("SP_UPDATE_EMPLEADO", conexion.Conexion)
                {
                    //Indicar que se va a utilizar un procedimiento almacenado en la base de datos
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@idEmpleado", emp_in.IdEmpleado);
                cmd.Parameters.AddWithValue("@nombreEmpleado", emp_in.NombreEmpleado);
                cmd.Parameters.AddWithValue("@apellidoEmpleado", emp_in.ApellidoEmpleado);
                cmd.Parameters.AddWithValue("@idCategoria", emp_in.IdCategoria);
                cmd.Parameters.AddWithValue("@fchaAltaEmpleado", emp_in.FchaAltaEmpleado);
                cmd.Parameters.AddWithValue("@fchaBajaEmpleado", emp_in.FchaBajaEmpleado);
                cmd.Parameters.AddWithValue("@usuarioEmpleado", emp_in.UsuarioEmpleado);
                cmd.Parameters.AddWithValue("@passwordEmpleado", emp_in.PasswordEmpleado);

                //Comprobacion si se ha realizado la modificacion , (0) si no se ha dado de baja al EMPLEADO.
                if (cmd.ExecuteNonQuery() > 0)
                {
                    emp_out = emp_in;
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
            return emp_out;
        }

        //Obtener todas las categorias de BDD.  (HectorR)
        public List<CategoriaEmpleado> todasCategoriasEmpleados()
        {
            List<CategoriaEmpleado> lista = null;

            try
            {
                //Nombre procedimiento y la conexion a la BDD.
                SqlCommand cmd = new SqlCommand("SP_SELECT_TODAS_CATEGORIASEMPLEADOS", conexion.Conexion)
                {
                    //Indicar que se va a utilizar un procedimiento almacenado en la base de datos
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    lista = new List<CategoriaEmpleado>();

                    while (rd.Read())
                    {
                        CategoriaEmpleado cte = new CategoriaEmpleado();

                        cte.IdCategoria = (int)rd["idCategoria"];
                        cte.NombreCategoria = (string)rd["nombreCategoria"];

                        lista.Add(cte);
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

        //Baja empleado
        public Empleado bajaEmpleado(Empleado emp_in)
        {
            Empleado emp_out = null;
            Mensaje = "";

            try
            {
                //Nombre del procedimiento y conexion a la Base de Datos
                SqlCommand cmd = new SqlCommand("SP_BAJA_EMPLEADO", conexion.Conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", emp_in.IdEmpleado);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    emp_out = emp_in;
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
            //Retornamos el objeto empleado
            return emp_out;
        }

        //Obtener empleado
        public Empleado obtenerEmpleado(Empleado emp_in)
        {
            Empleado emp_out = null;
            Mensaje = "";

            try
            {
                //Nombre procedimiento y la conexion a la BDD.
                SqlCommand cmd = new SqlCommand("SP_SELECT_EMPLEADO_POR_ID", conexion.Conexion);

                //Indicar que se va a utilizar un procedimiento
                //almacenado en la base de datos
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idEmpleado", emp_in.IdEmpleado);

                //Comprobacion si se ha realizado la baja , (0) si no se ha dado de baja al cliente.
                //RECUPERO DATOS DE LA CONSULTA
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    emp_out = new Empleado();

                    emp_out.IdEmpleado = (int)rd["idEmpleado"];
                    emp_out.NombreEmpleado = (string)rd["nombreEmpleado"];
                    emp_out.ApellidoEmpleado = (string)rd["apellidoEmpleado"];
                    emp_out.IdCategoria = (int)rd["idCategoria"];
                    emp_out.FchaAltaEmpleado = (DateTime)rd["fchaAltaEmpleado"];
                    emp_out.FchaBajaEmpleado = ((rd["fchaBajaEmpleado"] == System.DBNull.Value) ? new DateTime() : (DateTime)rd["fchBajaEmpleado"]);
                    emp_out.PasswordEmpleado = (string)rd["passwordEmpleado"];
                }
            }
            catch (SqlException ex_sql)//Excepciones SQL
            {
                Mensaje = ex_sql.Message;
            }
            catch (Exception ex)//Excepciones generales
            {
                Mensaje = ex.Message;
            }
            finally
            {
                //Finally siempre se ejecuta , dando igual si hay excepcion o no

                //Cerrar conexion BDD.
                if(conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
            return emp_out;
        }
        
        //Recuperar empleados
        public List<Empleado> recuperarEmpleados()
        {
            List<Empleado> lista = null;
            try
            {
                SqlCommand cmd = new SqlCommand("SP_SELECT_EMPLEADOS", conexion.Conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    lista = new List<Empleado>();
                    while (rd.Read())
                    {
                        Empleado empleado = new Empleado();
                        empleado.IdEmpleado = (int)rd["idEmpleado"]; 
                        empleado.NombreEmpleado = (string)rd["nombreEmpleado"]; 
                        empleado.ApellidoEmpleado = (string)rd["apellidoEmpleado"]; 
                        empleado.IdCategoria = (int)rd["idCategoria"]; 
                        empleado.FchaAltaEmpleado = (DateTime)rd["fchaAltaEmpleado"]; 
                        empleado.FchaBajaEmpleado = ((rd["fchaBajaEmpleado"] == System.DBNull.Value) ? new DateTime(): (DateTime) rd["FchBajaCliente"]); 
                        empleado.UsuarioEmpleado = (string)rd["usuarioEmpleado"]; 
                        empleado.PasswordEmpleado = (string)rd["passwordEmpleado"];
                        
                        lista.Add(empleado);
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
    }
}


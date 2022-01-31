using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestInfo.CapaDatos;
using GestInfo.CapaEntidades;
using System.Windows.Forms;

using System.Data;
using System.Collections;
// *****************************************************************************************************
// INFORMACION:
//
// EQUIPO DE DESARROLLO:  Equipo 1
// COMPONENTES DEL EQUIPO: Hector R., Nadia, Ruben, Pablo
// FECHA: 25.01.2022
// *****************************************************************************************************
namespace GestInfo.CapaNegocio
{
    public class CN_Clientes
    {
        private CD_Clientes datCliente;
        public string Mensaje;

        public CN_Clientes()
        {
            this.datCliente = new CD_Clientes();
            this.Mensaje = "";
        }

        //Cargamos combobox pasado por parametro con clientes
        public void loadClientesCMB(ComboBox cmb)
        {

            List<Cliente> lista = datCliente.recuperarClientes();

            if (lista != null && lista.Count > 0)
            {

                //Para limpiar combobox
                if (cmb.DataSource != null)
                {
                    cmb.DataSource = null;
                    cmb.Items.Clear();
                }

                //Key-Value
                Dictionary<int, string> dic = new Dictionary<int, string>();

                foreach (Cliente cl in lista)
                {
                    dic.Add(cl.IdCliente, cl.NombreCliente);
                }

                cmb.DataSource = new BindingSource(dic, null);
                cmb.ValueMember = "Key";
                cmb.DisplayMember = "Value";

            }

        }

        //Alta de cliente pasado por parámetros
        public void insertarClientes(Cliente cl_in)
        {
            Cliente cl_out = null;

            //Comprobamos si el cliente tiene datos
            if (cl_in != null)
            {
                //Realizamos la operación de alta de cliente
                cl_out = datCliente.insertarClientes(cl_in);

                //Comprobamos si se ha realizado la operación
                if (cl_out != null)
                {
                    Mensaje = "Se ha dado de alta correctamente al cliente :  " + cl_out.NombreCliente;
                }
                else
                {
                    //Comprobamos si da un mensaje capa datos
                    if (datCliente.Mensaje.Length != 0)
                    {
                        Mensaje = "Ha habido un error al dar de alta al cliente.";
                    }
                    else
                    {
                        //Mensaje de la capa datos
                        Mensaje = datCliente.Mensaje;
                    }
                }
            }
            else
            {
                Mensaje = "Cliente no valido";
            }
        }

        //Obtener cliente apartir del cliente que recibe por parametro que debera contener el iD
        //y lo retorna con sus datos 
        public Cliente obtenerCliente(Cliente cl_in)
        {
            Cliente cl_out = null;

            if(cl_in != null && cl_in.IdCliente>0)
            {
                cl_out = datCliente.obtenerCliente(cl_in);

                if(cl_out == null)
                {
                    Mensaje = datCliente.Mensaje;
                    if (datCliente.Mensaje.Length == 0)
                    {
                        Mensaje = "Error";
                    }
                }
            }
            else
            {
                Mensaje = "Cliente no valido.";
            }

            return cl_out;
        }
        //Baja de cliente pasado por parametro.
        public void bajaCliente(Cliente cl)
        {
            Cliente cl_out = null;

            //Comprobamos el cliente tiene datos
            if (cl != null)
            {
                //Realizamos la operacion de baja de cliente
                cl_out = datCliente.bajaCliente(cl);

                //Comprobamos si se ha realizado la operacion.
                if (cl_out != null)
                {
                    Mensaje = "Se ha dado de baja correctamente al cliente :  " + cl_out.NombreCliente;
                }
                else
                {
                    //Comprobamos si da un mensaje capa datos
                    if (datCliente.Mensaje.Length != 0)
                    {
                        Mensaje = "Ha habido un error al dar de baja al cliente.";
                    }
                    else
                    {
                        //Mensaje de la capa datos
                        Mensaje = datCliente.Mensaje;
                    }
                }
            }
            else
            {
                Mensaje = "Cliente no valido";
            }

        }

        //Editar clientes pasados por parametros
        public void editarCliente(Cliente cl)
        {
            Cliente cl_out = null;

            //Comprobamos que el cliente tiene datos
            if (cl != null)
            {
                //Realizamos la operacion de modificacion del cliente
                cl_out = datCliente.editarCliente(cl);


                //Comprobamos si se ha realizado la operacion
                if (cl_out != null)
                {
                    Mensaje = "El cliente se ha editado correctamente";
                }
                else
                {
                    //Comprobamos si da un mensaje capa datos
                    if (datCliente.Mensaje.Length != 0)
                    {
                        Mensaje = "Ha habido un error al editar al cliente";
                    }
                    else
                    {
                        // Mensaje de la capa datos
                        Mensaje = datCliente.Mensaje;
                    }
                }
            }
        }
    }
}

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
    public class CN_Empleados
    {
        private CD_Empleados datEmpleado;
        public string Mensaje;

        public CN_Empleados()
        {
            this.datEmpleado = new CD_Empleados();
            this.Mensaje = "";
        }

        //Alta de empleado pasado por parámetros
        public void insertarEmpleado(Empleado emp_in)
        {
            Empleado emp_out = null;

            //Comprobamos si el empleado tiene datos
            if (emp_in != null)
            {
                //Realizamos la operación de alta de empleado
                emp_out = datEmpleado.insertarEmpleado(emp_in);

                //Comprobamos si se ha realizado la operación
                if (emp_out != null)
                {
                    Mensaje = "Se ha dado de alta correctamente al empleado :  " + emp_out.NombreEmpleado;
                }
                else
                {
                    //Comprobamos si da un mensaje capa datos
                    if (datEmpleado.Mensaje.Length != 0)
                    {
                        Mensaje = "Ha habido un error al dar de alta al empleado.";
                    }
                    else
                    {
                        //Mensaje de la capa datos
                        Mensaje = datEmpleado.Mensaje;
                    }
                }
            }
            else
            {
                Mensaje = "Empleado no valido";
            }
        }
        
        //Baja de empleado pasado por parámetros
        public void bajaEmpleado(Empleado emp_in)
        {
            Empleado emp_out = null;

            //Comprobamos si el empleado tiene datos
            if (emp_in != null)
            {
                //Realizamos la operación de baja de empleado
                emp_out = datEmpleado.bajaEmpleado(emp_in);

                //Comprobamos si se ha realizado la operación
                if (emp_out != null)
                {
                    Mensaje = "Se ha dado de baja correctamente al empleado :  " + emp_out.NombreEmpleado;
                }
                else
                {
                    //Comprobamos si da un mensaje capa datos
                    if (datEmpleado.Mensaje.Length != 0)
                    {
                        Mensaje = "Ha habido un error al dar de baja al empleado.";
                    }
                    else
                    {
                        //Mensaje de la capa datos
                        Mensaje = datEmpleado.Mensaje;
                    }
                }
            }
            else
            {
                Mensaje = "Empleado no valido";
            }
        }

        //Editar empleado pasado por parámetros
        public void editarEmpleado(Empleado emp_in)
        {
            Empleado emp_out = null;

            //Comprobamos si el empleado tiene datos
            if (emp_in != null)
            {
                //Realizamos la operación de baja de empleado
                emp_out = datEmpleado.editarEmpleado(emp_in);

                //Comprobamos si se ha realizado la operación
                if (emp_out != null)
                {
                    Mensaje = "El empleado se ha editado correctamente";
                }
                else
                {
                    //Comprobamos si da un mensaje capa datos
                    if (datEmpleado.Mensaje.Length != 0)
                    {
                        Mensaje = "Ha habido un error al editar al empleado.";
                    }
                    else
                    {
                        //Mensaje de la capa datos
                        Mensaje = datEmpleado.Mensaje;
                    }
                }
            }
            else
            {
                Mensaje = "Empleado no valido";
            }
        }

        // no se del todo como hacerlo voy a probar

        //nadia
        public void obtenerEmpleado(Empleado emp_in)
        {
            Empleado emp_out = null;

            if (emp_in != null && emp_in.IdEmpleado > 0)
            {
                emp_out = datEmpleado.obtenerEmpleado(emp_in);

                if (emp_out == null)
                {
                    Mensaje = datEmpleado.Mensaje;
                    if ( datEmpleado.Mensaje.Length == 0)
                    {
                        Mensaje = "Error";
                    }
                }
            }
            else
            {
                Mensaje = "Empleado no valido.";
            }

        }

        //Carga de empleados en combobox -- Pablo
        public void loadEmpleadosCMB(ComboBox cmb)
        {
            List<Empleado> lista = datEmpleado.recuperarEmpleados();

            if(lista != null && lista.Count > 0)
            {
                //Para limpiar ComboBox
                if(cmb.DataSource != null)
                {
                    cmb.DataSource = null;
                    cmb.Items.Clear(); 
                }

                //Key-Value
                Dictionary<int, string> dic = new Dictionary<int, string>();
                foreach (Empleado emp in lista) 
                {
                    dic.Add(emp.IdEmpleado, emp.IdEmpleado+ " / "  + emp.ApellidoEmpleado + " " + emp.NombreEmpleado);
                }
                cmb.DataSource = new BindingSource(dic, null);
                cmb.ValueMember = "Key";
                cmb.DisplayMember = "Value";
            } 
        }


        public void loadCategoriasCMB(ComboBox cmb)
        {
            List<CategoriaEmpleado> lista = datEmpleado.todasCategoriasEmpleados();

            if (lista != null && lista.Count > 0)
            {
                //Para limpiar ComboBox
                if (cmb.DataSource != null)
                {
                    cmb.DataSource = null;
                    cmb.Items.Clear();
                }

                //Key-Value
                Dictionary<int, string> dic = new Dictionary<int, string>();
                foreach (CategoriaEmpleado cte in lista)
                {
                    dic.Add(cte.IdCategoria,  cte.NombreCategoria);
                }
                cmb.DataSource = new BindingSource(dic, null);
                cmb.ValueMember = "Key";
                cmb.DisplayMember = "Value";
            }
        }

    }
}

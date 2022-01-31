// *****************************************************************************************************
// INFORMACION:
//
// EQUIPO DE DESARROLLO:  Equipo 2
// COMPONENTES DEL EQUIPO: Pedro, David, Alex, Irene
// FECHA: 26.01.2022
// *****************************************************************************************************


using GestInfo.CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestInfo.CapaPresentacion
{
    public partial class pInventarioEquipoCliente : Form
    {
        private readonly nINVENTARIOEQUIPOSCLIENTE objetonegocioinventario = new nINVENTARIOEQUIPOSCLIENTE();
        private readonly nTIPOEQUIPOS objetonegociotipoequipo = new nTIPOEQUIPOS();
        private readonly CN_Clientes objetoNegocioClientes = new CN_Clientes();

        public pInventarioEquipoCliente()
        {
            InitializeComponent();
        }

        //metodo para inicializar los combobox y textbox al abrir el programa(se usara en el load)
        private void Refrescar()
        {
            // Cargamos el cmb 'cmb_idInventario' con las columna 'IdInventario' de la tabla INVENTARIOEQUIPOSCLIENTES
            cmb_idInventario.DataSource = objetonegocioinventario.SelectTablaInventario();
            cmb_idInventario.DisplayMember = "IdInventario";
            cmb_idInventario.ValueMember = "IdInventario";
            // *+* Le indicamos que selecione un item null y le decimos que nos lo selecciones y que le establecimeos el string '--select--'
            cmb_idInventario.SelectedItem = null;
            cmb_idInventario.SelectedText = "--select--";

            objetoNegocioClientes.loadClientesCMB(cmb_cliente);
            // *+*
            cmb_cliente.SelectedItem = null;
            cmb_cliente.SelectedText = "--select--";

            cmb_tipo_equipo.DataSource = objetonegociotipoequipo.Select_INVENT_EQUI();
            cmb_tipo_equipo.DisplayMember = "NombreTipoEquipo";
            cmb_tipo_equipo.ValueMember = "IdTipoEquipo";
            // *+*
            cmb_tipo_equipo.SelectedItem = null;
            cmb_tipo_equipo.SelectedText = "--select--";

            // Decimos que los txt 'txt_num_serie','txt_marca_equipo','txt_modelo_equipo' contengan un string vacio
            txt_num_serie.Text = "";
            txt_marca_equipo.Text = "";
            txt_modelo_equipo.Text = "";
        }

        //llenamos los combobox en el evento load llamando a los metodos de la capa de negocio
        private void pInventarioEquipoCliente_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        //boton para dar de alta con validaciones
        private void btn_Alta_Click(object sender, EventArgs e)
        {
            //Si ciertos campos estan vacios saltará un mensaje de aviso
            if (cmb_idInventario.Text == "--select--" || cmb_cliente.Text == "--select--" || cmb_tipo_equipo.Text == "--select--" || txt_num_serie.Text == "" || txt_marca_equipo.Text == "" || txt_modelo_equipo.Text == "")
            {
                MessageBox.Show("Por favor, rellene los campos vacíos antes de dar de Alta.");
                Refrescar();
            }
            else
            {
                //Ejecutamos el método INSERT de la capa negocio
                objetonegocioinventario.Insert_INVENT(txt_num_serie.Text, txt_marca_equipo.Text, txt_modelo_equipo.Text, (int)cmb_tipo_equipo.SelectedValue, dateTime_alta.Value, dateTime_baja.Value, (int)cmb_cliente.SelectedValue);
                MessageBox.Show("Equipo guardado");
                Refrescar();
            }
        }

        //boton para dar de baja
        private void btn_Baja_Click(object sender, EventArgs e)
        {
            //Si ciertos campos estan vacios saltará un mensaje de aviso
            if (cmb_idInventario.Text == "--select--")
            {
                MessageBox.Show("Por favor, rellene los campos vacíos antes de dar de Baja.");
                Refrescar();
            }
            else
            {
                //Ejecutamos el método DELETE de la capa negocio
                objetonegocioinventario.Delete_INVENT((int)cmb_idInventario.SelectedValue);
                MessageBox.Show("Equipo eliminado");
                Refrescar();
            }
        }

        //boton para modificar
        private void btn_Modif_Click(object sender, EventArgs e)
        {
            //Si ciertos campos estan vacios saltará un mensaje de aviso
            if (cmb_idInventario.Text == "--select--" || cmb_cliente.Text == "--select--" || cmb_tipo_equipo.Text == "--select--" || txt_num_serie.Text == "" || txt_marca_equipo.Text == "" || txt_modelo_equipo.Text == "")
            {
                MessageBox.Show("Por favor, rellene los campos vacíos antes de Modificar.");
                Refrescar();
            }
            else
            {
                //Ejecutamos el método UPDATE de la capa negocio
                objetonegocioinventario.Update_INVENT((int)cmb_idInventario.SelectedValue, txt_num_serie.Text, txt_marca_equipo.Text, txt_modelo_equipo.Text, (int)cmb_tipo_equipo.SelectedValue, dateTime_alta.Value, dateTime_baja.Value, (int)cmb_cliente.SelectedValue);
                MessageBox.Show("Equipo modificado");
                Refrescar();
            }
        }

        //boton para salir
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //evento que rellena los combobox cuando cambien el combobox de idinventario
        private void cmb_idInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_idInventario.SelectedValue is int)
            {
                DataTable dt = objetonegocioinventario.Select_INVENT_ID((int)cmb_idInventario.SelectedValue); // Creamos un objeto datatable llamado 'dt', la cual cargamos el select where id de inventario sea igual a la id selecionada en el combobox
                // De la tabla dt vamos cogiendo los datos y vamos rellenado los txt y los cmb
                txt_num_serie.Text = dt.Rows[0][1].ToString(); // ** Indicamos que coga de la dt la primera fila [0] y la segunda columna [1], y lo convertimos en un string para cargarlo en el txt
                txt_marca_equipo.Text = dt.Rows[0][2].ToString();// **
                txt_modelo_equipo.Text = dt.Rows[0][3].ToString();// **
                cmb_tipo_equipo.SelectedValue = (int)dt.Rows[0][4];// *** en este caso decimos que tiene que seleccionar el item del combobox con el valor que corresponda al que le damos
                dateTime_alta.Value = Convert.ToDateTime(dt.Rows[0][5].ToString());// **** en este caso la celda la convertimos en DateTime para cargarlo a un datetimepicker
                if (dt.Rows[0][6] == DBNull.Value) // Si el valor de la columna fecha baja es null, el dateTime_baja aparece vacio
                {
                    // Creamos un formato para datetimepicker 'dateTime_baja' que sea un string vacio
                    dateTime_baja.Format = DateTimePickerFormat.Custom;
                    dateTime_baja.CustomFormat = " ";
                }
                else // Si no es null, se establece el mismo formato que dateTime_alta y le damos el valor de la tabla
                {
                    dateTime_baja.Format = dateTime_alta.Format;
                    dateTime_baja.Value = Convert.ToDateTime(dt.Rows[0][6].ToString());// ****
                }
                cmb_cliente.SelectedValue = (int)dt.Rows[0][7];// ***
            }
        }
    }
}
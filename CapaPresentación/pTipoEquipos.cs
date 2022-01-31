// *****************************************************************************************************
// INFORMACION:
//
// EQUIPO DE DESARROLLO:  Equipo 2
// COMPONENTES DEL EQUIPO: Pedro, David, Alex, Irene
// FECHA: 26.01.2022
// *****************************************************************************************************


using GestInfo.CapaNegocio;
using System;
using System.Windows.Forms;

namespace GestInfo.CapaPresentacion
{
    public partial class pTipoEquipos : Form
    {
        private readonly nTIPOEQUIPOS objetonegociotipoequipo = new nTIPOEQUIPOS();

        public pTipoEquipos()
        {
            InitializeComponent();
        }

        //Método para inicializar y dar valores a los combos y textbox
        private void Refrescar()
        {
            cmb_idtipoEquipo.DataSource = objetonegociotipoequipo.Select_INVENT_EQUI();
            cmb_idtipoEquipo.DisplayMember = "IdTipoEquipo";
            cmb_idtipoEquipo.ValueMember = "NombreTipoEquipo";
            cmb_idtipoEquipo.SelectedItem = null;
            cmb_idtipoEquipo.SelectedText = "--select--";

            txt_nom_tip_equi.Text = "";
        }

        private void pTipoEquipos_Load(object sender, EventArgs e)
        {
            //Cargamos el método inicializador
            Refrescar();
        }

        //Boton Alta TIPOEQUIPOS
        private void btn_Alta_Click(object sender, EventArgs e)
        {
            //Si ciertos campos estan vacios saltará un mensaje de aviso
            if (cmb_idtipoEquipo.Text == "--select--" || txt_nom_tip_equi.Text == "")
            {
                MessageBox.Show("Por favor, rellene los campos vacíos antes de dar de Alta.");
                Refrescar();
            }
            else
            {
                //Ejecutamos el método INSERT de la capa negocio
                objetonegociotipoequipo.Insert_INVENT_EQUI(txt_nom_tip_equi.Text);
                MessageBox.Show("Tipo equipo guardado");
                Refrescar();
            }
        }

        //Boton Baja TIPOEQUIPOS
        private void btn_Baja_Click(object sender, EventArgs e)
        {
            //Si ciertos campos estan vacios saltará un mensaje de aviso
            if (cmb_idtipoEquipo.Text == "--select--")
            {
                MessageBox.Show("Por favor, rellene los campos vacíos antes de dar de Baja.");
                Refrescar();
            }
            else
            {
                //Ejecutamos el método DELETE de la capa negocio
                objetonegociotipoequipo.Delete_INVENT_EQUI((int)cmb_idtipoEquipo.SelectedValue, txt_nom_tip_equi.Text);
                MessageBox.Show("Tipo equipo eliminado");
                Refrescar();
            }
        }

        //Boton Modificar TIPOEQUIPOS
        private void btn_Modif_Click(object sender, EventArgs e)
        {
            //Si ciertos campos estan vacios saltará un mensaje de aviso
            if (cmb_idtipoEquipo.Text == "--select--" || txt_nom_tip_equi.Text == "")
            {
                MessageBox.Show("Por favor, rellene los campos vacíos antes de Modificar.");
                Refrescar();
            }
            else
            {
                //Ejecutamos el método UPDATE de la capa negocio
                objetonegociotipoequipo.Update_INVENT_EQUI((int)cmb_idtipoEquipo.SelectedValue, txt_nom_tip_equi.Text);
                MessageBox.Show("Tipo equipo modificado");
                Refrescar();
            }
        }
        // Evento de click para el boton 'btn_Salir' el cual cierra el formulario.
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_idtipoEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_idtipoEquipo.SelectedValue is string) // Comprueba que SelectedValue cmb_idtipoEquipo sea string
            {
                txt_nom_tip_equi.Text = cmb_idtipoEquipo.SelectedValue.ToString(); 
            }
        }
    }
}
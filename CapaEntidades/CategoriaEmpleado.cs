// *****************************************************************************************************
// INFORMACION:
//
// EQUIPO DE DESARROLLO:  Equipo 3
// COMPONENTES DEL EQUIPO: Javi, Belen, Gonzalo, Hector
// FECHA: 24.01.2022
// *****************************************************************************************************


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestInfo.CapaEntidades
{
    class CategoriaEmpleado
    {
        private int idCategoria; //ID categoria
        private string nombreCategoria; //Nombre de la categoria


        //Constructor vacio
        public CategoriaEmpleado()
        {

        }

        //Constructor con parametros
        public CategoriaEmpleado(int idCategoria, string nombreCategoria)
        {
            this.idCategoria = idCategoria;
            this.nombreCategoria = nombreCategoria;
        }

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
    }
}

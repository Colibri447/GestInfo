using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestInfo.CapaEntidades
{
    class CategoriasIncidencias
    {
        private int IdCategoriaIncidencia;
        private string NombreCategoriaIncidencia;

        public CategoriasIncidencias(int idCategoriaIncidencia, string nombreCategoriaIncidencia)
        {
            IdCategoriaIncidencia = idCategoriaIncidencia;
            NombreCategoriaIncidencia = nombreCategoriaIncidencia;
        }

        public int IdCategoriaIncidencia1 { get => IdCategoriaIncidencia; set => IdCategoriaIncidencia = value; }
        public string NombreCategoriaIncidencia1 { get => NombreCategoriaIncidencia; set => NombreCategoriaIncidencia = value; }
    }
}

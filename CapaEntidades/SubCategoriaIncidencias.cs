using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestInfo.CapaEntidades
{
    class SubCategoriaIncidencias
    {
        private int IdSubCategoriaIncidencia;
        private int IdCategoriaIncidencia_SubCatInc; 
        private string NombreSubCategoriaIncidencia;

        public SubCategoriaIncidencias() { }

        public SubCategoriaIncidencias(int idSubCategoriaIncidencia, int idCategoriaIncidencia_SubCatInc, string nombreSubCategoriaIncidencia)
        {
            IdSubCategoriaIncidencia1 = idSubCategoriaIncidencia;
            IdCategoriaIncidencia_SubCatInc = idCategoriaIncidencia_SubCatInc;
            NombreSubCategoriaIncidencia = nombreSubCategoriaIncidencia;
        }

        public int IdSubCategoriaIncidencia1 { get => IdSubCategoriaIncidencia; set => IdSubCategoriaIncidencia = value; }
        public int IdCategoriaIncidencia_SubCatInc1 { get => IdCategoriaIncidencia_SubCatInc; set => IdCategoriaIncidencia_SubCatInc = value; }
        public string NombreSubCategoriaIncidencia1 { get => NombreSubCategoriaIncidencia; set => NombreSubCategoriaIncidencia = value; }
    }
}

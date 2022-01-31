using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestInfo.CapaEntidades
{
    public class Incidencias
    {
        private int IdIncidencia;
        private int IdCliente;
        private int IdEmpleado;
        private DateTime FchaAltaIncidencia;
        private DateTime FchaCierreIncidencia;
        private string DescripcionIncidencia;
        private string SolucionIncidencia;
        private bool EscaladoIncidencia;
        private int IdSubCategoriaIncidencia;

        public Incidencias() { }
        public Incidencias(int idIncidencia, int idCliente, int idEmpleado, DateTime fchaAltaIncidencia, DateTime fchaCierreIncidencia, string descripcionIncidencia, string solucionIncidencia, bool escaladoIncidencia, int idSubCategoriaIncidencia)
        {
            IdIncidencia = idIncidencia;
            IdCliente = idCliente;
            IdEmpleado = idEmpleado;
            FchaAltaIncidencia = fchaAltaIncidencia;
            FchaCierreIncidencia = fchaCierreIncidencia;
            DescripcionIncidencia = descripcionIncidencia;
            SolucionIncidencia = solucionIncidencia;
            EscaladoIncidencia = escaladoIncidencia;
            IdSubCategoriaIncidencia = idSubCategoriaIncidencia;
        }

        public int IdIncidencia1 { get => IdIncidencia; set => IdIncidencia = value; }
        public int IdCliente1 { get => IdCliente; set => IdCliente = value; }
        public int IdEmpleado1 { get => IdEmpleado; set => IdEmpleado = value; }
        public DateTime FchaAltaIncidencia1 { get => FchaAltaIncidencia; set => FchaAltaIncidencia = value; }
        public DateTime FchaCierreIncidencia1 { get => FchaCierreIncidencia; set => FchaCierreIncidencia = value; }
        public string DescripcionIncidencia1 { get => DescripcionIncidencia; set => DescripcionIncidencia = value; }
        public string SolucionIncidencia1 { get => SolucionIncidencia; set => SolucionIncidencia = value; }
        public bool EscaladoIncidencia1 { get => EscaladoIncidencia; set => EscaladoIncidencia = value; }
        public int IdSubCategoriaIncidencia1 { get => IdSubCategoriaIncidencia; set => IdSubCategoriaIncidencia = value; }
    }
}

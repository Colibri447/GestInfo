using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestInfo.CapaEntidades
{
    class EscaladoIncidencias
    {
        private int IdEscaladoIncidencia;
        private int IdIncidencia;
        private int IdEmpleado;
        private DateTime FchaEscaladoIncidencia;
        private DateTime FchaCierreEscalado;
        private string DescripcionTecnicaEscalado;
        private string SolucionEscaladoIncidencia;
        private bool EscaladoEscaladoIncidencia;

        public EscaladoIncidencias() { }

        public EscaladoIncidencias(int idEscaladoIncidencia, int idIncidencia, int idEmpleado, DateTime fchaEscaladoIncidencia, DateTime fchaCierreEscalado, string descripcionTecnicaEscalado, string solucionEscaladoIncidencia, bool escaladoEscaladoIncidencia)
        {
            IdEscaladoIncidencia = idEscaladoIncidencia;
            IdIncidencia = idIncidencia;
            IdEmpleado = idEmpleado;
            FchaEscaladoIncidencia = fchaEscaladoIncidencia;
            FchaCierreEscalado = fchaCierreEscalado;
            DescripcionTecnicaEscalado = descripcionTecnicaEscalado;
            SolucionEscaladoIncidencia = solucionEscaladoIncidencia;
            EscaladoEscaladoIncidencia = escaladoEscaladoIncidencia;
        }

        public int IdEscaladoIncidencia1 { get => IdEscaladoIncidencia; set => IdEscaladoIncidencia = value; }
        public int IdIncidencia1 { get => IdIncidencia; set => IdIncidencia = value; }
        public int IdEmpleado1 { get => IdEmpleado; set => IdEmpleado = value; }
        public DateTime FchaEscaladoIncidencia1 { get => FchaEscaladoIncidencia; set => FchaEscaladoIncidencia = value; }
        public DateTime FchaCierreEscalado1 { get => FchaCierreEscalado; set => FchaCierreEscalado = value; }
        public string DescripcionTecnicaEscalado1 { get => DescripcionTecnicaEscalado; set => DescripcionTecnicaEscalado = value; }
        public string SolucionEscaladoIncidencia1 { get => SolucionEscaladoIncidencia; set => SolucionEscaladoIncidencia = value; }
        public bool EscaladoEscaladoIncidencia1 { get => EscaladoEscaladoIncidencia; set => EscaladoEscaladoIncidencia = value; }
    }
    
}

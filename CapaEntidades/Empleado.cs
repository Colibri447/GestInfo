using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestInfo.CapaEntidades
{
    class Empleados
    {
        private int idEmpleado; //ID del empleado
        private string nombreEmpleado; // Nombre del empleado
        private string apellidoEmpleado; //Apellido del empleado
        private int idCategoria; //ID categoria
        private DateTime fchaAltaEmpleado; // Fecha alta empleado
        private DateTime fchaBajaEmpleado; //Fecha baja empleado
        private string usuarioEmpleado; //Usuario del emplado
        private string passwordEmpleado; //Contraseña del empleado

        //Constructor vacio
        public Empleados()
        {

        }

        //Constructor con los parametros
        public Empleados(int idEmpleado, string nombreEmpleado, string apellidoEmpleado, int idCategoria, DateTime fchaAltaEmpleado, DateTime fchaBajaEmpleado, string usuarioEmpleado, string passwordEmpleado)
        {
            this.idEmpleado = idEmpleado;
            this.nombreEmpleado = nombreEmpleado;
            this.apellidoEmpleado = apellidoEmpleado;
            this.idCategoria = idCategoria;
            this.fchaAltaEmpleado = fchaAltaEmpleado;
            this.fchaBajaEmpleado = fchaBajaEmpleado;
            this.usuarioEmpleado = usuarioEmpleado;
            this.passwordEmpleado = passwordEmpleado;
        }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public string ApellidoEmpleado { get => apellidoEmpleado; set => apellidoEmpleado = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public DateTime FchaAltaEmpleado { get => fchaAltaEmpleado; set => fchaAltaEmpleado = value; }
        public DateTime FchaBajaEmpleado { get => fchaBajaEmpleado; set => fchaBajaEmpleado = value; }
        public string UsuarioEmpleado { get => usuarioEmpleado; set => usuarioEmpleado = value; }
        public string PasswordEmpleado { get => passwordEmpleado; set => passwordEmpleado = value; }
    }
}

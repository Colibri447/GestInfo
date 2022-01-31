using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestInfo.CapaEntidades
{
    public class ContactosCliente
    {
        private int idContacto; // id del contacto
        private int idClienteContacto;//id del cliente
        private string nombreContactoCliente; //Nombre del contacto
        private string apellidoContactoCliente; //Apellido del contacto
        private string tlf1ContactoCliente; //Telefono 1 del contacto
        private string tlf2ContactoCliente; // Telefono 2 del contacto
        private string emailContactoCliente; // Correo electronico

 

        public ContactosCliente(int idContacto, int idClienteContacto, string nombreContactoCliente, string apellidoContactoCliente, string tlf1ContactoCliente, string tlf2ContactoCliente, string emailContactoCliente)
        {
            this.idContacto = idContacto;
            this.idClienteContacto = idClienteContacto;
            this.nombreContactoCliente = nombreContactoCliente;
            this.apellidoContactoCliente = apellidoContactoCliente;
            this.tlf1ContactoCliente = tlf1ContactoCliente;
            this.tlf2ContactoCliente = tlf2ContactoCliente;
            this.emailContactoCliente = emailContactoCliente;
        }

        public int IdContacto { get => idContacto; set => idContacto = value; }
        
        public int IdClienteContacto { get => idClienteContacto; set => idClienteContacto = value; }
        
        public string NombreContactoCliente { get => nombreContactoCliente; set => nombreContactoCliente = value; }
       
        public string ApellidoContactoCliente { get => apellidoContactoCliente; set => apellidoContactoCliente = value; }
      
        public string EmailContactoCliente { get => emailContactoCliente; set => emailContactoCliente = value; }
       
        public string Tlf2ContactoCliente { get => tlf2ContactoCliente; set => tlf2ContactoCliente = value; }
       
        public string Tlf1ContactoCliente { get => tlf1ContactoCliente; set => tlf1ContactoCliente = value; }
    }
}

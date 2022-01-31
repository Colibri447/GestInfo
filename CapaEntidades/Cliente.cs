using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestInfo.CapaEntidades
{
    public class Cliente
    {
        private int idCliente;
        private DateTime fechaAltaCliente;
        private DateTime fechaBajaCliente;
        private string nombreCliente;
        private string direccionCliente;



        public Cliente()
        {

        }

            public Cliente(int idCliente, DateTime fechaAltaCliente, DateTime fechaBajaCliente,  string nombreCliente, string direccionCliente)

            {
                this.idCliente = idCliente;
                this.fechaAltaCliente = fechaAltaCliente;
                this.fechaBajaCliente = fechaBajaCliente;
                this.nombreCliente = nombreCliente;
                this.direccionCliente = direccionCliente;

        }

            public int IdCliente

            {
                get => idCliente;
                set => idCliente = value;
            }
            public DateTime FechaAltaCliente { get => fechaAltaCliente; set => fechaAltaCliente = value; }
            public DateTime FechaBajaCliente { get => fechaBajaCliente; set => fechaBajaCliente = value; }
            public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
            public string DireccionCliente { get => direccionCliente; set => direccionCliente = value; }

    }
}

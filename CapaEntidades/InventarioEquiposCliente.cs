using System;

namespace GestInfo.CapaEntidades
{
    public class InventarioEquiposCliente
    {
        //Declarar variables.
        private int idInventario;

        private string numeroSerieInventarioEquipo;
        private string marcaInventarioEquipo;
        private string modeloInventarioEquipo;
        private int idTipoInventarioEquipo;
        private DateTime fchaAltaInventarioEquipo;
        private DateTime fchaBajaInventarioEquipo;
        private int idCliente;

        //Constructor Vacío.
        public InventarioEquiposCliente()
        {
        }

        //Constructor de los Parámetros.
        public InventarioEquiposCliente(int IdInventario, string NumeroSerieInventarioEquipo, string MarcaInventarioEquipo, string ModeloInventarioEquipo, int IdTipoInventarioEquipo, DateTime FchaAltaInventarioEquipo, DateTime FchaBajaInventarioEquipo, int IdCliente)
        {
            this.idInventario = IdInventario;
            this.numeroSerieInventarioEquipo = NumeroSerieInventarioEquipo;
            this.marcaInventarioEquipo = MarcaInventarioEquipo;
            this.modeloInventarioEquipo = ModeloInventarioEquipo;
            this.idTipoInventarioEquipo = IdTipoInventarioEquipo;
            this.fchaAltaInventarioEquipo = FchaAltaInventarioEquipo;
            this.fchaBajaInventarioEquipo = FchaBajaInventarioEquipo;
            this.IdCliente = IdCliente;
        }

        //constructor con un parametro
        public InventarioEquiposCliente(int idInventario)
        {
            IdInventario = idInventario;
        }

        //constructor con todos los parametros salvo idinventario
        public InventarioEquiposCliente(string numeroSerieInventarioEquipo = null, string marcaInventarioEquipo = null, string modeloInventarioEquipo = null, int idTipoInventarioEquipo = 0, DateTime fchaAltaInventarioEquipo = default, DateTime fchaBajaInventarioEquipo = default, int idCliente = 0)
        {
            NumeroSerieInventarioEquipo = numeroSerieInventarioEquipo;
            MarcaInventarioEquipo = marcaInventarioEquipo;
            ModeloInventarioEquipo = modeloInventarioEquipo;
            IdTipoInventarioEquipo = idTipoInventarioEquipo;
            FchaAltaInventarioEquipo = fchaAltaInventarioEquipo;
            FchaBajaInventarioEquipo = fchaBajaInventarioEquipo;
            IdCliente = idCliente;
        }

        //Encapsulamiento con métodos Get y Set.
        public int IdInventario { get => idInventario; set => idInventario = value; }

        public string NumeroSerieInventarioEquipo { get => numeroSerieInventarioEquipo; set => numeroSerieInventarioEquipo = value; }
        public string MarcaInventarioEquipo { get => marcaInventarioEquipo; set => marcaInventarioEquipo = value; }
        public string ModeloInventarioEquipo { get => modeloInventarioEquipo; set => modeloInventarioEquipo = value; }
        public int IdTipoInventarioEquipo { get => idTipoInventarioEquipo; set => idTipoInventarioEquipo = value; }
        public DateTime FchaAltaInventarioEquipo { get => fchaAltaInventarioEquipo; set => fchaAltaInventarioEquipo = value; }
        public DateTime FchaBajaInventarioEquipo { get => fchaBajaInventarioEquipo; set => fchaBajaInventarioEquipo = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
    }
}
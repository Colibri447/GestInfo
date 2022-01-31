namespace GestInfo.CapaEntidades
{
    //creamos las propiedades de la base de datos
    public class Tipoequipos
    {
        private int idTipoEquipo;
        private string nombreTipoEquipo;

        public int IdTipoEquipo { get => idTipoEquipo; set => idTipoEquipo = value; }
        public string NombreTipoEquipo { get => nombreTipoEquipo; set => nombreTipoEquipo = value; }

        //creamos un constructor vacio
        public Tipoequipos()
        {
        }

        //creamos un constructor con dos parametros
        public Tipoequipos(int IdTipoEquipo, string NombreTipoEquipo)
        {
            this.idTipoEquipo = IdTipoEquipo;
            this.nombreTipoEquipo = NombreTipoEquipo;
        }

        //creamos un constructor con un parametro
        public Tipoequipos(string NombreTipoEquipo)
        {
            this.nombreTipoEquipo = NombreTipoEquipo;
        }
    }
}
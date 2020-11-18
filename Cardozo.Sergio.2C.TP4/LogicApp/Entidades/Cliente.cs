namespace LogicApp.Entidades
{
    public class Cliente
    {
        private int id;
        private string idSocio;
        private string nombre;
        private string apellido;
             

        public int Id 
        { 
            get => id;
            set => id = value;
        }
        public string IdSocio 
        {
            get => idSocio; 
            set => idSocio = value; 
        }
        public string Nombre 
        { 
            get => nombre; 
            set => nombre = value;
        }
        public string Apellido 
        { 
            get => apellido;
            set => apellido = value; 
        }
        public Cliente(int id, string idSocio, string nombre, string apellido)
        {
            this.id = id;
            this.idSocio = idSocio;
            this.nombre = nombre;
            this.apellido = apellido;
        }
       
        public static bool operator ==(Cliente cli, Cliente cli2)
        {
            return cli.Apellido == cli2.Apellido && cli.Nombre == cli2.Nombre || cli.IdSocio == cli2.IdSocio;
        }
        public static bool operator !=(Cliente cli, Cliente cli2)
        {
            return !(cli == cli2);
        }

    }
}
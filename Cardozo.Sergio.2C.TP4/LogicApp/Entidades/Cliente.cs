using LogicApp.Comun;
using System;

namespace LogicApp.Entidades
{
    public class Cliente
    {
        private int id;
        private string idSocio;
        private string nombre;
        private string apellido;

        /// <summary>
        /// Propiedad Id del cliente
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// Propiedad IdSocio del cliente 
        /// </summary>
        public string IdSocio
        {
            get { return idSocio; }
            set { this.idSocio = value; }
        }
        /// <summary>
        /// Propiedad Nombre del cliente
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (ValidarNombreApellido(value) != null)
                    this.nombre = value;
            }
        }
        public string Apellido
        {
            get { return apellido; }
            set
            {
                if (ValidarNombreApellido(value) != null)
                    this.apellido = value;
            }
        }
        public Cliente(int id, string idSocio, string nombre, string apellido)
        {
            this.Id = id;
            this.IdSocio = idSocio;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        /// <summary>
        /// Validacion del atributo Nombre y Apellido
        /// </summary>
        /// <param name="dato">Texto a comprobar.</param>
        /// <returns>Retorna el atributo si es correcto, caso contrario retorna null.</returns>
        private string ValidarNombreApellido(string dato)
        {
            foreach (char letra in dato)
            {
                if (!(char.IsLetter(letra) || char.IsWhiteSpace(letra)))
                    return null;
            }
            return dato;
        }       
        public static bool operator ==(Cliente cli, Cliente cli2)
        {
            return cli.Apellido == cli2.Apellido && cli.Nombre == cli2.Nombre || cli.IdSocio == cli2.IdSocio;
        }
        /// <summary>
        /// Dos clientes son distintos si tienen el nombre y apellido o si tienen el mismo DNI
        /// </summary>
        /// <param name="cli"></param>
        /// <param name="cli2"></param>
        /// <returns></returns>
        public static bool operator !=(Cliente cli, Cliente cli2)
        {
            return !(cli == cli2);
        }

    }
}
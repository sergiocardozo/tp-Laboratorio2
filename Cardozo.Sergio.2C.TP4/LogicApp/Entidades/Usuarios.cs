using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicApp.Entidades
{
    public class Usuarios
    {
        private static int id;
        private static string nombreUsuario;
        private static string contraseña;
        private static string nombre;
        private static string apellido;

        #region Propiedades
        /// <summary>
        /// Propiedad ID del Usuario
        /// </summary>
        public static int ID
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// Propiedad Nombre del Usuario 
        /// </summary>
        public static string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        /// <summary>
        /// Propiedad Contraseña del Usuario
        /// </summary>
        public static string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        /// <summary>
        /// Propiedad Nombre del Usuario
        /// </summary>
        public static string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        /// <summary>
        /// Propiedad Apellido del Usuario
        /// </summary>
        public static string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        } 
        #endregion
    }
}

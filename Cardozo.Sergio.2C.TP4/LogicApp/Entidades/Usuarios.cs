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

        public static int ID 
        {
            get => id; 
            set => id = value;
        }
        public static string NombreUsuario 
        { 
            get => nombreUsuario; 
            set => nombreUsuario = value;
        }
        public static string Contraseña
        { 
            get => contraseña;
            set => contraseña = value;
        }
        public static string Nombre 
        {
            get => nombre; 
            set => nombre = value; 
        }
        public static string Apellido { 
            get => apellido; 
            set => apellido = value; 
        }
    }
}

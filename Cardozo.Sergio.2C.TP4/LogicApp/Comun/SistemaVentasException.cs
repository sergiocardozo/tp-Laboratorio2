using LogicApp.PersistenciaDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicApp.Comun
{
    public class SistemaVentasException : Exception, IArchivo
    {
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public SistemaVentasException()
            :this("",null)
        {
        }

        public SistemaVentasException(string message) 
            : base(message)
        {
            Serializer<SistemaVentasException>.Escribir(this, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="inner"></param>
        public SistemaVentasException(string mensaje, Exception inner)
            : base(mensaje, inner)
        {
            Serializer<SistemaVentasException>.Escribir(this, true);
        }
        /// <summary>
        /// Propiedad ReadOnly que escribe en el archivo fecha del error, y mensaje
        /// </summary>
        public string Texto
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(DateTime.Now.ToString() + ":" + this.Message);
                
                Exception innerException = this.InnerException;
                while (innerException != null)
                {
                    sb.AppendLine(innerException.Message);
                    innerException = innerException.InnerException;
                }

                return sb.ToString();
            }
        }
        /// <summary>
        /// Propiedad ReadOnly que pone la ruta en donde se va a escribir el texto
        /// </summary>
        public string Ruta
        {
            get
            {
                return String.Format(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\log.txt");
            }
        }
    }
}

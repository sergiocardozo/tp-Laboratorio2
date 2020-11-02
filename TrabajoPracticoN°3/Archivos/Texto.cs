using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Guarda un string como archivo de texto.
        /// </summary>
        /// <param name="archivo">Direccion de archivo.</param>
        /// <param name="datos">Hilo de texto a guardar.</param>
        /// <returns>True en caso de ser guardado correctamente.</returns>
        public bool Guardar(string archivo, string datos)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(archivo))
                {
                    writer.WriteLine(datos);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
        }
        /// <summary>
        /// Lee un archivo de texto
        /// </summary>
        /// <param name="archivo">Direccion de archivo</param>
        /// <param name="datos">Contenido devuelto</param>
        /// <returns>True en caso de leerlo correctamente.</returns>
        public bool Leer(string archivo, out string datos)
        {

            try
            {
                using (StreamReader reader = new StreamReader(archivo))
                {
                    datos = reader.ReadToEnd();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
        }
    }
}

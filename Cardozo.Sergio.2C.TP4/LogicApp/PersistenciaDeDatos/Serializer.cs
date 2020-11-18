using LogicApp.Comun;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace LogicApp.PersistenciaDeDatos
{
    public static class Serializer<T>
         where T : class, new()
    {
        /// <summary>
        /// Serializa un objeto a formato XML.
        /// </summary>
        /// <param name="objeto">Objeto a serializar.</param>
        /// <param name="ruta">Ruta donde se creará el archivo de serialización.</param>
        public static void SerializarAXml(T objeto, string ruta)
        {
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(ruta, Encoding.UTF32);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
              serializer.Serialize(writer, objeto);
            }            
            catch (Exception ex)
            {
                throw new SistemaVentasException("Error al serializar el objeto", ex);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }

        }
        /// <summary>
        /// Serializa un objeto en formato archivo de texto si el archivo existe lo sobreescribe
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="append"></param>
        public static void Escribir(IArchivo objeto, bool append)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(objeto.Ruta, append, Encoding.UTF8);
                sw.Write(objeto.Texto);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
    }
}
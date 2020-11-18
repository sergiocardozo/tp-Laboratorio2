using LogicApp.Comun;
using LogicApp.PersistenciaDeDatos;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicApp.Entidades
{
    public class Empresa
    {
        private List<Venta> ventas;
        private List<Cliente> clientes;
        private List<VideoJuego> videoJuegos;

        /// <summary>
        /// Propiedad Lista de Ventas
        /// </summary>
        public List<Venta> Ventas 
        {
            get { return ventas; }
            set { ventas = value; } 
        }
        /// <summary>
        /// Propiedad Lista de Clientes
        /// </summary>
        public List<Cliente> Clientes 
        {
            get { return clientes; }
            set { clientes = value; }
        }
        /// <summary>
        /// Propiedad Lista de VideoJuegos
        /// </summary>
        public List<VideoJuego> VideoJuegos 
        {
            get { return videoJuegos; }
            set { videoJuegos = value; }
        }

        /// <summary>
        /// Contructor inicializa las listas
        /// </summary>
        public Empresa()
        {
            this.ventas = new List<Venta>();
            this.clientes = new List<Cliente>();
            this.videoJuegos = new List<VideoJuego>();
        }

        /// <summary>
        /// Metodo que guarda en un archivo XML las ventas
        /// </summary>
        /// <param name="nuevaVenta">Ventas que va a guardar</param>
        public void ArchivoTextoVentas(Venta nuevaVenta)
        {
            this.ventas.Add(nuevaVenta);
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"Venta.xml"));
            Serializer<List<Venta>>.SerializarAXml(ventas, ruta);
        }
        /// <summary>
        /// Sobrecarga que agrega cliente a la lista
        /// </summary>
        /// <param name="empresa"></param>
        /// <param name="cliente"></param>
        /// <returns>Si el cliente ya se encuentra en la lista lanza una excepcion, caso contrario lo agrega</returns>
        public static Empresa operator +(Empresa empresa, Cliente cliente)
        {
            foreach (Cliente item in empresa.Clientes)
            {
                if (item == cliente)
                    throw new SistemaVentasException("El cliente ya se encuentra en la lista");
            }
            empresa.Clientes.Add(cliente);
            return empresa;
        }
        /// <summary>
        /// Sobrecarga que agrega un VideoJuego si no esta previamente cargado
        /// </summary>
        /// <param name="empresa"></param>
        /// <param name="juego"></param>
        /// <returns>Si el juego ya esta en la lista lanza una excepcion, caso contrario lo agrega</returns>
        public static Empresa operator +(Empresa empresa, VideoJuego juego)
        {
            foreach (VideoJuego item in empresa.VideoJuegos)
            {
                if (item == juego)
                    throw new SistemaVentasException("El juego ya se encuentra en la lista");
            }
            empresa.VideoJuegos.Add(juego);
            return empresa;
        }

    }
}

using LogicApp.Entidades;
using System;

namespace LogicApp.Entidades
{
    [Serializable]
    public class Venta
    {
        private string cliApellido;
        private string cliNombre;
        private DateTime fechaVenta;
        private double ganancia;
        private string nombreJuego;

        /// <summary>
        /// Propiedad Apellido Cliente
        /// </summary>
        public string CliApellido 
        {
            get { return cliApellido; }
            set { cliApellido = value; }
        }
        /// <summary>
        /// Propiedad Nombre Cliente
        /// </summary>
        public string CliNombre 
        {
            get { return cliNombre; }
            set { cliNombre = value; }
        }
        /// <summary>
        /// Propiedad Nombre del Juego 
        /// </summary>
        public string NombreJuego 
        {
            get { return nombreJuego; }
            set { nombreJuego = value; }
        }
        /// <summary>
        /// Propiedad Ganancia
        /// </summary>
        public double Ganancia 
        {
            get { return ganancia; }
            set { ganancia = value; }
        }
        /// <summary>
        /// Propiedad Fecha de la venta
        /// </summary>
        public DateTime FechaVenta 
        {
            get { return fechaVenta; }
            set { fechaVenta = value; }
        }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Venta()
             : this(null, null, null, DateTime.Now, 0.0)
        {

        }
        /// <summary>
        /// Constructor Inicializa atributos de la clase
        /// </summary>
        /// <param name="cliApellido"></param>
        /// <param name="cliNombre"></param>
        /// <param name="nombreJuego"></param>
        /// <param name="fechaVenta"></param>
        /// <param name="ganancia"></param>
        public Venta(string cliApellido, string cliNombre, string nombreJuego, DateTime fechaVenta, double ganancia)
        {
            this.cliApellido = cliApellido;
            this.cliNombre = cliNombre;
            this.fechaVenta = fechaVenta;
            this.ganancia = ganancia;
            this.nombreJuego = nombreJuego;
        }
    }
}
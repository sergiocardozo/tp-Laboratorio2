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

                
        public string CliApellido 
        { 
            get => cliApellido; 
            set => cliApellido = value;
        }
        public string CliNombre 
        { 
            get => cliNombre; 
            set => cliNombre = value; 
        }
        public string NombreJuego 
        { 
            get => nombreJuego; 
            set => nombreJuego = value;
        }
        public double Ganancia 
        { 
            get => ganancia; 
            set => ganancia = value;
        }
        public DateTime FechaVenta 
        { 
            get => fechaVenta; 
            set => fechaVenta = value; 
        }

        public Venta()
             : this(null, null, null, DateTime.Now, 0.0)
        {

        }
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
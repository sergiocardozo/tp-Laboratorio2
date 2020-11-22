using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicApp.Entidades;
using LogicApp.PersistenciaDeDatos;
using LogicApp.Comun;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente clientes1 = new Cliente(1, "9", "Martin", "Palermo");
            Cliente cliente2 = new Cliente(2, "9", "Roman", "Riquelme");
            Cliente cliente3 = new Cliente(3, "10", "Roman", "Riquelme");
            Cliente cliente4 = new Cliente(4, "4", "Julio", "Buffarini");
            Empresa empresa = new Empresa();

            Console.WriteLine("-----------------------------------------------------------------------------");
            try
            {
                empresa += clientes1;
                Console.WriteLine("Entra roman con la 9");
                empresa += cliente2;
            }
            catch (SistemaVentasException e)
            {
                Console.WriteLine();
                Console.WriteLine("che para!!! Te equivocaste y metiste a roman de 9, va de 10!", e.Message);
            }

            Console.WriteLine("-----------------------------------------------------------------------------");

            Console.WriteLine("Ahora si Entra Roman de 10");

            empresa += cliente3;
            empresa += cliente4;

            foreach (Cliente item in empresa.Clientes)
            {
                Console.WriteLine($"{item.IdSocio} - {item.Nombre} - {item.Apellido}");
            }


            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            VideoJuego juego = new VideoJuego(1, "Accion", 1, "FIFA 21", 9999.99, 3, 1);
            VideoJuego juego1 = new VideoJuego(2, "Deportes", 2, "FIFA 21", 9999.99, 3, 1);
            VideoJuego juego2 = new VideoJuego(5, "Clasico", 1, "MARIO BROSS - FAMILY", 999.99, 3, 5);

            empresa += juego;

            Console.WriteLine();
            Console.WriteLine("Intento Agregar un juego con el mismo nombre");
            try
            {
                empresa += juego1;
            }
            catch (SistemaVentasException ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
            }

            empresa += juego2;

            foreach (VideoJuego item in empresa.VideoJuegos)
            {
                Console.WriteLine($"{item.NombreVideoJuego} - {item.Precio} - {item.Stock} - {item.NombreTipoJuego}");
            }


            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();


            Venta venta = new Venta("Carlitos", "Tevez", "FIFA 21", DateTime.Now, 9999.99);
            Venta venta2 = new Venta("Abila", "Wanchope", "MARIO BROSS", DateTime.Now, 999.99);

            List<Venta> ventas = new List<Venta>() ;
            ventas.Add(venta);
            ventas.Add(venta2);
            
            foreach (Venta item in ventas)
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine($"{item.CliNombre} - {item.CliApellido} - {item.NombreJuego} - {item.FechaVenta} - {item.Ganancia}");
                empresa.ArchivoTextoVentas(item);
                Console.WriteLine($"Se guardo la venta de {item.CliApellido}");
            }


            Console.ReadKey();
        }
    }
}

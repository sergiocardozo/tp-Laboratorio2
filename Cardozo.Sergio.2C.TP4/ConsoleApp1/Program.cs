using LogicApp.Comun;
using LogicApp.Entidades;
using LogicApp.PersistenciaDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaDAO sistema = new SistemaDAO();
            int id = 0;
            Cliente clientes1 = new Cliente(id++, "35804304", "Sergio", "Cardozo");
            Cliente cliente2 = new Cliente(id++, "35804304", "Sergio", "Cardozo");
            Cliente cliente3 = new Cliente(id++, "20", "Jorge", "Maldonado");
            Empresa empresa = new Empresa();

            empresa += clientes1;
            try
            {
                empresa += cliente2;
            }
            catch (SistemaVentasException e)
            {
                Console.WriteLine(e.Message);
            }
            empresa += cliente3;


            foreach (Cliente item in empresa.Clientes)
            {
                sistema.InsertarCliente(item.IdSocio, item.Nombre, item.Apellido);
            }
            List<Cliente> clientes = sistema.MostrarClientes();

            foreach (Cliente item in clientes)
            {
                Console.WriteLine($"{item.IdSocio}-{item.Nombre}-{item.Apellido}");
            }

            Console.ReadKey();
        }
    }
}

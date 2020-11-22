using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicApp.Comun;
using LogicApp.PersistenciaDeDatos;
using LogicApp.Entidades;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class TestUnitarios
    {
        /// <summary>
        /// Test lanza Exception si dos clientes son iguales
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SistemaVentasException))]
        public void DosClientesSonIgualesExcepciones()
        {
            Cliente cliente = new Cliente(1, "0001", "Roman", "Riquelme");
            Cliente cliente2 = new Cliente(2, "0001", "Martin", "Palermo");
            Empresa empresa = new Empresa();

            empresa += cliente;
            empresa += cliente2;

            Assert.AreEqual(cliente, cliente2);
        }
        /// <summary>
        /// Test lanza excepcion si dos juegos son iguales
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SistemaVentasException))]
        public void DosJuegosSonIgualesExcepciones()
        {
            VideoJuego juego = new VideoJuego(1, "Accion", 1, "Assassin Creed", 1999.99, 4, 1);
            VideoJuego juego2 = new VideoJuego(2, "Deportes", 2, "Assassin Creed", 1999.99, 4, 2);
            Empresa empresa = new Empresa();

            empresa += juego;
            empresa += juego2;
        }
        /// <summary>
        /// Test lanza excepcion si la ruta no es la correcta 
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SistemaVentasException))]
        public void ErrorAlSerializaXml()
        {
            Venta venta = new Venta("Carlitos", "Tevez", "FIFA 21", DateTime.Now, 1);
            List<Venta> ventas = new List<Venta>();
            ventas.Add(venta);
            Serializer<List<Venta>>.SerializarAXml(ventas, "C:\\PruebaVenta");
        }
        /// <summary>
        /// Test Serializa la excepcion en texto
        /// </summary>
        [TestMethod]
        public void SerializaExcepcionesTexto()
        {
            try
            {
                VideoJuego juego = new VideoJuego(1, "Accion", 1, "Assassin Creed", 1999.99, 4, 1);
                VideoJuego juego2 = new VideoJuego(2, "Deportes", 2, "Assassin Creed", 1999.99, 4, 2);
                Empresa empresa = new Empresa();

                empresa += juego;
                empresa += juego2;
            }
            catch (SistemaVentasException ex)
            {
                Serializer<List<SistemaVentasException>>.Escribir(ex, true);
            }
        }
        /// <summary>
        /// Text verifica que se instancie una venta
        /// </summary>
        [TestMethod]
        public void TestListaVentasInstanciada()
        {
            // arrange
            Empresa empresa = new Empresa();
            bool resultado = false;

            // act
            if (!(empresa.Ventas is null))
            {
                resultado = true;
            }

            // assert
            Assert.IsTrue(resultado);
        }
        /// <summary>
        /// Test sobrecarga de operadores dos clientes son iguales
        /// </summary>
        [TestMethod]
        public void TestSobrecargaOperadorClienteIgual()
        {
            //arrange
            bool resultado = false;
            Cliente cliente = new Cliente(1, "0001", "Roman", "Riquelme");
            Cliente cliente2 = new Cliente(1, "0001", "Martin", "Palermo");           

            //act
            try
            {
                
                if (cliente == cliente2)
                {
                    resultado = true;
                }

            }
            catch (SistemaVentasException e)
            {
                resultado = true;
            }
            //assert
            Assert.IsTrue(resultado);
        }
        /// <summary>
        /// Test Sobrecarga de operadores si dos juegos son iguales
        /// </summary>
        [TestMethod]
        public void TestSobrecargaOperadorJuegoIgual()
        {
            //arrange
            bool resultado = false;
            VideoJuego juego = new VideoJuego(1,"Accion",2,"FIFA 21",9999.99,5,1);
            VideoJuego juego1 = new VideoJuego(2,"Deportes",3,"FIFA 21",9999.99,5,2);

            //act
            try
            {

                if (juego == juego1)
                {
                    resultado = true;
                }

            }
            catch (SistemaVentasException e)
            {
                resultado = true;
            }
            //assert
            Assert.IsTrue(resultado);
        }
    }
}

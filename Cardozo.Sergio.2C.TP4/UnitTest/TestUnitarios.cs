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
        [TestMethod]
        [ExpectedException(typeof(SistemaVentasException))]
        public void DosClientesSonIguales()
        {
            Cliente cliente = new Cliente(1, "0001", "Roman", "Riquelme");
            Cliente cliente2 = new Cliente(2, "0001", "Martin", "Palermo");
            Empresa empresa = new Empresa();

            empresa += cliente;
            empresa += cliente2;

            Assert.AreEqual(cliente, cliente2);
        }

        [TestMethod]
        [ExpectedException(typeof(SistemaVentasException))]
        public void DosJuegosSonIguales()
        {
            VideoJuego juego = new VideoJuego(1, "Accion", 1, "Assassin Creed", 1999.99, 4, 1);
            VideoJuego juego2 = new VideoJuego(2, "Deportes", 2, "Assassin Creed", 1999.99, 4, 2);
            Empresa empresa = new Empresa();

            empresa += juego;
            empresa += juego2;


        }
        
    }
}

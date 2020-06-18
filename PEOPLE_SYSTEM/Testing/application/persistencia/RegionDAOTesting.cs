using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo.application.modelo;
using Persistencia.application.dao;

namespace Testing.application.persistencia
{
    [TestClass]
    public class RegionDAOTesting
    {
        [TestMethod]
        public void TestInsertar()
        {
            RegionModel region = new RegionModel();
            region.Nombre = "ARICA Y PARINACOTA";
            region.Descripcion = "ZONA NORTE";

            RegionDAO regionDAO = new RegionDAO();
            bool resultado = regionDAO.Insertar(region);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestBuscarTodo()
        {
            RegionDAO regionDAO = new RegionDAO();
            List<RegionModel> regiones = regionDAO.BuscarTodo();

            Assert.IsTrue(regiones.Count > 0);
        }
    }

}

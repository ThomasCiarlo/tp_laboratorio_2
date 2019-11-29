using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test_Unitarios
{

    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void CorreoNull()
        {
            Correo correo = new Correo();

            Assert.IsNotNull(correo.Paquetes);
        }

        [TestMethod]
        public void TrackingID()
        {
            Paquete paquete = new Paquete("asd", "1234");
            Paquete paquete2 = new Paquete("asd", "1234");
            Correo correo = new Correo();
            Exception ex = null;

            try
            {
                correo += paquete;
                correo += paquete2;
            }
            catch (Exception e)
            {
                ex = e;
            }

            Assert.IsInstanceOfType(ex, typeof(TrackingIdRepetidoException));
        }
    }
}




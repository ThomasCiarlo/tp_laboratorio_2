using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases_Instanciables;
using Excepciones;

namespace Test_Pruebas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestValorNumerico()
        {
            string dni = "39444858";
            int dniValidado = 39444858;
            Alumno alumno = new Alumno(1000, "Juan", "Perez", dni, EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            Assert.AreEqual(dniValidado, alumno.DNI);
        }

        [TestMethod]
        public void TestNull()
        {
            Profesor profesor = new Profesor(1000, "Juan", "Perez", "39328048", EntidadesAbstractas.Persona.ENacionalidad.Argentino);

            Assert.IsNotNull(profesor);
        }

        [TestMethod]
        public void TestExcepcion1()
        {
            string dni = "0";
            Alumno alumno;

            try
            {
                alumno = new Alumno(1000, "Juan", "Perez", dni, EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(Excepciones.DniInvalidoException));
            }

        }


        [TestMethod]
        public void TestExcepcion2()
        {
            string dni = "30000000";
            Alumno alumno;

            try
            {
                alumno = new Alumno(1000, "Juan", "Perez", dni, EntidadesAbstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(Excepciones.NacionalidadInvalidaException));
            }
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void areacuadradoTest()
        {
            Geometria g = new Geometria();
            int areacuadrado = g.areacuadrado(10);
            Assert.AreEqual(100, areacuadrado);
        }
        [TestMethod]
        public void areaCirculoTest()
        {
            Geometria g = new Geometria();
            double areacirculo = g.areaCirculo(10);

            const double PI = 3.1416;
            double area = PI * Math.Pow(10, 2);

            Assert.AreEqual(area, areacirculo);
        }
        [TestMethod]
        public void areaTrianguloTest()
        {
            Geometria g = new Geometria(3);
            double areatriangulo = g.areatriangulo(10,10);

            Assert.AreEqual(50, areatriangulo);
        }
        [TestMethod]
        public void areaRectanguloTest()
        {
            Geometria g = new Geometria();
            double area = g.arearectangulo(10,10);

            Assert.AreEqual(100, area);
        }
        [TestMethod]
        public void areaPentagonoTest()
        {
            Geometria g = new Geometria();
            double area = g.areapentagono(10, 10);

            Assert.AreEqual(50, area);
        }
        [TestMethod]
        public void arearomboTest()
        {
            Geometria g = new Geometria();
            double area = g.arearombo(10, 10);

            Assert.AreEqual(50, area);
        }
        [TestMethod]
        public void arearomboide()
        {
            Geometria g = new Geometria();
            double area = g.arearomboide(10, 10);

            Assert.AreEqual(100, area);
        }
        [TestMethod]
        public void areatrapecioTest()
        {
            Geometria g = new Geometria();
            double area = g.areatrapecio(10, 10, 10);

            Assert.AreEqual(100, area);
        }
    }
}



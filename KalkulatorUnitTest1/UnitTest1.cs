using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KolokwiumZ2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestKonstruktoraIWlasnosci()
        {
            double a = 10.5;
            double b = 60;

        Kalkulator k = new Kalkulator(a, b);

        double k_a = k.a;
        double k_b = k.b;

        Assert.AreEqual(a, k_a, "Niezgodnosc w a");
        Assert.AreEqual(b, k_b, "Niezgodnosc w b");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDzieleniaWyjatek()
        {
            Kalkulator k = new Kalkulator(1.0, 0.0);

            double w = k.Iloraz();
        }
        [TestMethod]
        public void TestOperacji()
        {
            Kalkulator k = new Kalkulator(6.0, 3.0);

            Assert.AreEqual(9.0, k.Suma(), "Niezgodnosc w sumie");
            Assert.AreEqual(3.0, k.Roznica(), "Niezgodnosc w roznicy");
            Assert.AreEqual(18.0, k.Iloczyn(), "Niezgodnosc w iloczynie");
            Assert.AreEqual(2.0, k.Iloraz(), "Niezgodnosc w ilorazie");
            Assert.AreEqual(216.0, k.Potega(), "Niezgodnosc w ilorazie");
        }
    }
}

using System;
using M05Lab_Fuhrpark;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace M16Demo_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BeschleunigePkwÜberMaxG()
        {
            PKW pkw = new PKW("Lamborgini", 200_000.00, 250, 3, 4, 50_000);

            pkw.StarteMotor();
            pkw.Beschleunigen(pkw.MaximalGeschwindigkeit + 10);
            // Klasse Assert soll in Test-Methoden mindestens einmal auftauchen
            Assert.AreNotEqual(pkw.MaximalGeschwindigkeit, pkw.AktuelleGeschwindigkeit);
        }
    }
}

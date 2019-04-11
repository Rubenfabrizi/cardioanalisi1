using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using equazionilybrary;

namespace datacardiotest
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(17,203)]
        [DataRow(54, 166)]
        public void TestMethod1(int eta, int etaattesa)
        {
            
            int etarestituita = equazionilybrary.Class1.Calcfrecquenza(eta);

            Assert.AreEqual(etaattesa, etarestituita);
        }
    }
}

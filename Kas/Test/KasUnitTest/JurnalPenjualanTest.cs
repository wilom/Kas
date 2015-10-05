using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kas;

namespace KasUnitTest
{
    [TestClass]
    public class JurnalPenjualanTest
    {
        AkunKas _akunKas;
        Jurnal _jurnal;
        [TestInitialize]
        public void Init()
        {
            _akunKas = new AkunKas("1001", "Kas");
            _jurnal = new Jurnal("J0001", _akunKas, new DateTime(2015, 1, 1), "201501");
        }
        [TestMethod]
        public void TestPenjualanAyam()
        {
        }
    }
}

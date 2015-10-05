using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kas.Dto;
using Kas;

namespace KasUnitTest
{
    [TestClass]
    public class TransaksiPenjualanTest
    {
        [TestMethod]
        public void BuatTransaksiPenjualan()
        {
            var penjualan = new TransaksiPenjualan("SJ0001", new DateTime(2015, 1, 2), "4001", 50000.0);
            TransaksiDto snapshot = penjualan.SnapShot();
            var expect = new TransaksiDto() { NoTransaksi = "SJ0001", TanggalTransaksi = new DateTime(2015, 1, 2), NoAkun = "4001", Nominal = 50000.0 };
            Assert.AreEqual(expect, snapshot);
        }
    }
}

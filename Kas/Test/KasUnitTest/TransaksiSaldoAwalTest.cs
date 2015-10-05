using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kas;
using Kas.Dto;

namespace KasUnitTest
{
    [TestClass]
    public class TransaksiSaldoAwalTest
    {
        [TestMethod]
        public void BuatTransaksiSaldoAwal()
        {
            var saldoAwal = new TransaksiSaldoAwal("SA0001", new DateTime(2015, 1, 1), "2001", 20000.0);
            TransaksiDto snapshot = saldoAwal.SnapShot();
          
            var expect = new TransaksiDto() { NoTransaksi = "SA0001", TanggalTransaksi = new DateTime(2015, 1, 1), NoAkun = "2001", Nominal = 20000.0 };
            Assert.AreEqual(expect, snapshot);
        }
    }
}

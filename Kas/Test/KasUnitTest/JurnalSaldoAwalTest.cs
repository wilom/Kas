using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kas;
using Kas.Dto;

namespace KasUnitTest
{
    [TestClass]
    public class JurnalSaldoAwalTest
    {
        AkunKas _akunKas ;
        Jurnal _jurnal;
        [TestInitialize]
        public void Init()
        {
            _akunKas = new AkunKas("1001", "Kas");
            _jurnal = new Jurnal("J0001", _akunKas, new DateTime(2015, 1, 1), "201501");
            //_jurnal = new JurnalSaldoAwalBuilder()
            //              .Kode("J0001")
            //              .Kas(_akunKas)
            //              .Tanggal(new DateTime(2015, 1, 1))
            //              .Period("201501")
            //              .Modal(akunModal)
            //              .Nominal(20000.0)
            //              .Build();
        }
        [TestMethod]
        public void TestBuatJurnalSaldoAwal()
        {
          
            var snapshot = _jurnal.SnapShot();
            var expectedJurnal = new JurnalDto() { NoJurnal="J0001",AkunKas="1001", TglJurnal=new DateTime(2015,1,1), Periode="201501"};
            Assert.AreEqual(expectedJurnal, snapshot);
           
        }
        [TestMethod]
        public void TestMasukanSaldoAwal()
        {
          
            
            var akunModal = new AkunModal("2001", "Modal");
            _jurnal.MasukSaldoAwal(akunModal,20000.0);
           // _jurnal.CreateJurnalSaldoAwal(akunModal, 20000.0);

            var snapshotKas = _jurnal.SnapShotKas();
            var expectedKas = new JurnalItemDto() { NoAkun = "1001", Keterangan = "Kas", Debet = 20000.0, Kredit = 0.0 };
            Assert.AreEqual(expectedKas, snapshotKas);

            var snapshotNonKas = _jurnal.SnapShotNonKas()[0];
            var expectedNonKas = new JurnalItemDto() { NoAkun = "2001", Keterangan = "Modal", Debet = 0.0, Kredit = 20000.0 };
            Assert.AreEqual(expectedNonKas, snapshotNonKas);
        }

        
    }
}

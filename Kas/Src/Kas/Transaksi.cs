using System;

namespace Kas
{
    public class Transaksi
    {
        private string _noTransaksi;
        private DateTime _tanggalTransaksi;
        private string _kodeAkun;
        private double _nominal;

        public Transaksi(string noTransaksi, DateTime tglTransaksi, string kodeAkun, double nominal)
        {
            this._noTransaksi = noTransaksi;
            this._tanggalTransaksi = tglTransaksi;
            this._kodeAkun = kodeAkun;
            this._nominal = nominal;
        }


        public Dto.TransaksiDto SnapShot()
        {
            return new Dto.TransaksiDto() { NoTransaksi = this._noTransaksi,
                                            TanggalTransaksi=this._tanggalTransaksi,
                                            NoAkun=this._kodeAkun,
                                            Nominal=this._nominal};
        }
    }
}

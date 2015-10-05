using System;

namespace Kas
{
    public class TransaksiSaldoAwal:Transaksi
    {
        public TransaksiSaldoAwal(string noTransaksi, DateTime tglTransaksi, string kodeAkun, double nominal)
            : base(noTransaksi, tglTransaksi, kodeAkun, nominal)
        {

        }
    }
}

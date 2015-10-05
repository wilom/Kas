using System;

namespace Kas
{
    public class TransaksiPenjualan : Transaksi
    {
       
        public TransaksiPenjualan(string noTransaksi, DateTime tglTransaksi, string kodeAkun, double nominal)
            : base(noTransaksi, tglTransaksi, kodeAkun, nominal)
        {
            
        }
       
    }
}

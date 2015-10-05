using System;

namespace Kas.Dto
{
    public class TransaksiDto
    {
        public string NoTransaksi { get; set; }

        public DateTime TanggalTransaksi { get; set; }

        public string NoAkun { get; set; }

        public double Nominal { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is TransaksiDto)) return false;
            var cmp = (TransaksiDto)obj;
            return this.NoTransaksi.Equals(cmp.NoTransaksi) &&
                this.TanggalTransaksi.Equals(cmp.TanggalTransaksi) &&
                this.NoAkun.Equals(cmp.NoAkun) &&
                this.Nominal.Equals(cmp.Nominal);
        }
    }
}

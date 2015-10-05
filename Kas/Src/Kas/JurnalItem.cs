using Kas.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kas
{
    public abstract class  JurnalItem
    {
        private Akun _akun;
        protected double _nominal;

        public JurnalItem(Akun akun, double nominal)
        {
            this._akun = akun;
            this._nominal = nominal;
        }


        internal bool IsKas()
        {
            return this._akun is AkunKas;
        }
        public JurnalItemDto Snapshot()
        {
            return new JurnalItemDto() { NoAkun = this._akun.Kode, Keterangan = this._akun.Keterangan, Debet = this.GetDebet(), Kredit = this.GetKredit() };
        }
        public abstract double GetDebet();
        public abstract double GetKredit();
    }
}

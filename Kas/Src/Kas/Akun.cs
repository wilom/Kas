using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kas
{
    public class Akun
    {
        private string _kodeAkun;
        private string _keterangan;

        public Akun(string kodeAkun, string keterangan)
        {
            this._kodeAkun = kodeAkun;
            this._keterangan = keterangan;
        }

        public string Kode
        {
            get { return this._kodeAkun; }
        }

        public string Keterangan { get { return this._keterangan; } }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kas.Dto
{
    public class JurnalItemDto
    {
        public string NoAkun { get; set; }

        public string Keterangan { get; set; }

        public double Debet { get; set; }

        public double Kredit { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is JurnalItemDto)) return false;
            var cmp = (JurnalItemDto)obj;
            return this.NoAkun.Equals(cmp.NoAkun) &&
                this.Keterangan.Equals(cmp.Keterangan) &&
                this.Debet.Equals(cmp.Debet) &&
                this.Kredit.Equals(cmp.Kredit);
        }
    }
}

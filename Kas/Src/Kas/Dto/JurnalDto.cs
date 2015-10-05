using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kas.Dto
{
    public class JurnalDto
    {
        public string NoJurnal { get; set; }

        public DateTime TglJurnal { get; set; }

        public string Periode { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is JurnalDto)) return false;
            var cmp = (JurnalDto)obj;
            return this.NoJurnal.Equals(cmp.NoJurnal) &&
                this.TglJurnal.Equals(cmp.TglJurnal) &&
                this.Periode.Equals(cmp.Periode) &&
                this.AkunKas.Equals(cmp.AkunKas);
        }

        public string AkunKas { get; set; }
    }
}

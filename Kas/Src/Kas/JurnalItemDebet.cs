using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kas
{
    public class JurnalItemDebet : JurnalItem
    {
      
        public JurnalItemDebet(Akun akun, double nominal)
            :base(akun,nominal)
        {
          
        }

        public override double GetDebet()
        {
            return this._nominal;
        }

        public override double GetKredit()
        {
            return 0.0;
        }

       
    }
}

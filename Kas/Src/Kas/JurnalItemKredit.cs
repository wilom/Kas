using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kas
{
    public class JurnalItemKredit : JurnalItem
    {
        public JurnalItemKredit(Akun akun, double nominal)
            :base(akun,nominal)
        {
          
        }

        public override double GetDebet()
        {
            return 0.0;
        }

        public override double GetKredit()
        {
            return this._nominal;
        }
    }
}

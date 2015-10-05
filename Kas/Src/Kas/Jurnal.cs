using Kas.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kas
{
    public class Jurnal
    {
        private string _noJurnal;
        private DateTime _tglJurnal;
        private string _periode;
        private AkunKas _akunKas;
        private IList<JurnalItem> _jurnalItems = new List<JurnalItem>();
        public Jurnal(string noJurnal, AkunKas akunKas,DateTime tglJurnal, string periode)
        {
            this._noJurnal = noJurnal;
            this._tglJurnal = tglJurnal;
            this._periode = periode;
            this._akunKas = akunKas;
        }

        public JurnalDto SnapShot()
        {
            return new JurnalDto() { NoJurnal = this._noJurnal, TglJurnal = this._tglJurnal, Periode = this._periode, AkunKas=this._akunKas.Kode };
        }

        public void MasukSaldoAwal(AkunModal akunModal, double nominal)
        {
            var itemDebet = new JurnalItemDebet(this._akunKas, nominal);
            var itemKredit = new JurnalItemKredit(akunModal, nominal);
            this._jurnalItems.Add(itemDebet);
            this._jurnalItems.Add(itemKredit);
        }
       
        public JurnalItemDto SnapShotKas()
        {
            var jurnalItem = this._jurnalItems.Where(x=>x.IsKas()).FirstOrDefault();
            if (jurnalItem != null)
                return jurnalItem.Snapshot();
            else
                return null;
        }

        public IList<JurnalItemDto> SnapShotNonKas()
        {
            return this._jurnalItems.Where(x => x.IsKas() == false).Select(x=>x.Snapshot()).ToList();
        }
    }
}

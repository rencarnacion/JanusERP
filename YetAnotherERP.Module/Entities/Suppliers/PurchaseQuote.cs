using System;

using System.ComponentModel;
using System.Linq;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using JanusERP.Module.Base;

namespace JanusERP.Module.Entities.Suppliers
{
    [CreatableItem(false), NavigationItem("Suppliers"), VisibleInReports(true)]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class PurchaseQuote : BaseDocument
    {

        public PurchaseQuote(Session session ):base(session){}

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        [Association("PurchaseQuoteDetails", typeof(BaseDocumentLine)), Aggregated]
        public XPCollection<BaseDocumentLine> Details
        {
            get
            {
                return GetCollection<BaseDocumentLine>("Details");
            }
        }

        public override void UpdateTotal(bool forceChangeEvents)
        {
            if (!IsLoading && !IsSaving)
            {
                decimal? oldTotal = _TotalAmount;
                // decimal tempTaxAmount = 0;
                decimal tempTotal = Details.Sum(detail => detail.TotalAmount);

                _TotalAmount = tempTotal;

                if (forceChangeEvents)
                {
                    OnChanged("TotalAmount", oldTotal, tempTotal);
                }

            }
        }
    }
}

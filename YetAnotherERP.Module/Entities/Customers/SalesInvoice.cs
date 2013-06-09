using System;

using System.ComponentModel;
using System.Linq;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using JanusERP.Module.Base;

namespace JanusERP.Module.Entities.Customers
{
    [CreatableItem(false), NavigationItem("Customers"), VisibleInReports(true)]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class SalesInvoice: BaseDocument
    {
        
        public SalesInvoice(Session session)
            : base(session)        {                  }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        private CustomerAccount _CustomerID;
        /// <summary>
        /// Gets or sets the Customer.
        /// </summary>
        public CustomerAccount CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                SetPropertyValue("CustomerID", ref _CustomerID, value);
            }
        }



           [Association("SalesInvoiceDetails", typeof(BaseDocumentLine)), Aggregated]
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

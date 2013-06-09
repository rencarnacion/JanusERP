using System;

using System.ComponentModel;
using System.Linq;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using YetAnotherERP.Module.Base;

namespace YetAnotherERP.Module.Entities.Customers
{
    
    [CreatableItem(false), NavigationItem("Customers"), VisibleInReports(true)]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class SalesOrder : BaseDocument
    {
        public SalesOrder(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }



        [Association("SalesOrderDetails", typeof(BaseDocumentLine)), Aggregated]
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

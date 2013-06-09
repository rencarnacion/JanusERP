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
   public class SalesQuote: BaseDocument
    {

       public  SalesQuote(Session session)
           : base(session)
       {}

       public override void AfterConstruction()
       {
           base.AfterConstruction();
       }

       [Association("SalesQuoteDetails", typeof(BaseDocumentLine)), Aggregated]
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



        #region Actions 



        #endregion

    }
}

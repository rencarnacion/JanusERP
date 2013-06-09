using System;

using System.ComponentModel;

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
    public class CustomerAccount : BaseAccount
    {
       
        public CustomerAccount(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
    }

}
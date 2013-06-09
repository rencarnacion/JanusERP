using System;

using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using JanusERP.Module.Base;

namespace JanusERP.Module.Entities.CRM
{
    [CreatableItem(false), NavigationItem("CRM"), VisibleInReports(true)]
    [MapInheritance(MapInheritanceType.OwnTable)]
   public class Contact : Person
    {
        public Contact(Session session):base(session){}
    }
}

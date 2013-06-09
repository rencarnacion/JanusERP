using System;

using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using YetAnotherERP.Module.Base;

namespace YetAnotherERP.Module.Entities.CRM.List
{
    [VisibleInReports(true)]
    [CreatableItem(false), NavigationItem("CRM")]
    [DefaultProperty("CompetitorName")]
    public class OpportunityCompetitor : BasePersistentObject
    {
        public OpportunityCompetitor(Session session) : base(session) { }

        private string _CompetitorName;
        [Size(100)]
        public string CompetitorName
        {
            get
            {
                return _CompetitorName;
            }
            set
            {
                SetPropertyValue("CompetitorName", ref _CompetitorName, value);
            }
        }


    }
}

using System;

using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using JanusERP.Module.Base;

namespace JanusERP.Module.Entities.CRM.List
{
    [VisibleInReports(true)]
    [CreatableItem(false), NavigationItem("CRM")]
    [DefaultProperty("Definition")]
  public  class OpportunityCertainty : BasePersistentObject
    {

        public OpportunityCertainty(Session session) : base(session) { }

        private decimal _Percent;
        public decimal Percent
        {
            get
            {
                return _Percent;
            }
            set
            {
                SetPropertyValue("Percent", ref _Percent, value);
            }
        }

        private string _Definition;
        [Size(250)]
        public string Definition
        {
            get
            {
                return _Definition;
            }
            set
            {
                SetPropertyValue("Definition", ref _Definition, value);
            }
        }
    }
}

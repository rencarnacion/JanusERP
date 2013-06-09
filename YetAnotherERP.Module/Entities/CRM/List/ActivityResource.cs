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
    [DefaultProperty("Resource")]
    public class ActivityResource : BasePersistentObject
    {
        public ActivityResource(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            Active = true;
        }

        private string _Resource;
        [Size(50)]
        public string Resource
        {
            get
            {
                return _Resource;
            }
            set
            {
                SetPropertyValue("Resource", ref _Resource, value);
            }
        }

        private bool _Active;
        public bool Active
        {
            get
            {
                return _Active;
            }
            set
            {
                SetPropertyValue("Active", ref _Active, value);
            }
        }


    }
}

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
    [DefaultProperty("Category")]
    public class ActivityCategory : BasePersistentObject
    {
        public ActivityCategory(Session session) : base(session){}

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            Active = true;
        }

        private string _Category;
        [Size(50)]
        public string Category
        {
            get
            {
                return _Category;
            }
            set
            {
                SetPropertyValue("Category", ref _Category, value);
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

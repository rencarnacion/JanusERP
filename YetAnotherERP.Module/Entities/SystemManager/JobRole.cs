using System;

using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using YetAnotherERP.Module.Base;
using System.Drawing;
using DevExpress.Xpo.Metadata;

namespace YetAnotherERP.Module.Entities.SystemManager
{
    [VisibleInReports(true)]
    [CreatableItem(false), NavigationItem("System Manager")]
    [DefaultProperty("JobRoleDescription")]
    public class JobRole : BasePersistentObject
    {
        public JobRole(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            IsActive = true;
        }

        private string _JobRoleDescription;
        [Size(100)]
        public string JobRoleDescription
        {
            get
            {
                return _JobRoleDescription;
            }
            set
            {
                SetPropertyValue("JobRoleDescription", ref _JobRoleDescription, value);
            }
        }

        private bool _IsActive;
        public bool IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                SetPropertyValue("IsActive", ref _IsActive, value);
            }
        }
    }
}

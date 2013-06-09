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
    [DefaultProperty("Suffix")]
  public  class SaludationSuffix :  BasePersistentObject
    {
        public SaludationSuffix(Session session) : base(session) { } 

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            IsActive = true;
        }

        private string _Suffix;
        [Size(10)]
        public string Suffix
        {
            get
            {
                return _Suffix;
            }
            set
            {
                SetPropertyValue("Suffix", ref _Suffix, value);
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

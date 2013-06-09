using System;

using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using JanusERP.Module.Base;
using System.Drawing;
using DevExpress.Xpo.Metadata;

namespace JanusERP.Module.Entities.SystemManager
{
    [VisibleInReports(true)]
    [CreatableItem(false), NavigationItem("System Manager")]
    [DefaultProperty("SaludationDescription")]
   public class Saludation : BasePersistentObject
    {
        public Saludation(Session session)
            : base(session)
        { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            IsActive = true;
        }

        private string _SaludationDescription;
        [Size(30)]
        public string SaludationDescription
        {
            get
            {
                return _SaludationDescription;
            }
            set
            {
                SetPropertyValue("SaludationDescription", ref _SaludationDescription, value);
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

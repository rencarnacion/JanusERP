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
    [DefaultProperty("SourceCode")]
    public class Source : BasePersistentObject
    {
        public Source(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            IsActive = true;
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


        private string _SourceCode;
        [Size(30)]
        public string SourceCode
        {
            get
            {
                return _SourceCode;
            }
            set
            {
                SetPropertyValue("SourceCode", ref _SourceCode, value);
            }
        }

        private string _SourceDescription;
        [Size(100)]
        public string SourceDescription
        {
            get
            {
                return _SourceDescription;
            }
            set
            {
                SetPropertyValue("SourceDescription", ref _SourceDescription, value);
            }
        }
    }
}
